using App1.Model;
using System;
using System.Linq;
using Xamarin.Forms;

namespace App1.Views
{
    public partial class ListViewSample : ContentPage
    {
        public ListViewSample()
        {
            InitializeComponent();
            var r = new Random();
            this.listViewTemplate.ItemsSource = Enumerable.Range(1, 100).Select(x => new Person { Age = 30 + r.Next(50), Name = $"naruko {x}" });
                
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}
