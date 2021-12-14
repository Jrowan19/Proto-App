using System.ComponentModel.DataAnnotations;

namespace DemoForm.Models
{
    public class Category
    {

        [Key]
        public int Id { get; set; }

        public string Categories { get; set; }

    }
}
