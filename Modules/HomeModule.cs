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

        return View["scrabble_results.cshtml", score];
      };

    }
  }
}
