using System;
using System.Collections.Generic;

namespace Translator
{
    public class Leetspeak
    {
        private char[] _charactersFromInput = new char[] {};
        private List<char> _modifiedPhrase = new List<char>() {};
        private Dictionary<char, char> _letterDictionary = new Dictionary<char, char>() {};

        public void SetUserInput(string userPhrase)
        {
            _charactersFromInput = userPhrase.ToCharArray();
        }

        public char[] GetUserInput()
        {
            return _charactersFromInput;
        }

        public void SetModifiedPhrase(List<char> phrase)
        {
            _modifiedPhrase = phrase;
        }

        public List<char> GetModifiedPhrase()
        {
            return _modifiedPhrase;
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
            _letterDictionary['E'] = '3';
            _letterDictionary['I'] = '1';
            _letterDictionary['o'] = '0';
            _letterDictionary['O'] = '0';
            _letterDictionary['t'] = '7';
            _letterDictionary['T'] = '7';
            _letterDictionary['s'] = 'z';
            _letterDictionary['S'] = 'z';
        }

        public List<char> ReplaceValues()
        {
            List<char> leetspeakPhrase = new List<char>() {};
            int charsArrayLength = this.GetUserInput().Length;
            for (int i = 0; i < charsArrayLength; i++)
            {
                this.CheckAndModify(leetspeakPhrase, i);
            }
            return leetspeakPhrase;
        }

        public void CheckAndModify(List<char> leetspeakPhrase, int index)
        {   
            char character = this.GetUserInput()[index];
            char prevCharacter = '0';

            if (index > 0) prevCharacter = this.GetUserInput()[index - 1];

            if (this.LetterSAtStart(character, prevCharacter, index) || !this.FoundKeyInDictionary(character))
            {
                leetspeakPhrase.Add(character);
            }
            else
            {
                leetspeakPhrase.Add(this.GetDictionaryValue(character));
            }
        }

        public bool LetterSAtStart(char character, char prevCharacter, int index)
        {
            return (character == 's' && index == 0) || (character == 's' && prevCharacter == ' ');
        }

        public bool FoundKeyInDictionary(char character)
        {
            return this.GetLetterDictionary().ContainsKey(character);
        }
    }
}
