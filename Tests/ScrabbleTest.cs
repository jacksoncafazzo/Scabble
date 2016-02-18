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
      Scrabble score = new Scrabble("k");
      Assert.Equal(5, score.ScrabbleScore());

      // Anagram newAnagram = new Anagram("a");
      //  Console.WriteLine("Test output: " + newAnagram.GetInput());
      // Assert.Equal("a", newAnagram.GetInput());
    }



  }



}
