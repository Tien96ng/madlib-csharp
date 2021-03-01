using Microsoft.AspNetCore.Mvc;
using System;
using MadLib.Models;

namespace MadLib.Controllers 
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult MadLibs()
    {
      // PathVariable newPath = new PathVariable();
      // newPath.PathSetter = "action=/" + path;
      return View();
    }

    [Route("/zoo")]
    public ActionResult Zoo(string noun, string adjective, string verb, string place, string name)
    {
      MadLibVariables myMadLibVariables = new MadLibVariables();
      myMadLibVariables.Noun = noun;
      myMadLibVariables.Adjective = adjective;
      myMadLibVariables.Verb = verb;
      myMadLibVariables.Place = place;
      myMadLibVariables.Name = name;
      return View(myMadLibVariables);
    }

    [Route("/goosebumps")]
    public ActionResult Goosebumps(string noun, string adjective, string verb, string place, string name)
    {
      MadLibVariables myMadLibVariables = new MadLibVariables();
      myMadLibVariables.Noun = noun;
      myMadLibVariables.Adjective = adjective;
      myMadLibVariables.Verb = verb;
      myMadLibVariables.Place = place;
      myMadLibVariables.Name = name;
      return View(myMadLibVariables);
    }

    [Route("/puppies")]
    public ActionResult Puppies(string noun, string adjective, string verb, string place, string name)
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