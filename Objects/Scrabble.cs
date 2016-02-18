using System;
using System.Linq;
using System.Collections.Generic;

namespace ScrabbleNamespace
{
  public class Scrabble
  {
    private string _word;
    private Dictionary<char, int> _letterPoints = new Dictionary<char, int>{};

    public Scrabble(string input)
    {
      _word = input;
    }

    public int ScrabbleScore()
    {
      int score = 0;

      _letterPoints.Add('k',5);
      Console.WriteLine(_letterPoints['k']);
      foreach (char letter in _word)
      {
        score += _letterPoints[letter];
      }

      // Console.WriteLine(_word[0]);
      // Console.WriteLine(_word[1]);
      return score;
    }

  }
}
