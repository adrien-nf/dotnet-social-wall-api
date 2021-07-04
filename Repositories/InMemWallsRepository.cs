using System;
using System.Collections.Generic;
using System.Linq;
using SocialWallApi.Entities;

namespace SocialWallApi.Repositories
{
    public class InMemWallsRepository
    {
        private readonly List<Wall> walls = new()
        {
            new Wall
            {
                Id = Guid.NewGuid(),
                Title = "Général",
                Description = "Un peu le bazar.",
                CreatedDate = DateTimeOffset.UtcNow,
            },
            new Wall
            {
                Id = Guid.NewGuid(),
                Title = "Vacances",
                Description = "Les vacances!",
                CreatedDate = DateTimeOffset.UtcNow,
            },
            new Wall
            {
                Id = Guid.NewGuid(),
                Title = "Courses",
                Description = "Les courses de la coloc.",
                CreatedDate = DateTimeOffset.UtcNow,
            }
        };

        public IEnumerable<Wall> GetWalls()
        {
            return walls;
        }

        public Wall GetWall(Guid id)
        {
            return walls.Where(wall => wall.Id == id).SingleOrDefault();
        }
    }
}