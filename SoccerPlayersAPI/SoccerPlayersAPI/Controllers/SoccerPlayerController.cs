using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoccerPlayersAPI.Models;

namespace SoccerPlayersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoccerPlayerController : ControllerBase
    {
        private static List<SoccerPlayer> soccerPlayers = new List<SoccerPlayer> {
                new SoccerPlayer
                {   Id = 1,
                    FirstName = "Kevin",
                    LastName = "De Bruyne",
                    HomeCountry = "Belgium",
                    Position = "Midfield"
                },
                new SoccerPlayer
                {
                    Id = 2,
                    FirstName = "Karim",
                    LastName = "Benzema",
                    HomeCountry = "France",
                    Position = "Forward"
                }
        };

        [HttpGet]

        public async Task<ActionResult<List<SoccerPlayer>>> GetAllPlayers()
        {
            //Produces 200 ok response
             return Ok(soccerPlayers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SoccerPlayer>> GetSinglePlayer(int id)
        {
            var player = soccerPlayers.Find(x => x.Id == id);
            if(player is null)
            {
                return NotFound("Sorry that player doesn't exist"); //404 not found
            }
            //Produces 200 ok response
            return Ok(player);
        }

        [HttpPost]
        public async Task<ActionResult<List<SoccerPlayer>>> AddPlayer([FromBody]SoccerPlayer player)
        {
            soccerPlayers.Add(player);
            //Produces 200 ok response  
            return Ok(soccerPlayers);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<SoccerPlayer>>> UpdatePlayer(int id, SoccerPlayer request)  
        {
            var player = soccerPlayers.Find(x => x.Id == id);
            if (player is null)
            {
                return NotFound("Sorry that player doesn't exist"); //404 not found
            }

            player.FirstName = request.FirstName;
            player.LastName = request.LastName;
            player.HomeCountry = request.HomeCountry;
            player.Position= request.Position;

            //Produces 200 ok response
            return Ok(soccerPlayers);
        }

    }
}
