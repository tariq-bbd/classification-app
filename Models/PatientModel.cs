﻿using System.ComponentModel.DataAnnotations;

namespace ClassificationApp.Models
{
    public class PatientModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        [MaxLength(250)]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}
