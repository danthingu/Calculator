using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Calculator
{
    /// <summary>
    /// View model
    /// </summary>
    class AirthmeticViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Stores the last operation performed
        /// </summary>
        enum LastOperation
        { None, Add, Subtract, Multiply, Divide };

        AirthmeticModel Model;
        Double tempNumber;
        LastOperation lastOperation;
        bool bNewEntry;

        private RelayCommand _pressButton0;
        public ICommand PressButton0Command { get { return _pressButton0; } }
        private RelayCommand _pressButton1;
        public ICommand PressButton1Command { get { return _pressButton1; } }
        private RelayCommand _pressButton2;
        public ICommand PressButton2Command { get { return _pressButton2; } }
        private RelayCommand _pressButton3;
        public ICommand PressButton3Command { get { return _pressButton3; } }
        private RelayCommand _pressButton4;
        public ICommand PressButton4Command { get { return _pressButton4; } }
        private RelayCommand _pressButton5;
        public ICommand PressButton5Command { get { return _pressButton5; } }
        private RelayCommand _pressButton6;
        public ICommand PressButton6Command { get { return _pressButton6; } }
        private RelayCommand _pressButton7;
        public ICommand PressButton7Command { get { return _pressButton7; } }
        private RelayCommand _pressButton8;
        public ICommand PressButton8Command { get { return _pressButton8; } }
        private RelayCommand _pressButton9;
        public ICommand PressButton9Command { get { return _pressButton9; } }
        private RelayCommand _multiply;
        public ICommand MultiplyCommand { get { return _multiply; } }
        private RelayCommand _divide;
        public ICommand DivideCommand { get { return _divide; } }
        private RelayCommand _add;
        public ICommand AddCommand { get { return _add; } }
        private RelayCommand _subtract;
        public ICommand SubtractCommand { get { return _subtract; } }
        public AirthmeticViewModel()
        {         
            Model = new AirthmeticModel();
            tempNumber = 0;
            lastOperation = LastOperation.None;
            bNewEntry = false;
            InitializeCommand();
        }
        void InitializeCommand()
        {
            _pressButton0 = new RelayCommand(OnPressButton0Command, CanPressButton0);
            _pressButton1 = new RelayCommand(OnPressButton1Command, CanPressButton1);
            _pressButton2 = new RelayCommand(OnPressButton2Command, CanPressButton2);
            _pressButton3 = new RelayCommand(OnPressButton3Command, CanPressButton3);
            _pressButton4 = new RelayCommand(OnPressButton4Command, CanPressButton4);
            _pressButton5 = new RelayCommand(OnPressButton5Command, CanPressButton5);
            _pressButton6 = new RelayCommand(OnPressButton6Command, CanPressButton6);
            _pressButton7 = new RelayCommand(OnPressButton7Command, CanPressButton7);
            _pressButton8 = new RelayCommand(OnPressButton8Command, CanPressButton8);
            _pressButton9 = new RelayCommand(OnPressButton9Command, CanPressButton9);
            _add = new RelayCommand(OnAddCommand, CanAddCommand);
            _subtract = new RelayCommand(OnSubtractCommand, CanSubtractCommand);
            _multiply = new RelayCommand(OnMultiplyCommand, CanMultiplyCommand);
            _divide = new RelayCommand(OnDivideCommand, CanDivideCommand);
        }
        //0
        private bool CanPressButton0()
        {
            return true;
        }
        private void OnPressButton0Command()
        {
            updateNumber = 0;
        }
        //1
        private bool CanPressButton1()
        {
            return true;
        }
        private void OnPressButton1Command()
        {
            updateNumber = 1;
        }
        //2
        private bool CanPressButton2()
        {
            return true;
        }
        private void OnPressButton2Command()
        {
            updateNumber = 2;
        }
        //3
        private bool CanPressButton3()
        {
            return true;
        }
        private void OnPressButton3Command()
        {
            updateNumber = 3;
        }
        //4
        private bool CanPressButton4()
        {
            return true;
        }       
        private void OnPressButton4Command()
        {
            updateNumber = 4;
        }
        //5
        private bool CanPressButton5()
        {
            return true;
        }
        private void OnPressButton5Command()
        {
            updateNumber = 5;
        }
        //6
        private bool CanPressButton6()
        {
            return true;
        }
        private void OnPressButton6Command()
        {
            updateNumber = 6;
        }
        //7
        private bool CanPressButton7()
        {
            return true;
        }
        private void OnPressButton7Command()
        {
            updateNumber = 7;
        }
        //8
        private bool CanPressButton8()
        {
            return true;
        }
        private void OnPressButton8Command()
        {
            updateNumber = 8;
        }
        //9
        private bool CanPressButton9()
        {
            return true;
        }
        private void OnPressButton9Command()
        {
            updateNumber = 9;
        }
         

        public double updateNumber
        {
            get
            {
                return Model.Number;
            }
            set
            {
                if (Model.Number == 0)
                    Model.Number = value;
                else if (bNewEntry)
                {
                    Model.Number = value;
                    bNewEntry = false;
                }
                else
                    Model.Number = double.Parse(Model.Number.ToString() + value.ToString());

                RaisePropertyChanged("updateNumber");
            }
        }

        public bool CanAddCommand()
        {
            return true;
        }
        public void OnAddCommand()
        {
            if (lastOperation == LastOperation.Add)
            {
                double sum = updateNumber + tempNumber;
                clear();
                updateNumber = sum;           
            }
            tempNumber = updateNumber;
            bNewEntry = true;         
          
           lastOperation = LastOperation.Add;
        }
        public bool CanSubtractCommand()
        {
            return true;
        }
        public void OnSubtractCommand()
        {           
            
            if (lastOperation == LastOperation.Subtract)
            {
                double sum = tempNumber - updateNumber;
                clear();
                updateNumber = sum;              
            }
            tempNumber = updateNumber;
            bNewEntry = true;       
            lastOperation = LastOperation.Subtract;
        }
        public bool CanMultiplyCommand()
        {
            return true;
        }
        public void OnMultiplyCommand()
        {
            if (lastOperation == LastOperation.Multiply)
            {
                double sum = tempNumber * updateNumber;
                clear();
                updateNumber = sum;
            }
            tempNumber = updateNumber;
            bNewEntry = true;
            lastOperation = LastOperation.Multiply;
        }
        public bool CanDivideCommand()
        {
            return true;
        }
        public void OnDivideCommand()
        {
            if (lastOperation == LastOperation.Divide)
            {
                double sum = tempNumber/ updateNumber;
                clear();
                updateNumber = sum;
            }
            tempNumber = updateNumber;
            bNewEntry = true;
            lastOperation = LastOperation.Divide;
        }

        public void clear()
        {
            Model.Number =0;
            updateNumber =0;
        }

        public void clearAll()
        {
            Model.Number = 0;
            updateNumber = 0;
            tempNumber = 0;
            bNewEntry = false;
            lastOperation = LastOperation.None;
        }

        public void equal()
        {
            if (lastOperation == LastOperation.Add)
                OnAddCommand();
            else if (lastOperation == LastOperation.Multiply)
                OnMultiplyCommand();
            else if (lastOperation == LastOperation.Divide)
                OnDivideCommand();
            else if (lastOperation == LastOperation.Subtract)
                OnSubtractCommand();
            lastOperation = LastOperation.None;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            // take a copy to prevent thread issues
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
