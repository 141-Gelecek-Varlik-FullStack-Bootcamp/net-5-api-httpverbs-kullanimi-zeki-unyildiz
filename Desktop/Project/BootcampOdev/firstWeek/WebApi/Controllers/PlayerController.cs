using Microsoft.AspNetCore.Mvc;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ControllerBase
    {
        private static List<Player> _players = new List<Player>()
        {
            new Player{
                PlayerID = 1,
                FirstName = "Bakasetas",
                LastName = "Tasos",
                Team = "Trabzonspor",
                Number = 11
            },
            new Player{
                PlayerID = 2,
                FirstName = "Abdulkadir",
                LastName = "Omur",
                Team = "Trabzonspor",
                Number = 10
            },
            new Player{
                PlayerID = 3,
                FirstName = "Anthony",
                LastName = "Nwakaeme",
                Team = "Trabzonspor",
                Number = 9
            },
            new Player{
                PlayerID = 4,
                FirstName = "Marek",
                LastName = "Hamsik",
                Team = "Trabzonspor",
                Number = 17
            },
            new Player{
                PlayerID = 5,
                FirstName = "Andreas",
                LastName = "Cornelius",
                Team = "Trabzonspor",
                Number = 14
            },
    };

        [HttpGet]
        public List<Player> Get()
        {
            var player = _players.ToList<Player>();
            return player;
        }

    }
}