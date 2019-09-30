using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace Nutritia.ViewModels
{
    public class AboutViewModel : PageViewModel
    {

        private ICommand _showSourceCommand;
        public ICommand ShowSourceCommand
        {
            get => _showSourceCommand;
            set => SetProperty(ref _showSourceCommand, value);
        }

        public AboutViewModel()
        {
            Title = "About";

            ShowSourceCommand = new Command(() => Device.OpenUri(new Uri("https://github.com/Mehigh17/Nutritia")));
        }
    }
}