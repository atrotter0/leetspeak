using System;
using System.Collections.Generic;

namespace Translator
{
    public class Leetspeak
    {
        private char[] _userInput;
        private List<char> _newPhrase;
        private Dictionary<char, char> _letterDictionary;

        public void SetUserInput(string userPhrase)
        {
            char[] individualCharacters = userPhrase.ToCharArray();
            _userInput = individualCharacters;
        }

        public char[] GetUserInput()
        {
            return _userInput;
        }

        public void SetNewPhrase(List<char> phraseList)
        {
            _newPhrase = phraseList;
        }

        public List<char> GetNewPhrase()
        {
            return _newPhrase;
        }

        public char GetDictionaryValue(char key)
        {
            return _letterDictionary[key];
        }

        public void MakeDictionary()
        {
            _letterDictionary = new Dictionary<char, char>() {};
            _letterDictionary['e'] = '3';
            _letterDictionary['I'] = '1';
            _letterDictionary['o'] = '0';
            _letterDictionary['t'] = '7';
            _letterDictionary['s'] = 'z';
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
