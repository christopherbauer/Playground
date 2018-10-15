using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge158
{
    public class InputConverter
    {
        private readonly IOutputDevice _outputDevice;
        private readonly string _inputString;

        public InputConverter(IOutputDevice outputDevice, string inputString)
        {
            _outputDevice = outputDevice;
            _inputString = inputString;
        }

        public void Convert()
        {
            var mode = Mode.Grounded;
            var floatAmount = 0;
            foreach (var character in _inputString.ToCharArray())
            {
                if(Char.IsNumber(character))
                {
                    mode = Mode.Float;
                    floatAmount = (int)Char.GetNumericValue(character);
                    continue;
                }
                var characterArray = new List<char>();
                if (mode == Mode.Float)
                {
                    characterArray.AddRange(Enumerable.Repeat(' ', floatAmount));
                    mode = Mode.Grounded;
                    floatAmount = 0;
                }

                characterArray.AddRange(CharacterConverter.ToColumnValues(character));
                characterArray.AddRange(Enumerable.Repeat(' ', 9 - characterArray.Count));
                
                _outputDevice.Write(new string(characterArray.ToArray()));
            }
        }

        private enum Mode
        {
            Grounded, Float
        }
    }
}