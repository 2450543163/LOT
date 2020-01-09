using Newtonsoft.Json;
using System.Collections.Generic;

namespace Lot.App.Models
{
	public class AlertView
	{
		public string Id
		{
			get;
			set;
		}

		public string Obj
		{
			get;
			set;
		}

		public string Type
		{
			get;
			set;
		}

		public string Property
		{
			get;
			set;
		}

		public string Status
		{
			get;
			set;
		}

		public int Count
		{
			get;
			set;
		}

		public string Title
		{
			get;
			set;
		}

		public string Org
		{
			get;
			set;
		}

		public string Build
		{
			get;
			set;
		}

		public string City
		{
			get;
			set;
		}

		public string Addr
		{
			get;
			set;
		}

		public string BuildingId
		{
			get;
			set;
		}

		public string Time
		{
			get;
			set;
		}

		[JsonIgnore]
		public string GId
		{
			get;
			set;
		}

		[JsonIgnore]
		public string DId
		{
			get;
			set;
		}

		[JsonIgnore]
		public string TId
		{
			get;
			set;
		}

		public Device Device
		{
			get;
			set;
		}

		public Gateway Gateway
		{
			get;
			set;
		}

		public Task Task
		{
			get;
			set;
		}

		public IList<Alert> Alerts
		{
			get;
			set;
		}
	}
}
