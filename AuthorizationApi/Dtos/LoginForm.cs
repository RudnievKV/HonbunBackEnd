﻿using System.ComponentModel.DataAnnotations;

namespace AuthorizationApi.Dtos
{
    public record LoginForm
    {
        [Required]
        [EmailAddress]
        public string Email { get; init; }
        [Required]
        public string Password { get; init; }
    }
}
