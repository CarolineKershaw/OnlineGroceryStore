using System;
using System.Collections.Generic;

namespace API.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ShortDesc { get; set; }
        public string LongDesc { get; set; }
        public int Type { get; set; }
        public decimal Price { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}