using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace A6_Group6
{
    class VM : INotifyPropertyChanged
    {

        private double _ResultProperty;
        public double ResultProperty
        {
            get
            {
                return _ResultProperty;
            }
            set
            {
                if (_ResultProperty != value)
                {
                    _ResultProperty = value;
                    OnPropertyChanged();
                }
            }
        }

        private double _playerChoice;
        public double playerChoice
        {
            get
            {
                return _playerChoice;
            }
            set
            {
                if (_playerChoice != value)
                {
                    _playerChoice = value;
                    OnPropertyChanged();
                }
            }
        }



        //public int randNum;
        //public void Random()
        //{
        //    Random r = new Random();
        //    randNum = r.Next(1, 4);
        //}




        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string caller = null)
        {

            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(caller));
            }
        }

        internal void Random()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
