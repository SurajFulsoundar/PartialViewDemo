using System.ComponentModel.DataAnnotations.Schema;

namespace PartialViewDemo.Models
{
    [Table("Book1")]
    public class Book
    {
       public int Id { get; set; }
       public string? Name { get; set; }
       public string? Author { get; set; }
       public int Price { get; set; }
        
    }
}
