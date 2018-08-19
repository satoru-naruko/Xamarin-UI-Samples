using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Subjects;
using System.Reactive.Linq;
using Prism.Events;
using System.ComponentModel.DataAnnotations;
using static App1.ViewModels.ListViewSampleViewModel;

namespace App1.ViewModels
{
	public class ListViewSampleViewModel : ViewModelBase
	{
        public class Model : BindableBase
        {
            public ReactiveCollection<string> CountryNames { get; } = new ReactiveCollection<string>();

            private bool emp;
            public bool IsNoCountry
            {
                get { return emp; }
                set { SetProperty(ref emp, value); }
            }

            public void Add(string name)
            {
                CountryNames.Add(name);
                IsNoCountry = false;
            }

            public void Del(string name)
            {
                CountryNames.Remove(name);
                IsNoCountry = (CountryNames.Count == 0) ? true : false;
            }

            public Model()
            {
                CountryNames.Clear();
                IsNoCountry = false;
            }
        }

        public ListViewSampleViewModel(INavigationService navigationService) : base(navigationService)
        {
            _countrys = new Model();

            _countrys.Add("satoru");
            _countrys.Add("naruko");

            var prop = _countrys.ObserveProperty(m => m.IsNoCountry).ToReactiveProperty();

            Console.WriteLine("1 value is {0}", prop.Value);

            _countrys.Del("satoru");
            _countrys.Del("naruko");

            Console.WriteLine("2 value is {0}", prop.Value);

            _countrys.Add("satoru");
            _countrys.Add("naruko");

            AddCommand = new ReactiveCommand<string>();
            AddCommand.Subscribe( x => Countrys.Add(x));

        }
        private Model _countrys;

        public Model Countrys
        {
            get { return _countrys; }
        }

        public ReactiveProperty<bool> CanAdd = new ReactiveProperty<bool>();
        
        public ReactiveCommand<string> AddCommand { get; private set; }

    }
}
