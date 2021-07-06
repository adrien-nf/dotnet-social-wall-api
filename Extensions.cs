using SocialWallApi.Dtos;
using SocialWallApi.Entities;

namespace SocialWallApi
{
    public static class Extensions
    {
        public static WallDto AsDto(this Wall wall)
        {
            return new WallDto
            {
                Id = wall.Id,
                Title = wall.Title,
                Description = wall.Description,
                CreatedDate = wall.CreatedDate,
            };
        }
    }
}