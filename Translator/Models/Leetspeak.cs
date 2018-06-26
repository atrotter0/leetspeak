using System;
using System.Collections.Generic;

namespace Translator
{
    public class Leetspeak
    {
        private char[] _userInput;
        private List<char> _newPhrase;

        public char[] SetUserInput(string userPhrase)
        {
            char[] individualCharacters = userPhrase.ToCharArray();
            _userInput = individualCharacters;
            return individualCharacters;
        }

        public char[] GetUserInput()
        {
            return _userInput;
        }

        public void SetNewPhrase(List<char> phraseList)
        {
            _newPhrase = phraseList;
        }

        public bool IsLetterE(char letter)
        {
            if (letter == 'e')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsLetterI(char letter)
        {
            if (letter == 'I')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsLetterO(char letter)
        {
            if (letter == 'o')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsLetterT(char letter)
        {
            if (letter == 't')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsLetterS(char letter)
        {
            if (letter == 's')
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
