namespace Command.Domain.Abstractions
{
    public interface IEditorCommand
    {
        void Execute();
        void Undo();
    }
}