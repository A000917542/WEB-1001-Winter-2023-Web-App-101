namespace WEB_1001_Winter_2023_Web_App_101.Models
{
    public class BlogPost
    {
        public DateTime PublishDate { get; set; } = DateTime.MinValue;

        public string Title { get; set; } = String.Empty;

        public string Content { get; set; } = String.Empty;

        public Author? Author { get; set; }

        public string Description { get; set; } = String.Empty;

        public ICollection<string> Tags { get; set; } = new List<string>();
    }
}
