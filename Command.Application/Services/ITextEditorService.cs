namespace Command.Application.Services
{
    public interface ITextEditorService
    {
        void Delete(int position, int length);
        void ApplyBold(int start, int length);
        void RemoveBold(int start, int length);
        void Insert(int position, string value);
        int GetCursorPosition();
        string GetContent();
    }
}