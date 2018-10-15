using System;

namespace Challenge158
{
    public class CharacterConverter
    {
        private static readonly char[] MapCharacters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

        private static readonly char[][] Map =
        {
            new[] {'+'}, 
            new[] {'+', '+'}, 
            new[]
            {
                '+', '+', '-'
            },
            new[]
            {
                '+', '+', '-', '-'
            },
            new[]
            {
                '+', '+', '-', '-','*'
            },
            new[]
            {
                '+', '+', '-', '-','*','*'
            },
            new[]
            {
                '+', '+', '-', '-','*','*','*'
            },
            new[]
            {
                '+', '+', '-', '-','*','*','*','.'
            },
            new[]
            {
                '+', '+', '-', '-','*','*','*','.','.'
            },
            new[]
            {
                '+', '+', '-', '-','*','*','*','.','.','.'
            }
        };

        public static char[] ToColumnValues(char character)
        {
            var index = Array.IndexOf(MapCharacters, character);
            return Map[index];
        }
    }
}