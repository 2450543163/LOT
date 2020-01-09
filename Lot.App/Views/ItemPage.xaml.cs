using Lot.App.Models;
using Lot.App.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lot.App.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemPage : ContentPage
    {
        public ObservableCollection<Models.Task> TopSeries { get; set; }
        public ItemPage()
        {
            InitializeComponent();
            BtnGetEvent();
        }

        private async void BtnGetEvent()
        {
            TsApiService t = new TsApiService();
            var result = await t.GetStatsTopSeries();
            if (result != null)
            {
                TopSeries = new ObservableCollection<Models.Task>(result);
            }
            //ImgType
            ItemsListView.ItemsSource = TopSeries; 
        }

        private async void ToDetailPage(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Models.Task;
            await Navigation.PushModalAsync(new ItemDetailPage(item.Id));
        }


        private void Image_Summary(object sender, EventArgs e)
        {

        }

        private async System.Threading.Tasks.Task Image_Task(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new ItemPage()));
        }

        private async void Image_Alert(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new ItemPage()));
        }

        private void Image_Device(object sender, EventArgs e)
        {

        }

        private void Image_Site(object sender, EventArgs e)
        {

        }
        //去除ListView得点击黄色框
        private void ItemsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ItemsListView.SelectedItem = null;
        }
    }
}