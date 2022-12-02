using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Models
{
    public class Calculator : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged("Id"); }
        }
        private string summationOfNumberValue;

        public string SummationOfNumberValue
        {
            get { return summationOfNumberValue; }
            set { summationOfNumberValue = value; OnPropertyChanged("SummationOfNumberValue"); }
        }
        private decimal result;

        public decimal Result
        {
            get { return result; }
            set { result = value; OnPropertyChanged("Result"); }
        }
    }
}
