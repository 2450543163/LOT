using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Iot.App.Models
{
    public class Task
    {
        public string Id
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }

        public string Status
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string Detail
        {
            get;
            set;
        }

        public string Time
        {
            get;
            set;
        }

        public string Contact
        {
            get;
            set;
        }

        public IList<Tasknums> nums
        {
            get;
            set;
        }
    }
}
