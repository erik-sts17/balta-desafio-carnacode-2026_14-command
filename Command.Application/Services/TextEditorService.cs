using Command.Domain.Models;

namespace Command.Application.Services
{
    public class TextEditorService() : ITextEditorService
    {
        private readonly Text _text = new();

        public void Insert(int position, string value)
        {
            _text.Content = _text.Content.Insert(position, value);
            _text.CursorPosition = position + value.Length;

            Console.WriteLine($"[Insert] {_text.Content}");
        }

        public int GetCursorPosition()
        {
           return _text.CursorPosition;
        }

        public void Delete(int position, int length)
        {
            _text.Content = _text.Content[..length];
            _text.CursorPosition = position;

            Console.WriteLine($"[Delete] {_text.Content}");
        }

        public void ApplyBold(int start, int length)
        {
            Console.WriteLine($"[Bold ON] {start}-{start + length}");
        }

        public void RemoveBold(int start, int length)
        {
            Console.WriteLine($"[Bold OFF] {start}-{start + length}");
        }

        public string GetContent() 
        {
            return _text.Content;
        }
    }
}
