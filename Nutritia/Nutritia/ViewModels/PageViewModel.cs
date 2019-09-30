namespace Nutritia.ViewModels
{
    public class PageViewModel : BaseViewModel
    {

        private string _title = string.Empty;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

    }
}
