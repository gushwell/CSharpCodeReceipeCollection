using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Gihyo
{

    public class Novel
    {
        public int NovelId { get; set; }
        public string Title { get; set; }
        public int Published { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
        [Timestamp]
        public byte[] Timestamp { get; set; }
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
