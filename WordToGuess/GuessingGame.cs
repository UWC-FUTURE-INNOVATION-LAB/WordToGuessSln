using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordToGuess
{
    public class GuessingGame
    {
        private string _guessword;
        private string _guessProgress;

        public GuessingGame(string guessword)
        {
            _guessword = guessword;

            for (int index = 0; index < _guessword.Length; index++)
            {
                _guessProgress += "*";
            }
        }

        public string GetGuessProgress()
        {
            return _guessProgress;
        }

        
        public void AddGuess(char letter)
        {
            char[] guessProgressArray = _guessProgress.ToCharArray();

            for (int index=0;index < _guessword.Length; index++)
            {
                if(_guessword[index] == letter)
                {
                    guessProgressArray[index] = letter;
                }
            }

            _guessProgress = new string(guessProgressArray);

        }

    }
}
