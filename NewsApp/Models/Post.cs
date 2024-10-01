using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsApp.Models
{
    public class Post
    {
        /// <summary>
        /// 2 cách thiết lập quan hệ
        /// cách 1 sử dụng annotation
        /// sử dụng config ở DbContext
        /// </summary>
        [Key]
        public int ID { get; set; }
        [StringLength(50)]
        public string PostTitle { get; set; }
        [Column(TypeName = "ntext")]
        public string PostContent { get; set; }
        [StringLength(400)]
        public string PostTeaser { get; set; }
        public int ViewCount { get; set; }
        [ForeignKey("CateID")]
        public int CateID { get; set; }
        public virtual Category Category { get; set;}
    }
}
