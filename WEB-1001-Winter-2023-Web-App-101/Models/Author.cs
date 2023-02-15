namespace WEB_1001_Winter_2023_Web_App_101.Models
{
    public class Author
    {
        public string Email { get; set; } = String.Empty;

        public Uri? Photo { get; set; }

        public string FullName { get; set; } = String.Empty;
    }
}
