using Prism.Navigation;

namespace App1.ViewModels
{
    public class NextPageViewModel : ViewModelBase
	{
        private string _text;
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        public NextPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.TryGetValue(KnownNavigationParameters.XamlParam, out string text))
            {
                Text = text;
            }
        }
    }
}
