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

    }
  }
}
