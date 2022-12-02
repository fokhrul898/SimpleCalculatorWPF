using SimpleCalculator.Commands;
using SimpleCalculator.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace SimpleCalculator.ViewModels
{
    public class CalculatorModelView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        CalculatorService objCalculatorService;
        public CalculatorModelView()
        {
            objCalculatorService = new CalculatorService();
            objCalculatorService.TruncateCalculatorHistoryTable();
            LoadData();
            buttonOneClickCommand = new RelayCommand(OnClickedButtonOne);
            buttonTwoClickCommand = new RelayCommand(OnClickedButtonTwo);
            buttonThreeClickCommand = new RelayCommand(OnClickedButtonThree);
            buttonFourClickCommand = new RelayCommand(OnClickedButtonFour);
            buttonFiveClickCommand = new RelayCommand(OnClickedButtonFive);
            buttonSixClickCommand = new RelayCommand(OnClickedButtonSix);
            buttonSevenClickCommand = new RelayCommand(OnClickedButtonSeven);
            buttonEightClickCommand = new RelayCommand(OnClickedButtonEight);
            buttonNineClickCommand = new RelayCommand(OnClickedButtonNine);
            buttonZeroClickCommand = new RelayCommand(OnClickedButtonZero);
            buttonFullStopClickCommand = new RelayCommand(OnClickedButtonFullStop);
            addCommand = new RelayCommand(AddOperation);
            subCommand = new RelayCommand(SubOperation);
            mulCommand = new RelayCommand(MulOperation);
            divCommand = new RelayCommand(DivOperation);
            equalCommand = new RelayCommand(EqualOperation);
            clearCommand = new RelayCommand(Clear);
            cleanentryCommand = new RelayCommand(ClearEntry);
            backspaceCommand = new RelayCommand(BackSpace);
            recallCommand = new RelayCommand(Recall);
        }
        private ObservableCollection<Calculator> calculatorHistoryList;
        public ObservableCollection<Calculator> CalculatorHistoryList
        {
            get { return calculatorHistoryList; }
            set { calculatorHistoryList = value; OnPropertyChanged("CalculatorHistoryList"); }
        }
        private void LoadData()
        {
            CalculatorHistoryList = new ObservableCollection<Calculator>(objCalculatorService.GetAll());
        }
        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged("Message"); }
        }
        private RelayCommand buttonOneClickCommand;
        private RelayCommand buttonTwoClickCommand;
        private RelayCommand buttonThreeClickCommand;
        private RelayCommand buttonFourClickCommand;
        private RelayCommand buttonFiveClickCommand;
        private RelayCommand buttonSixClickCommand;
        private RelayCommand buttonSevenClickCommand;
        private RelayCommand buttonEightClickCommand;
        private RelayCommand buttonNineClickCommand;
        private RelayCommand buttonZeroClickCommand;
        private RelayCommand buttonFullStopClickCommand;
        private RelayCommand addCommand;
        private RelayCommand subCommand;
        private RelayCommand mulCommand;
        private RelayCommand divCommand;
        private RelayCommand equalCommand;
        private RelayCommand clearCommand;
        private RelayCommand cleanentryCommand;
        private RelayCommand backspaceCommand;
        private RelayCommand recallCommand;
        public RelayCommand ButtonOneClickCommand
        {
            get { return buttonOneClickCommand; }
        }
        public RelayCommand ButtonTwoClickCommand
        {
            get { return buttonTwoClickCommand; }
        }
        public RelayCommand ButtonThreeClickCommand
        {
            get { return buttonThreeClickCommand; }
        }
        public RelayCommand ButtonFourClickCommand
        {
            get { return buttonFourClickCommand; }
        }
        public RelayCommand ButtonFiveClickCommand
        {
            get { return buttonFiveClickCommand; }
        }
        public RelayCommand ButtonSixClickCommand
        {
            get { return buttonSixClickCommand; }
        }
        public RelayCommand ButtonSevenClickCommand
        {
            get { return buttonSevenClickCommand; }
        }
        public RelayCommand ButtonEightClickCommand
        {
            get { return buttonEightClickCommand; }
        }
        public RelayCommand ButtonNineClickCommand
        {
            get { return buttonNineClickCommand; }
        }
        public RelayCommand ButtonZeroClickCommand
        {
            get { return buttonZeroClickCommand; }
        }
        public RelayCommand ButtonFullStopClickCommand
        {
            get { return buttonFullStopClickCommand; }
        }
        public RelayCommand AddCommand
        {
            get { return addCommand; }
        }
        public RelayCommand SubCommand
        {
            get { return subCommand; }
        }
        public RelayCommand MulCommand
        {
            get { return mulCommand; }
        }
        public RelayCommand DivCommand
        {
            get { return divCommand; }
        }
        public RelayCommand EqualCommand
        {
            get { return equalCommand; }
        }
        public RelayCommand ClearCommand
        {
            get { return clearCommand; }
        }
        public RelayCommand ClearEntryCommand
        {
            get { return cleanentryCommand; }
        }

        public RelayCommand ReCallCommand
        {
            get { return recallCommand; }
        }
        public RelayCommand BackSpaceCommand
        {
            get { return backspaceCommand; }
        }
        string secondnumber = string.Empty;
        private string result;
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        bool isOperationExit = false;
        public string Result
        {
            get { return result; }
            set { result = value; OnPropertyChanged("Result"); }
        }
        private string currentValue;
        public string CurrentValue
        {
            get { return currentValue; }
            set { currentValue = value; OnPropertyChanged("CurrentValue"); }
        }
        public void OnClickedButtonZero()
        {
            try
            {
                if (Result == "0" || isOperationPerformed)
                {
                    Result = String.Empty;
                }
                Result += "0";
                isOperationPerformed = false;
                isOperationExit = false;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
        public void OnClickedButtonOne()
        {
            try
            {
                if (Result == "0" || isOperationPerformed)
                {
                    Result = String.Empty;
                }
                Result += "1";
                isOperationPerformed = false;
                isOperationExit = false;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
        public void OnClickedButtonTwo()
        {
            try
            {
                if (Result == String.Empty || isOperationPerformed)
                {
                    Result = String.Empty;
                }
                Result += "2";
                isOperationPerformed = false;
                isOperationExit = false;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
        public void OnClickedButtonThree()
        {
            try
            {
                if (Result == String.Empty || isOperationPerformed)
                {
                    Result = String.Empty;
                }
                Result += "3";
                isOperationPerformed = false;
                isOperationExit = false;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
        public void OnClickedButtonFour()
        {
            try
            {
                if (Result == String.Empty || isOperationPerformed)
                {
                    Result = String.Empty;
                }
                Result += "4";
                isOperationPerformed = false;
                isOperationExit = false;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
        public void OnClickedButtonFive()
        {
            try
            {
                if (Result == String.Empty || isOperationPerformed)
                {
                    Result = String.Empty;
                }
                Result += "5";
                isOperationPerformed = false;
                isOperationExit = false;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
        public void OnClickedButtonSix()
        {
            try
            {
                if (Result == String.Empty || isOperationPerformed)
                {
                    Result = String.Empty;
                }
                Result += "6";
                isOperationPerformed = false;
                isOperationExit = false;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
        public void OnClickedButtonSeven()
        {
            try
            {
                if (Result == String.Empty || isOperationPerformed)
                {
                    Result = String.Empty;
                }
                Result += "7";
                isOperationPerformed = false;
                isOperationExit = false;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
        public void OnClickedButtonEight()
        {
            try
            {
                if (Result == String.Empty || isOperationPerformed)
                {
                    Result = String.Empty;
                }
                Result += "8";
                isOperationPerformed = false;
                isOperationExit = false;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
        public void OnClickedButtonNine()
        {
            try
            {
                if (Result == String.Empty || isOperationPerformed)
                {
                    Result = String.Empty;
                }
                Result += "9";
                isOperationPerformed = false;
                isOperationExit = false;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
        public void OnClickedButtonFullStop()
        {
            try
            {
                if (Result == String.Empty || isOperationPerformed)
                {
                    Result = String.Empty;
                }
                if (!Result.Contains('.'))
                {
                    Result += '.';
                }
                isOperationPerformed = false;
                isOperationExit = false;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
        public void AddOperation()
        {
            try
            {

                if (resultValue != 0 && !isOperationExit)
                {
                    secondnumber = Result;
                    SwitchCase();
                    operationPerformed = "+";
                    CurrentValue = resultValue + " " + operationPerformed;
                    isOperationExit = true;
                    SaveData();
                    LoadData();
                }
                else
                {
                    operationPerformed = "+";
                    resultValue = Double.Parse(Result);
                    CurrentValue = resultValue + " " + operationPerformed;
                }
                isOperationPerformed = true;
            }
            catch
            {
            }
        }
        public void SubOperation()
        {
            try
            {

                if (resultValue != 0 && !isOperationExit)
                {
                    secondnumber = Result;
                    SwitchCase();
                    operationPerformed = "-";
                    CurrentValue = resultValue + " " + operationPerformed;
                    isOperationExit = true;
                    SaveData();
                    LoadData();
                }
                else
                {
                    operationPerformed = "-";
                    resultValue = Double.Parse(Result);
                    CurrentValue = resultValue + " " + operationPerformed;
                }
                isOperationPerformed = true;
            }
            catch
            {
            }
        }
        public void MulOperation()
        {
            try
            {

                if (resultValue != 0 && !isOperationExit)
                {
                    secondnumber = Result;
                    SwitchCase();
                    operationPerformed = "*";
                    CurrentValue = resultValue + " " + operationPerformed;
                    isOperationExit = true;
                    SaveData();
                    LoadData();
                }
                else
                {
                    operationPerformed = "*";
                    resultValue = Double.Parse(Result);
                    CurrentValue = resultValue + " " + operationPerformed;
                }
                isOperationPerformed = true;
            }
            catch
            {
            }
        }
        public void DivOperation()
        {
            try
            {

                if (resultValue != 0 && !isOperationExit)
                {
                    secondnumber = Result;
                    SwitchCase();
                    operationPerformed = "/";
                    CurrentValue = resultValue + " " + operationPerformed;
                    isOperationExit = true;
                    SaveData();
                    LoadData();

                }
                else
                {
                    operationPerformed = "/";
                    resultValue = Double.Parse(Result);
                    CurrentValue = resultValue + " " + operationPerformed;
                }
                isOperationPerformed = true;
            }
            catch
            {
            }
        }
        public void EqualOperation()
        {
            try
            {
                secondnumber = Result;
                SwitchCase();
                SaveData();
                LoadData();
                Clear();
            }
            catch
            {
            }
        }
        private void SaveData()
        {
            try
            {
                Calculator calculator = new Calculator();
                calculator.SummationOfNumberValue = CurrentValue + " " + secondnumber;
                calculator.Result = Convert.ToDecimal(Result);
                objCalculatorService.Add(calculator);
            }
            catch
            {
            }
        }
        private void Clear ()
        {
            Result = String.Empty;
            CurrentValue = String.Empty;
            resultValue = 0;
            secondnumber = String.Empty;
        }
        private void Recall()
        {
            Result = CalculatorHistoryList.First().Result.ToString(); ;
            CurrentValue = CalculatorHistoryList.First().SummationOfNumberValue.ToString(); ;
        }
        private void ClearEntry()
        {
            Result = String.Empty;
        }
        private void BackSpace()
        {
            try
            {
                if(Result != string.Empty )
                {
                    Result = Result.Remove(Result.Length - 1);
                }
            }
            catch
            {
            }
        }
        private void SwitchCase()
        {
            switch (operationPerformed)
            {
                
                case "+":
                    Result = Add(resultValue, Double.Parse(Result)).ToString();
                    break;
                case "-":
                    Result = Sub(resultValue, Double.Parse(Result)).ToString();
                    break;
                case "*":
                    Result = Mul(resultValue, Double.Parse(Result)).ToString();
                    break;
                case "/":
                    Result = Div(resultValue, Double.Parse(Result)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(Result);
        }
        private double Add(double nun1, double num2)
        {
            return nun1 + num2;
        }
        private double Sub(double nun1, double num2)
        {
            return nun1 - num2;
        }
        private double Mul(double nun1, double num2)
        {
            return nun1 * num2;
        }
        private double Div(double nun1, double num2)
        {
            return nun1 / num2;
        }

    }
}
