using System;

namespace SocialWallApi.Entities
{
    public record Wall
    {
        public Guid Id { get; init; }
        public string Title { get; init; }
        public string Description { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}