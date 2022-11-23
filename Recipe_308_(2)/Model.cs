using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Gihyo
{

    public class User
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public ICollection<Post> Posts { get; set; }

    }

    public class Post
    {
        public int PostId { get; set; }
        public string Message { get; set; }
        public DateTime SentTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
