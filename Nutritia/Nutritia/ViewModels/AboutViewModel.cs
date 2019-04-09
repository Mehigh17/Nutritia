using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace Nutritia.ViewModels
{
    public class AboutViewModel : PageViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}