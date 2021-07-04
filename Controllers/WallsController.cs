using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SocialWallApi.Entities;
using SocialWallApi.Repositories;

namespace SocialWallApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WallsController : ControllerBase
    {
        private readonly InMemWallsRepository repository;

        public WallsController()
        {
            repository = new InMemWallsRepository();
        }

        [HttpGet]
        public IEnumerable<Wall> GetWalls() => repository.GetWalls();

        [HttpGet("{id}")]
        public ActionResult<Wall> GetWall(Guid id)
        {
            Wall wall = repository.GetWall(id);
            return (wall is null) ? NotFound() : wall;
        }
    }
}