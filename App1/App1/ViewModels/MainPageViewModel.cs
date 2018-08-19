using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        /// <summary>
        /// The pagetitles field
        /// </summary>
        private IEnumerable<String> _pagetitles = new List<string>
    {
        "MainPage",
        "NextPage",
        "SliderSample",
        "ListViewSample"
    };

        /// <summary>
        /// Gets or sets the Property
        /// </summary>
        public IEnumerable<String> PageTitles
        {
            get
            {
                return this._pagetitles;
            }

            set
            {
                this.SetProperty(ref this._pagetitles, value);
            }
        }

        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Main Page";
        }

        /// <summary>
        /// The selectedtitle field
        /// </summary>
        private string _selectedTitle;

        /// <summary>
        /// Gets or sets the slectedtitle
        /// </summary>
        public string SlectedTitle
        {
            get
            {
                return this._selectedTitle;
            }

            set
            {
                this.SetProperty(ref this._selectedTitle, value);
            }
        }
    }
}
