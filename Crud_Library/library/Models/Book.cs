using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace library.Models;

[Table("books")]
public class Book
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("title")]
    [RegularExpression(@"^[a-z\s]+$", ErrorMessage = "The field must be in lowercase.")]
    [MaxLength(255, ErrorMessage = "The field must be at most {1} characters.")]
    public required string Title { get; set; }

    [Column("author")]
    [RegularExpression(@"^[a-z\s]+$", ErrorMessage = "The field must be in lowercase.")]
    [MaxLength(255, ErrorMessage = "The field must be at most {1} characters.")]
    public string? Author { get; set; }

    [Column("publication_year")]
    public int? PublicationYear { get; set; }

    [Column("price")]
    public required decimal Price { get; set; }

    [Column("available")]
    public required bool Available { get; set; }

    [Column("number_of_pages")]
    public required int NumberOfPages { get; set; }

    [Column("genre")]
    [RegularExpression(@"^[a-z\s]+$", ErrorMessage = "The field must be in lowercase.")]
    [MaxLength(255, ErrorMessage = "The field must be at most {1} characters.")]
    public required string Genre { get; set; }

    [Column("editorial")]
    [RegularExpression(@"^[a-z\s]+$", ErrorMessage = "The field must be in lowercase.")]
    [MaxLength(255, ErrorMessage = "The field must be at most {1} characters.")]
    public string? Editorial { get; set; }

    [Column("original_language")]
    [RegularExpression(@"^[a-z\s]+$", ErrorMessage = "The field must be in lowercase.")]
    [MaxLength(100, ErrorMessage = "The field must be at most {1} characters.")]
    public required string OriginalLanguage { get; set; }
}
