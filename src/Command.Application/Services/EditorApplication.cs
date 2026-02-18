using Command.Application.Commands;
using Command.Domain.Abstractions;

namespace Command.Application.Services
{
    public class EditorApplication(ITextEditorService editor)
    {
        private readonly ITextEditorService _editor = editor;
        private readonly Stack<IEditorCommand> _undoStack = new();
        private readonly Stack<IEditorCommand> _redoStack = new();

        private void ExecuteCommand(IEditorCommand command)
        {
            command.Execute();
            _undoStack.Push(command);
            _redoStack.Clear();
        }

        public void TypeText(string text)
        {
            ExecuteCommand(new InsertTextCommand(_editor, text));
        }

        public void DeleteCharacters(int count)
        {
            ExecuteCommand(new DeleteTextCommand(_editor, count));
        }

        public void MakeBold(int start, int length)
        {
            ExecuteCommand(new BoldCommand(_editor, start, length));
        }

        public void ShowContent()
        {
            Console.WriteLine($"\n=== Conteúdo do Editor ===");
            Console.WriteLine($"'{_editor.GetContent()}'");
            Console.WriteLine($"Cursor na posição: {_editor.GetCursorPosition()}\n");
        }
    }
}