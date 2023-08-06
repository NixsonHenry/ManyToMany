namespace ManyToMany.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = null;
        public string Description { get; set; } = null;
        public string Author { get; set; } = null;
        public List<Tag> Tags { get; } = new();
    }
}
