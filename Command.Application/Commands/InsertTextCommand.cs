using Command.Application.Services;
using Command.Domain.Abstractions;

namespace Command.Application.Commands
{
    class InsertTextCommand(ITextEditorService editor, string text) : IEditorCommand
    {
        private readonly ITextEditorService _editor = editor;
        private readonly string _text = text;
        private int _position = 0;
 
        public void Execute()
        {
            _position = _editor.GetCursorPosition();
            _editor.Insert(_position, _text);
        }

        public void Undo()
        {
            _editor.Delete(_text.Length, _position);
        }
    }
}