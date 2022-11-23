using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.IO;
using System.Web;
using System.Threading.Tasks;
using MailKit.Security;
using MimeKit;

var mail = new MailSender
{
	From = "gihyo@example.com",
	To = new string[] { "dev01@example.com", "dev02@example.com" },
	Subject = "Test Mail",
	Body = "これはメール送信テストです。",
	Attachment = "example.png"
};
await mail.SendMailAsync();

public class MailSender
{
	public IEnumerable<string> To { get; set; }
	public IEnumerable<string> Cc { get; set; }
	public IEnumerable<string> Bcc { get; set; }
	public string From { get; set; }
	public string Subject { get; set; }
	public string Body { get; set; }
	public string Attachment { get; set; }

	public async Task SendMailAsync()
	{
		var message = new MimeKit.MimeMessage();
		// 受け取り先を設定(To, Cc, Bcc)
		if (To != null)
			foreach (var addr in To)
				message.To.Add(new MimeKit.MailboxAddress(
					PikupName(addr), addr));
		if (Cc != null)
			foreach (var addr in Cc)
				message.Cc.Add(new MimeKit.MailboxAddress(
					PikupName(addr), addr));
		if (Bcc != null)
			foreach (var addr in Bcc)
				message.Bcc.Add(new MimeKit.MailboxAddress(
					PikupName(addr), addr));
		// 差出人を設定
		message.From.Add(new MimeKit.MailboxAddress(
			PikupName(From), From));
		// 表題を設定
		message.Subject = Subject;
		// メール本文を設定
		var builder = new MimeKit.BodyBuilder();
		builder.TextBody = Body;
		message.Body = builder.ToMessageBody();
		// ファイルを添付する
		var (mtype, msubtype) = GetMimeType(Attachment);
		var attachment = new MimePart(mtype, msubtype)
		{
			Content = new MimeContent(File.OpenRead(Attachment),
				ContentEncoding.Default),
			ContentDisposition =
				new ContentDisposition(ContentDisposition.Attachment),
			ContentTransferEncoding = ContentEncoding.Base64,
			FileName = Path.GetFileName(Attachment)
		};

		var multipart = new Multipart("mixed");
		multipart.Add(builder.ToMessageBody());
		multipart.Add(attachment);
		message.Body = multipart;

		using (var smtp = new MailKit.Net.Smtp.SmtpClient())
		{
			int port = 587; // 587以外もある
			await smtp.ConnectAsync("smtp.example.com", port,
				SecureSocketOptions.Auto);
			await smtp.AuthenticateAsync("<username>",
				"<password>");
			await smtp.SendAsync(message);
			await smtp.DisconnectAsync(true);
		}
	}

	private static string PikupName(string mailaddress)
	{
		return new string(mailaddress.TakeWhile(x => x != '@').ToArray());
	}

	private static Dictionary<string, string> mimedict = new Dictionary<string, string>
	{
		[".gif"] = "image/gif",
		[".jpg"] = "image/jpeg",
		[".png"] = "image/png",
		[".pdf"] = "application/pdf",
		[".txt"] = "text/plain",
		[".zip"] = "application/zip",
		// 必要があれば追加
	};

	private static (string, string) GetMimeType(string path)
	{
		var ext = Path.GetExtension(path);
		var mtype = mimedict[ext].Split('/');
		return (mtype[0], mtype[1]);
	}
}
