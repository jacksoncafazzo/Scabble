using Nancy;
using System.Collections.Generic;

namespace ScrabbleNamespace
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["scrabble.cshtml"];
      };
      Post["/results"] = _ =>
      {
        Scrabble score = new Scrabble(Request.Form["input"]);
        List<Scrabble> allScores =  Scrabble.GetAll();
        return View["scrabble.cshtml", allScores];
      };

    }
  }
}
