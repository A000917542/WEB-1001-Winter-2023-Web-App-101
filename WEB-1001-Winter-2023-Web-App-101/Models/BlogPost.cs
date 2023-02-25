using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace WEB_1001_Winter_2023_Web_App_101.Models
{
    public class BlogPost
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime PublishDate { get; set; } = DateTime.MinValue;

        [Required]
        public string Title { get; set; } = String.Empty;

        [Required]
        [MinLength(255)]
        public string Content { get; set; } = String.Empty;

        //[Required]
        public Author? Author { get; set; }

        [Required]
        public string Description { get; set; } = String.Empty;

        [MaxLength(5)]
        public ICollection<string> Tags { get; set; } = new List<string>();
    }
}
