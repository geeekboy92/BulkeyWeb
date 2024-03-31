using System.ComponentModel.DataAnnotations;

namespace BulkeyWeb.Models;

public class Category
{
    [Key] //data annotation and next property will be primary KEY Category Table
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    public int DisplayOrder { get; set; }
}
