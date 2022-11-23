using System;
using System.Collections.Generic;
using System.Linq;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Packaging;

string filename = "example.docx";
using var word = MyWordDoc.Open(filename);
var stylename = "Sample Style";
var styleid = "SampleStype";
styleid = word.AddStyleIfNotDefined(styleid, stylename);
Paragraph p = word.GetParagraphs().ElementAtOrDefault(0);
word.ApplyStyleToParagraph(styleid, p);

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

	public string AddStyleIfNotDefined(string styleid, string stylename)
	{
		// このドキュメントのスタイルパーツを取得します。
		StyleDefinitionsPart part = _document.MainDocumentPart.StyleDefinitionsPart;
		// Stylesパーツが存在しない場合は、それを追加してからスタイルを追加します。
		part ??= AddStylesPartToPackage();
		// スタイルがドキュメントにない場合は、追加します。
		if (IsStyleIdInDocument(styleid) != true)
		{
			// styleidが一致しないため、スタイル名で試してみる。
			string styleidFromName = GetStyleIdFromStyleName(stylename);
			if (styleidFromName == null)
			{
				AddNewStyle(part, styleid, stylename);
			}
			else
				styleid = styleidFromName;
		}
		return styleid;
	}

	// StylesDefinitionsPartをドキュメントに追加します。 それへの参照を返します。
	private StyleDefinitionsPart AddStylesPartToPackage()
	{
		StyleDefinitionsPart part
			= _document.MainDocumentPart.AddNewPart<StyleDefinitionsPart>();
		var root = new Styles();
		root.Save(part);
		return part;
	}

	// ドキュメントにstyleidがある場合はtrueを返し、そうでない場合はfalseを返します。
	private bool IsStyleIdInDocument(string styleid)
	{
		// このドキュメントのStyles要素へのアクセスを取得します。
		Styles s = _document.MainDocumentPart.StyleDefinitionsPart.Styles;

		// スタイルとその数があることを確認します。
		int n = s.Elements<Style>().Count();
		if (n == 0)
			return false;

		// styleidの一致を探します。
		Style style = s.Elements<Style>()
			.Where(st => (st.StyleId == styleid) && (st.Type == StyleValues.Paragraph))
			.FirstOrDefault();
		return style != null;
	}

	// styleNameに一致するstyleidを返すか、一致しない場合はnullを返します。
	private string GetStyleIdFromStyleName(string styleName)
	{
		StyleDefinitionsPart stylePart = _document.MainDocumentPart.StyleDefinitionsPart;
		string styleId = stylePart.Styles.Descendants<StyleName>()
			.Where(s => s.Val.Value.Equals(styleName) &&
				(((Style)s.Parent).Type == StyleValues.Paragraph))
			.Select(n => ((Style)n.Parent).StyleId).FirstOrDefault();
		return styleId;
	}

	// 指定したstyleidとstylenameで新しいスタイルを作成し、指定したスタイル定義パーツに追加します。
	private void AddNewStyle(StyleDefinitionsPart styleDefinitionsPart,
		string styleid, string stylename)
	{
		// スタイルパーツのルート要素にアクセスします。
		Styles styles = styleDefinitionsPart.Styles;

		// 新しい段落スタイルを作成し、いくつかのプロパティを指定します。
		var style = new Style()
		{
			Type = StyleValues.Paragraph,
			StyleId = styleid,
			CustomStyle = true
		};
		var styleName = new StyleName() { Val = stylename };
		var basedOn = new BasedOn() { Val = "Normal" };
		var nextParagraphStyle = new NextParagraphStyle() { Val = "Normal" };
		style.Append(styleName);
		style.Append(basedOn);
		style.Append(nextParagraphStyle);

		// StyleRunPropertiesオブジェクトを作成し、いくつかの実行プロパティを指定します。
		var styleRunProperties = new StyleRunProperties();
		var bold = new Bold();
		var color = new Color() { ThemeColor = ThemeColorValues.Accent1 };
		var font = new RunFonts() { EastAsia = "Meiryo UI" };

		// 24ポイントのサイズを指定します。
		var fontSize = new FontSize() { Val = "48" };
		// 実行プロパティに色やフォント等を追加する
		styleRunProperties.Append(bold);
		styleRunProperties.Append(color);
		styleRunProperties.Append(font);
		styleRunProperties.Append(fontSize);

		// 実行プロパティをスタイルに追加します。
		style.Append(styleRunProperties);

		// スタイルをスタイルパーツに追加します。
		styles.Append(style);
	}

	// 段落にスタイルを適用します。
	public void ApplyStyleToParagraph(string styleid, Paragraph p)
	{
		// 段落にParagraphPropertiesオブジェクトがない場合は作成します。
		if (p.Elements<ParagraphProperties>().Count() == 0)
		{
			p.PrependChild<ParagraphProperties>(new ParagraphProperties());
		}

		// 段落の段落プロパティ要素を取得します。
		var pPr = p.Elements<ParagraphProperties>().First();

		// 段落のスタイルを設定します。
		pPr.ParagraphStyleId = new ParagraphStyleId() { Val = styleid };
	}
}
