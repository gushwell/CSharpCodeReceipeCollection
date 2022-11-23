using System;
using System.Linq;
using System.Collections.Generic;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Packaging;

var filepath = "example.docx";
using var word = MyWordDoc.Open(filepath);
Paragraph p = word.GetParagraphs().ElementAtOrDefault(1);
word.InsertParagraph(p, "我が世誰ぞ 常ならむ");
word.AppendParagraph("浅き夢見じ 酔ひもせず");

sealed class MyWordDoc : IDisposable
{
	private WordprocessingDocument _document;
	private Body _body;
	public MyWordDoc()
	{

	}
	public MyWordDoc(string filepath)
	{
		_document = WordprocessingDocument.Create(filepath, WordprocessingDocumentType.Document);
		MainDocumentPart mainPart = _document.AddMainDocumentPart();
		mainPart.Document = new Document();
		_body = mainPart.Document.AppendChild(new Body());
	}

	public void Dispose() => _document?.Dispose();

	public static MyWordDoc Open(string filepath)
	{
		var obj = new MyWordDoc();
		obj._document = WordprocessingDocument.Open(filepath, true);
		obj._body = obj._document.MainDocumentPart.Document.Body;
		return obj;
	}
	public void AppendParagraph(
			string text,
			JustificationValues justificationValue = JustificationValues.Left)
	{
		var prop = new ParagraphProperties();
		Justification justification = new Justification()
		{
			Val = justificationValue
		};
		prop.Append(justification);

		Paragraph para = _body.AppendChild(new Paragraph(prop));
		Run run = para.AppendChild(new Run());
		run.AppendChild(new Text(text));
	}

	public IEnumerable<Paragraph> GetParagraphs()
		=> _document.MainDocumentPart.Document.Body.Descendants<Paragraph>();

	public void InsertParagraph(Paragraph para, string text)
	{
		var newpara = _body.InsertBefore(new Paragraph(), para);
		Run run = newpara.AppendChild(new Run());
		run.AppendChild(new Text(text));
	}
}
