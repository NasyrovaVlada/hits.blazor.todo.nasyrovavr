﻿using System.ComponentModel.DataAnnotations;

namespace TodoServerApp.Data
{
    public class UserElement
    {
        public int Id { get; set; }
        [Required]
        public string? Surname { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Patronymic { get; set; }
    }
}
