using Command.Application.Services;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddTransient<ITextEditorService, TextEditorService>();

var provider = services.BuildServiceProvider();

var service = provider.GetRequiredService<ITextEditorService>();

var app = new EditorApplication(service);

Console.WriteLine("===== DIGITANDO =====");
app.TypeText("Hello");
app.TypeText(" World");
app.ShowContent();

Console.WriteLine("===== DELETANDO =====");
app.DeleteCharacters(5); // remove " World"
app.ShowContent();

Console.WriteLine("===== NEGRITO =====");
app.MakeBold(0, 5); // Hello em bold

Console.ReadKey();