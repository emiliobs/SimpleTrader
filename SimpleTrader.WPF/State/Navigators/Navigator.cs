using SimpleTrader.WPF.Commands;
using SimpleTrader.WPF.Models;
using SimpleTrader.WPF.ViewModels;
using System.Windows.Input;

namespace SimpleTrader.WPF.State.Navigators
{
    public class Navigator : ObservableObject, INavigator 

    {
        private ViewModelBase _CurrentViewModel;

        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);

        public ViewModelBase CurrentViewModel
        {
            get => _CurrentViewModel;
            set
            {
                _CurrentViewModel = value;
                OnPorpertyChange(nameof(CurrentViewModel));
            }
        }



    }

}
