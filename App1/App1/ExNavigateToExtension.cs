using Prism.Navigation;
using Prism.Navigation.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    namespace MarkupExtensions
    {
        public class ExNavigateToExtension : NavigateToExtension
        {
            protected override async Task HandleNavigation(INavigationParameters parameters, INavigationService navigationService)
            {
                Console.WriteLine($"Navigating to: {Name}");
                if (parameters.TryGetValue(KnownNavigationParameters.XamlParam, out string text))
                {
                    this.Name = text;
                }
                await base.HandleNavigation(parameters, navigationService);
            }
        }
    }
}
