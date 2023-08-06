namespace ManyToMany.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Post> Posts { get; set; } = new();

    }
}
