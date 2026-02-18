using Command.Application.Services;
using Command.Domain.Abstractions;

namespace Command.Application.Commands
{
    public class DeleteTextCommand(ITextEditorService editor, int length) : IEditorCommand
    {
        private readonly ITextEditorService _editor = editor;
        private readonly int _length = length;
        private int _position;
        private readonly string _deletedText = "";

        public void Execute()
        {
            _position = _editor.GetCursorPosition();
            _editor.Delete(_position, _length);
        }

        public void Undo()
        {
            _editor.Insert(_position - _length, _deletedText);
        }
    }
}