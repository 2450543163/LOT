using Lot.App.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lot.App.Services
{
    public class TsApiService:BaseProvider
    {
        public async Task<List<Models.Task>> GetStatsTopSeries()
        {
            return await Get<List<Models.Task>>("http://love520.qicp.vip:36891/Task/yi3fn-hux1/0/%E6%89%80%E6%9C%89%E4%BB%BB%E5%8A%A1/none/b00001");
        }
        internal async Task<TaskView> GetItemDetailPage(string id)
        {

            string url = string.Format("http://love520.qicp.vip:36891/taskview/yi3fn-hux1/" + id);
            return await Get<TaskView>(url);
        }

        internal async Task<List<Alert>> GetAlarmPage()
        {

            string url = string.Format("http://love520.qicp.vip:36891/Alert/yi3fn-hux1/0/所有属性/none/b00001");
            return await Get<List<Alert>>(url);
        }

        internal async Task<AlertView> AlarmDetailPage(string id)
        {

            string url = string.Format("http://love520.qicp.vip:36891/alertview/9mqvghxzdn/" + id);
            return await Get<AlertView>(url);
        }
    }
}
