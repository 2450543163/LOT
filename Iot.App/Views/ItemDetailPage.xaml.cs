using Iot.App.Models;
using Iot.App.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Iot.App.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        //public ObservableCollection<TaskView> TopSeries { get; set; }
        public ItemDetailPage(string id)
        {
            InitializeComponent();
            BtnGetEvent(id);
        }
        public async void BtnGetEvent(string id)
        {
            TsApiService t = new TsApiService();
            TaskView result = await t.GetItemDetailPage(id);
            //TopSeries = new ObservableCollection<TaskView>(result);
            LabTitle.Text = result.Title;
            LabTime.Text= result.Time;
            Labbuild.Text = result.Build;
            Labaddress.Text = result.Address;
            ItemsListView.HeightRequest = 36*2 * result.Contacts.Count;
            ItemsListView.ItemsSource = result.Contacts;
           
        }

        private async void topage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ItemPage());
        }

        private async void LabBacked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}