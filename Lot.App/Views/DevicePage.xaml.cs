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
    public partial class DevicePage : ContentPage
    {
        public DevicePage()
        {
            InitializeComponent();
            this.listview1.ItemsSource = GetLoad();
        }


        public List<Models.Device> GetLoad()
        {
            List<Models.Device> datas = new List<Models.Device>();
            datas.Add(new Models.Device() { Type = "电表2(000000...)", Code = "必行站点 电笔", Title = "更新时间: 2019/01/09 11:27", Status = "恢复" });
            datas.Add(new Models.Device() { Type = "电表2(000000...)", Code = "必行站点 电笔", Title = "更新时间: 2019/01/09 11:27", Status = "恢复" });
            datas.Add(new Models.Device() { Type = "电表2(000000...)", Code = "必行站点 电笔", Title = "更新时间: 2019/01/09 11:27", Status = "恢复" });
            datas.Add(new Models.Device() { Type = "电表2(000000...)", Code = "必行站点 电笔", Title = "更新时间: 2019/01/09 11:27", Status = "恢复" });
            datas.Add(new Models.Device() { Type = "电表2(000000...)", Code = "必行站点 电笔", Title = "更新时间: 2019/01/09 11:27", Status = "恢复" });
            return datas;
        }
    }
}