using Microsoft.AspNetCore.Mvc;
using System;
using MadLib.Models;

namespace MadLib.Controllers 
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult StorySelector()
    {
      return View();
    }

    [Route("/madlibsform")]
    public ActionResult MadLibs(string path)
    {
      PathVariable newPath = new PathVariable();
      newPath.PathSetter = "/" + path;
      return View(newPath);
    }

    [Route("/zoo")]
    public ActionResult Zoo(string noun, string adjective, string verb, string place, string name)
    {
      MadLibVariables myMadLibVariables = new MadLibVariables();
      Console.WriteLine(noun);
      myMadLibVariables.Name = name;
      myMadLibVariables.Verb = verb;
      myMadLibVariables.Noun = noun;
      myMadLibVariables.Adjective = adjective;
      myMadLibVariables.Place = place;
      return View(myMadLibVariables);
    }

    [Route("/goosebumps")]
    public ActionResult Goosebumps(string noun, string verb, string name)
    {
      MadLibVariables myMadLibVariables = new MadLibVariables();
      myMadLibVariables.Name = name;
      myMadLibVariables.Verb = verb;
      myMadLibVariables.Noun = noun;
      return View(myMadLibVariables);
    }

    [Route("/puppies")]
    public ActionResult Puppies(string noun, string noun2, string adjective, string adjective2, string adverb)
    {
      MadLibVariables myMadLibVariables = new MadLibVariables();
      myMadLibVariables.Noun = noun;
      myMadLibVariables.Noun2 = noun2;
      myMadLibVariables.Adjective = adjective;
      myMadLibVariables.Adjective2 = adjective2;
      myMadLibVariables.Adverb = adverb;
      return View(myMadLibVariables);
    }
  }
}