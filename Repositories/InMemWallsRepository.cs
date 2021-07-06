using System;
using System.Collections.Generic;
using System.Linq;
using SocialWallApi.Entities;

namespace SocialWallApi.Repositories
{
    public class InMemWallsRepository : IWallsRepository
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

        public void CreateWall(Wall wall)
        {
            walls.Add(wall);
        }

        public void UpdateWall(Wall wall)
        {
            var index = walls.FindIndex(e => e.Id == wall.Id);
            walls[index] = wall;
        }

        public void DeleteWall(Guid id)
        {
            var index = walls.FindIndex(e => e.Id == id);
            walls.RemoveAt(index);
        }
    }
}