using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SimpleInteractiveInterpreter
{
    public class Lexer
    {
        #region Constants
        private const string BRACKETS = "()[]{}";
        #endregion
        #region Properties
        #endregion
        #region Methods
        public List<string> Parse(string line)
        {
            line = PrepareBrackets(line);

            var result = new List<string>();
            line = line.Trim();
            var enumerator = line.GetEnumerator();
            var value = string.Empty;
            var isIdentifier = false;
            var isPrevIdentifier = false;
            while (enumerator.MoveNext())
            {
                var ch = enumerator.Current.ToString();
                if (string.IsNullOrWhiteSpace(ch))
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        result.Add(value);
                        value = string.Empty;
                        isPrevIdentifier = false;
                    }
                    continue;
                }
                isIdentifier = IsIdentifier(ch);
                if (!isIdentifier)
                {
                    if (!string.IsNullOrWhiteSpace(value) && isPrevIdentifier)
                    {
                        result.Add(value);
                        value = ch;
                    }
                    if (!isIdentifier && !isPrevIdentifier)
                    {
                        value += ch;
                    }
                    isPrevIdentifier = isIdentifier;
                    continue;
                }
                if (!isPrevIdentifier && !string.IsNullOrWhiteSpace(value))
                {
                    result.Add(value);
                    value = string.Empty;
                }
                value += ch;
                isPrevIdentifier = true;
            }
            if (!string.IsNullOrWhiteSpace(value))
            {
                result.Add(value);
            }
            return result;
        }
        private static bool IsIdentifier(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z0-9_]+$");
        }
        #endregion
        #region Private Methods
        private string PrepareBrackets(string input)
        {
            var enumerator = BRACKETS.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var bracket = enumerator.Current.ToString();
                input = input.Replace(bracket, $" {bracket} ");
            }
            return input;
        }
        #endregion
    }
}
