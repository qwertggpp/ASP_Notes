namespace Notes.Notes
{
    public class Note
    {
        public Note(string title, string description)
        {
            Title = title;
            Description = description;
            CreateAt = DateTime.Now;
        }

        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreateAt { get; set; }
    }
}
