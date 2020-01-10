using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Iot.App.Models
{
	public class TaskView
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

		public string Urgency
		{
			get;
			set;
		}

		public string Time
		{
			get;
			set;
		}

		public string Title
		{
			get;
			set;
		}

		public string Msg
		{
			get;
			set;
		}

		public string Pics
		{
			get;
			set;
		}

		public string Build
		{
			get;
			set;
		}

		public string Province
		{
			get;
			set;
		}

		public string City
		{
			get;
			set;
		}

		public string Address
		{
			get;
			set;
		}

		public string Worker
		{
			get;
			set;
		}

		public string Tel
		{
			get;
			set;
		}

		public string Avatar
		{
			get;
			set;
		}

		public string RateMessage
		{
			get;
			set;
		}

		public string Rate
		{
			get;
			set;
		}

		public string workpic
		{
			get;
			set;
		}

		public string solvedproblems
		{
			get;
			set;
		}

		public string tpcdomain
		{
			get;
			set;
		}

		public IList<TaskContact> Contacts
		{
			get;
			set;
		}

		public IList<TaskDevice> Devices
		{
			get;
			set;
		}
	}
}
