using CryptoExchange.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CryptoExchange.Models
{
    [Table(name: "Items")]
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemID { get; set; }

        
        public string Edition { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal ItemRate { get; set; }

        public string Creator { get; set; }

        public string ImageURL { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }


        [ForeignKey(nameof(Item.CategoryId))]
        public Category Category { get; set; }
    }
}
