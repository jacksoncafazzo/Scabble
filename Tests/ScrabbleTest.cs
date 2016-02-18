using System;
using System.Collections.Generic;
using Xunit;

namespace ScrabbleNamespace
{
  public class ScrabbleTest
  {
    [Fact]
    public void ScrabbleScore_inputWordKGetScore_true()
    {
      Scrabble score = new Scrabble("K");
      Assert.Equal(5, score.ScrabbleScore());
    }
    [Fact]
    public void ScrabbleScore_inputWordKittyGetScore_true()
    {
      Scrabble score = new Scrabble("KITTY");
      Assert.Equal(12, score.ScrabbleScore());
    }
    [Fact]
    public void ScrabbleScroe_inputWordCatLowerCaseGetScore_true()
    {
      Scrabble score = new Scrabble("cat");
      Assert.Equal(5, score.ScrabbleScore());
    }


  }



}
