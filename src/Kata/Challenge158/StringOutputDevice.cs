using System;

namespace Challenge158
{
    public class StringOutputDevice : IOutputDevice
    {
        private String _output;

        public string Output
        {
            get { return _output; }
            set { _output = value; }
        }

        public void Write(string message)
        {
            Output = message;
        }
    }
}