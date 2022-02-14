
using Microsoft.AspNetCore.Razor.Language;

var sourceDocument = RazorSourceDocument.Create("Hello world", "");
var codeDocument = RazorCodeDocument.Create(sourceDocument);

var engine = RazorEngine.Create();
engine.Process(codeDocument);

var csharpDocument = codeDocument.GetCSharpDocument();
var csharp = csharpDocument.GeneratedCode;
Console.WriteLine(csharp);
