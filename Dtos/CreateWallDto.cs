using System;
using System.ComponentModel.DataAnnotations;

namespace SocialWallApi.Dtos
{
    public record CreateWallDto
    {
        [Required]
        public string Title { get; init; }
        public string Description { get; init; }
    }
}