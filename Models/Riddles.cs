namespace Sphynx.Riddles
{
  public class Riddle
  {
    private string _newRiddle;
    private string _riddleAnswer;

    public Riddle(string newRiddle, string riddleAnswer)
    {
      _newRiddle = newRiddle;
      _riddleAnswer = riddleAnswer;
    }

    public string GetRiddleQuestion() 
    {
      return _newRiddle;
    }
    public bool CheckAnswer(string userAnswer)
    {
      return (userAnswer == _riddleAnswer);
    }
  }
}