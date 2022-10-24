using Microsoft.AspNetCore.Mvc;
using ControllerExample.Model;
namespace ControllerExample.Controllers;

[ApiController]
[Route("Score/")]
public class ScoreController : ControllerBase
{
    [HttpGet("AddUser/{score}")]
    public IActionResult AddUser(Score score)
    {
        QueryExampleContext context = new QueryExampleContext();
        context.Add(score);
        context.SaveChanges();
        return Ok();
    }
    [HttpGet("test")]
    public IActionResult AddUserTest()
    {
        QueryExampleContext context = new QueryExampleContext();
        
        Score score = new Score();
        score.Player1 = "Pedro";
        score.Player2 = "Joao";
        score.ScorePlayer1 = "5";
        score.ScorePlayer2 = "6";

        context.Add(score);
        context.SaveChanges();
        return Ok();
    }
    
}
