﻿using System.ComponentModel.DataAnnotations;

namespace Backend.DTO.AccountDTO
{
    public class UserCredentials
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

       

    }
}
