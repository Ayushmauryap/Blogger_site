using System.ComponentModel.DataAnnotations;

namespace BloggerApp.Models;

public class Post
{
    public int Id { get; set; }

    [Required]
    [StringLength(200)]
    public string Title { get; set; } = string.Empty;

    [Required]
    [MinLength(10)]
    public string Content { get; set; } = string.Empty;

    [StringLength(80)]
    public string Author { get; set; } = "Anonymous";

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}
