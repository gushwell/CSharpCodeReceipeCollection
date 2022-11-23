using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gihyo
{

    public class Novel
    {
        public int NovelId { get; set; }
        public string Title { get; set; }
        public int Published { get; set; }
        // HasConversionメソッドの代わりに次のように書ける
        // [Column(TypeName = "nvarchar(10)")])]
        public Category Category { get; set; }
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
