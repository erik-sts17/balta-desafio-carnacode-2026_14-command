using Command.Application.Services;
using Command.Domain.Abstractions;

namespace Command.Application.Commands
{
    public class BoldCommand(ITextEditorService editor, int start, int length) : IEditorCommand
    {
        private readonly ITextEditorService _editor = editor;
        private readonly int _start = start;
        private readonly int _length = length;

        public void Execute()
        {
            _editor.ApplyBold(_start, _length);
        }

        public void Undo()
        {
            _editor.RemoveBold(_start, _length);
        }
    }
}