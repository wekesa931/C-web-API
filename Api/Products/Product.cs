using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Product
    {
        public string Code {get; set;}
        public string Description {get; set;}
        public DateTime CreationDate {get; set;}
        public double Price {get; set;}
        [Required]
        public string StreetName {get; set;}
    }
}