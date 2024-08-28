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
    public required string Title { get; set; }

    [Column("author")]
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
    public required string Genre { get; set; }

    [Column("editorial")]
    public string? Editorial { get; set; }

    [Column("original_language")]
    public required string OriginalLanguage { get; set; }
}
