﻿using System;
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
            _letterDictionary['I'] = '1';
            _letterDictionary['o'] = '0';
            _letterDictionary['t'] = '7';
            _letterDictionary['s'] = 'z';
        }

        public List<char> ReplaceValues()
        {
            List<char> leatspeakPhrase = this.GetModifiedPhrase();
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
                    leatspeakPhrase.Add(character);
                }
                else if (this.GetLetterDictionary().ContainsKey(character))
                {
                    leatspeakPhrase.Add(this.GetDictionaryValue(character));
                }
                else
                {
                    leatspeakPhrase.Add(character);
                }
            }
            return leatspeakPhrase;
        }
    }
}
