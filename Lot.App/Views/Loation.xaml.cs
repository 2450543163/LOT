using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lot.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Loation : ContentPage
    {
        public Loation()
        {
            InitializeComponent();
            this.listview.ItemsSource = LoadData();
        }

        public class Data
        {
            public string Icon { get; set; }
            public string Text { get; set; }
            public string Arrow { get; set; }
        }
        protected IList<Data> LoadData()
        {
            var datas = new List<Data>();
            datas.Add(
               new Data { Icon = "processing.png", Text = "电表", Arrow = ">" });
            datas.Add(
               new Data { Icon = "processing.png", Text = "电表", Arrow = ">" });
            datas.Add(
              new Data { Icon = "processing.png", Text = "电表", Arrow = ">" });
            datas.Add(
              new Data { Icon = "processing.png", Text = "电表", Arrow = ">" });

            return datas;
        }
    }
}