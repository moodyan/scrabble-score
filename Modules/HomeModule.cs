using Nancy;
using ScrabbleScore.Objects;
using System.Collections.Generic;

namespace ScrabbleScore.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
      return View["index.cshtml"];
      };
      
      Post["/"] = _ => {
      Scrabble newScrabble = new Scrabble();
      int output = newScrabble.GetScrabbleScore(Request.Form["user-input"]);
      return View["index.cshtml", output];
      };
    }
  }
}
