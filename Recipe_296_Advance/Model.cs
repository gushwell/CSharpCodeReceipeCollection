using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Gihyo
{

    [Index(nameof(Name), IsUnique = true)]
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public ICollection<Post> Posts { get; set; }
    }

    [Index(nameof(SentTime), Name = "Index_SentTime")]
    public class Post
    {
        public int PostId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public DateTime SentTime { get; set; }
        public int Published { get; set; }
        public Category? Categoty { get; set; }
        public User User { get; set; }

    }

    public enum Category
    {
        Other = 0,
        Mysteries,
        SF,
        Fantasy,
        Romance,
        Historical,
    }
}
