using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SocialWallApi.Dtos;
using SocialWallApi.Entities;
using SocialWallApi.Repositories;

namespace SocialWallApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WallsController : ControllerBase
    {
        private readonly IWallsRepository repository;

        public WallsController(IWallsRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<WallDto> GetWalls() => repository.GetWalls().Select(wall => wall.AsDto());

        [HttpGet("{id}")]
        public ActionResult<WallDto> GetWall(Guid id)
        {
            Wall wall = repository.GetWall(id);
            return (wall is null) ? NotFound() : wall.AsDto();
        }

        [HttpPost]
        public ActionResult<WallDto> CreateWall(CreateWallDto wallDto)
        {
            Wall wall = new()
            {
                Id = Guid.NewGuid(),
                Title = wallDto.Title,
                Description = wallDto.Description,
                CreatedDate = DateTimeOffset.UtcNow,
            };

            repository.CreateWall(wall);

            return CreatedAtAction(nameof(GetWall), new { id = wall.Id }, wall.AsDto());
        }

        [HttpPut("{id}")]
        public ActionResult UpdateItem(Guid id, UpdateWallDto wallDto)
        {
            var existingWall = repository.GetWall(id);

            if (existingWall is null)
            {
                return NotFound();
            }

            Wall updatedWall = existingWall with
            {
                Title = wallDto.Title,
                Description = wallDto.Description
            };

            repository.UpdateWall(updatedWall);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteWall(Guid id)
        {
            var existingWall = repository.GetWall(id);

            if (existingWall is null)
            {
                return NotFound();
            }

            repository.DeleteWall(id);

            return NoContent();
        }
    }
}