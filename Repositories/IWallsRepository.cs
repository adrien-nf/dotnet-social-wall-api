using System;
using System.Collections.Generic;
using SocialWallApi.Entities;

namespace SocialWallApi.Repositories
{
    public interface IWallsRepository
    {
        Wall GetWall(Guid id);
        IEnumerable<Wall> GetWalls();
    }
}