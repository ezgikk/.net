namespace MauiApp6
{
    internal class UserPage
    {
        public UserPage()
        {
        }

        public string Title { get; set; }
        public object AddMethod { get; set; }
        public ToDoList User { get; internal set; }
    }
}