namespace WPFPlayground.ViewModel
{
    public class CkViewModel : ViewModelBase
    {
        private bool _isButtonCounterEnabled;
        private string _someText;
        private int _resetCounter;

        public bool IsButtonCounterEnabled
        {
            get { return _isButtonCounterEnabled; }
            set { SetValue(ref _isButtonCounterEnabled, value); }
        }

        public int ResetCounter
        {
            get { return _resetCounter; }
            set { SetValue(ref _resetCounter, value); }
        }

        public string SomeText
        {
            get { return _someText; }
            set
            {
                SetValue(ref _someText, value);
                IsButtonCounterEnabled = true;
            }
        }
    }
}