using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ScrabbleNamespace
{
  public class Scrabble
  {
    private string _word;
    private int _score;
    private static List<Scrabble> _instances = new List<Scrabble>(){};

    private Dictionary<char, int> _letterPoints = new Dictionary<char, int>()
    {
      { 'A', 1 },
      { 'E', 1 },
      { 'I', 1 },
      { 'O', 1 },
      { 'U', 1 },
      { 'L', 1 },
      { 'N', 1 },
      { 'R', 1 },
      { 'S', 1 },
      { 'T', 1 },
      { 'D', 2 },
      { 'G', 2 },
      { 'B', 3 },
      { 'C', 3 },
      { 'M', 3 },
      { 'P', 3 },
      { 'F', 4 },
      { 'H', 4 },
      { 'V', 4 },
      { 'W', 4 },
      { 'Y', 4 },
      { 'K', 5 },
      { 'J', 8 },
      { 'X', 8 },
      { 'Q', 10},
      { 'Z', 10},
      { ' ', 0}
    };

    public Scrabble(string input)
    {
      _word = input.ToUpper();
      _word = this.RemoveSpaces(); //lets add some more functionality to this object to pass into model.
      _score = this.ScrabbleScore();
      _instances.Add(this);
    }

    public int GetScore()
    {
      return _score;
    }

    public string GetWord()
    {
      return _word;
    }

    public static List<Scrabble> GetAll()
    {
      return _instances;
    }

    public string RemoveSpaces()
    {
      string pattern = @" ";
      return Regex.Replace(_word, pattern, "");
    }


    public int ScrabbleScore()
    {
      int score = 0;
      char[] testWord = _word.ToCharArray();
      foreach (char letter in testWord)
      {
        score += _letterPoints[letter];
      }
    return score;
    }
  }
}
