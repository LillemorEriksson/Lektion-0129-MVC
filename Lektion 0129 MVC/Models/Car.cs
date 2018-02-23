using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lektion_0129_MVC.Models
{
    public class Car
    {
        static int nextId = 1;

        [Key]

        public int Id { get; private set; }
        [Display(Name = "Max Speed")]// så här skriver du om du vill ha mellanslag mellan Max och Speed som exempel
        [Range(1,500)]

        public double MaxSpeed { get; set; }
        //[DataType(DataType.Password)] så här kan du dölja lösenord.
        //[Required(ErrorMessage = " You must have a Model name!!!")] så här kan du skriva om du inte vill ha egna standar meddelandet. Auto
        [Required]
        [MinLength(1)]
        [MaxLength(150)]

        public string Model { get; set; }
        [Required]
        [MinLength(1)]
        [MaxLength(150)]

        public string Brand { get; set; }


        public Car()

        {
            Id = nextId++;
        }

    }
}