namespace Command.Domain.Models
{
    public class Text
    {
        public string Content { get; set; } = string.Empty;
        public string SelectedText { get; set; } = string.Empty;
        public int CursorPosition { get; set; }
    }
}
