using System;

namespace SocialWallApi.Dtos
{
    public record WallDto
    {
        public Guid Id { get; init; }
        public string Title { get; init; }
        public string Description { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}