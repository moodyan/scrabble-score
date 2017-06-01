using Xunit;
using System;

namespace ScrabbleScore.Objects
{
  public class ScrabbleTest
  {
    [Fact]
    public void GetScrabbleScore_true()
    {
      string testing = "pants";
      Scrabble testWord = new Scrabble();
      Assert.Equal(true, testWord.GetScrabbleScore(testing));
    }
  }
}
