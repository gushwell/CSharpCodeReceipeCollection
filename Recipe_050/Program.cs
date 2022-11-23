using System;
using System.Text;

var phrase = "The quick brown fox jumps over the lazy dog.";
var sb = new StringBuilder(phrase);
sb.Replace("fox", "hare");
sb.Replace("dog", "turtle");
sb.Replace("brown", "white");
var text = sb.ToString();
Console.WriteLine(text);