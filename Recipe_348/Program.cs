using System;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Packaging;

var filepath = "example.docx";
using var doc = new MyWordDoc(filepath);
doc.AppendParagraph("色は匂へど 散りぬるを 我が世誰ぞ 常ならむ");
doc.AppendParagraph2("有為の奥山 今日越えて 浅き夢見じ 酔ひもせず");

sealed class MyWordDoc : IDisposable
{
	private WordprocessingDocument _document;
	private Body _body;

	public MyWordDoc(string filepath)
	{
		_document = WordprocessingDocument.Create(filepath, WordprocessingDocumentType.Document);
		MainDocumentPart mainPart = _document.AddMainDocumentPart();
		mainPart.Document = new Document();
		_body = mainPart.Document.AppendChild(new Body());
	}

	public void Dispose() => _document?.Dispose();

	public void AppendParagraph(string text)
	{
		Paragraph para = _body.AppendChild(new Paragraph());
		Run run = para.AppendChild(new Run());
		run.AppendChild(new Text(text));
	}
	public void AppendParagraph2(string text)
	{
		_body.AppendChild(
			new Paragraph(
				new Run(
					new Text(text)
				)
			)
		);
	}
}
