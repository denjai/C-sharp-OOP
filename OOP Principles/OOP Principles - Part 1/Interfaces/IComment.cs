namespace School
{
    public interface IComment
    {
        string Comment { get; }
        void ChangeComment(string comment);
    }
}
