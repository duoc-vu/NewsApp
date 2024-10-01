using System.ComponentModel.DataAnnotations;

namespace NewsApp.Models
{
    public class Category
    {
        public Category()
        {
            Posts = new HashSet<Post>();    
        }
        [Key]
        public int ID { get; set; }
        [StringLength(20)]
        public string CategoryName { get; set; }

        public ICollection<Post> Posts { get; set; }

    }
}
