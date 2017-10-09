using System;
using System.ComponentModel;

namespace XamarinDemoUITest
{
    class ViewModel : INotifyPropertyChanged
    {
        private int _ValueA;
        public String ValueA
        {
            get
            {
                return _ValueA.ToString();
            }
            set
            {
                if (_ValueA != Int32.Parse(value))
                {
                    _ValueA = Int32.Parse(value);
                    OnPropertyChanged(nameof(ValueA));
                }
            }
        }

        private int _ValueB;
        public String ValueB
        {
            get
            {
                return _ValueB.ToString();
            }
            set
            {
                if (_ValueB != Int32.Parse(value))
                {
                    _ValueB = Int32.Parse(value);
                    OnPropertyChanged(nameof(ValueB));
                }
            }
        }

        private int _Result;
        public String Result
        {
            get
            {
                return _Result.ToString();
            }
            set
            {
                if (_Result != Int32.Parse(value))
                {
                    _Result = Int32.Parse(value);
                    OnPropertyChanged(nameof(Result));
                }
            }
        }

        public void Add()
        {
            Result = (Int32.Parse(ValueA) + Int32.Parse(ValueB)).ToString();
        }

        public void Multiply()
        {
            Result = (Int32.Parse(ValueA) * Int32.Parse(ValueB)).ToString();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
