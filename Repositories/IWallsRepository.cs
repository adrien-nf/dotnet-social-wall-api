using System;
using System.Collections.Generic;
using SocialWallApi.Entities;

namespace SocialWallApi.Repositories
{
    public interface IWallsRepository
    {
        Wall GetWall(Guid id);
        IEnumerable<Wall> GetWalls();

        void CreateWall(Wall wall);
        void UpdateWall(Wall wall);
        void DeleteWall(Guid id);
    }
}