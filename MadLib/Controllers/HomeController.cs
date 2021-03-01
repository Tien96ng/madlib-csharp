using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers 
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult MadLibs()
    {
      return View();
    }

    [Route("/story")]
    public ActionResult Story(string noun, string adjective, string verb, string place, string name)
    {
      MadLibVariables myMadLibVariables = new MadLibVariables();
      myMadLibVariables.Noun = noun;
      myMadLibVariables.Adjective = adjective;
      myMadLibVariables.Verb = verb;
      myMadLibVariables.Place = place;
      myMadLibVariables.Name = name;
      return View(myMadLibVariables);
    }
  }
}