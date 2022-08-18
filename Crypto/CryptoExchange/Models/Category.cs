using CryptoExchange.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CryptoExchange.Models
{
    [Table(name:"Categories")]
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Image { get; set; }

        public ICollection<Item>Items { get; set; }
    }
}
