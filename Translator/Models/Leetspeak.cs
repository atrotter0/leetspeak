using System;
using System.Collections.Generic;

namespace Translator
{
    public class Leetspeak
    {
        private char[] _userInput;
        private List<char> _newPhrase = new List<char>() { };
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

        public Dictionary<char, char> GetLetterDictionary()
        {   
            this.MakeDictionary();
            return _letterDictionary;
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

        public List<char> ReplaceValues()
        {
            List<char> finalPhrase = this.GetNewPhrase();
            int length = this.GetUserInput().Length;
            for (int i = 0; i < length; i++)
            {
                char character = this.GetUserInput()[i];
                char prevCharacter = '0';
                if (i > 0)
                {
                    prevCharacter = this.GetUserInput()[i - 1];  
                }

                if ((character == 's' && i == 0) || (character == 's' && prevCharacter == ' '))
                {
                    finalPhrase.Add(character);
                }
                else if (this.GetLetterDictionary().ContainsKey(character))
                {
                    finalPhrase.Add(this.GetDictionaryValue(character));
                }
                else
                {
                    finalPhrase.Add(character);
                }
            }
            return finalPhrase;
        }
    }
}
