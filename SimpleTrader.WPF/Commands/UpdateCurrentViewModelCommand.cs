using SimpleTrader.WPF.State.Navigators;
using SimpleTrader.WPF.ViewModels;
using System;
using System.Windows.Input;

namespace SimpleTrader.WPF.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        private readonly INavigator _navigator;

        public event EventHandler CanExecuteChanged;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is ViewType)
            {
                var viewType = (ViewType)parameter;
                switch (viewType)
                {
                    case ViewType.Home:
                        _navigator.CurrentViewModel = new HomeViewModel();
                        break;
                    case ViewType.Portfolio:
                        _navigator.CurrentViewModel = new PortafolioViewModel();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
