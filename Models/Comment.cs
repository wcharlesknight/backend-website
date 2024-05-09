
using System.ComponentModel.DataAnnotations;

namespace BackendWebsite.Models
{
    public class Comment
    {
        [Key]
        public int Id
        {
            get; set;
        }
        /// <summary>
        /// Gets or sets the message of the comment.
        /// </summary>
        public string Message
        {
            get; set;
        }
    }
}
