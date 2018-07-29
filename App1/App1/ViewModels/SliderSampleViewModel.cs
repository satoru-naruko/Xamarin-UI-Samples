using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App1.ViewModels
{
	public class SliderSampleViewModel : ViewModelBase
	{
        public SliderSampleViewModel(INavigationService navigationService): base(navigationService)
        {
            Title = "SliderSample";
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.TryGetValue(KnownNavigationParameters.XamlParam, out string text))
            {
                Title = text;
            }
        }
    }
}
