using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Person
    {
        public int Id { get; set; }

        [MaxLength(40)]
        public string Name { get; set; }

        [MaxLength(15)]
        public string PersonalNumber { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}