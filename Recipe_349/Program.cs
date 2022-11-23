using System;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Packaging;

var filepath = "example.docx";
using var word = new MyWordDoc(filepath);
word.AppendParagraph("色は匂へど 散りぬるを", JustificationValues.Left);
word.AppendParagraph("我が世誰ぞ 常ならむ", JustificationValues.Center);
word.AppendParagraph("有為の奥山 今日越えて", JustificationValues.Right);
word.AppendParagraph("浅き夢見じ 酔ひもせず");

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
}
