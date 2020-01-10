
using System;

namespace iot.model
{
	public class Building
	{
		public string Id
		{
			get;
			set;
		}

		public string OrganizationId
		{
			get;
			set;
		}

		public string Code
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

		public string BuildingType
		{
			get;
			set;
		}

		public int? ProvinceId
		{
			get;
			set;
		}

		public int? CityId
		{
			get;
			set;
		}

		public int? DistrictId
		{
			get;
			set;
		}

		public string Address
		{
			get;
			set;
		}

		public decimal? Latitude
		{
			get;
			set;
		}

		public decimal? Longitude
		{
			get;
			set;
		}

		public string Description
		{
			get;
			set;
		}

		public bool? IsEnabled
		{
			get;
			set;
		}

		public string CreatedById
		{
			get;
			set;
		}

		public DateTime? CreatedAt
		{
			get;
			set;
		}

		public string ModifiedById
		{
			get;
			set;
		}

		public DateTime? ModifiedAt
		{
			get;
			set;
		}

		public bool? IsDeleted
		{
			get;
			set;
		}

		public string DeletedById
		{
			get;
			set;
		}

		public DateTime? DeletedAt
		{
			get;
			set;
		}
	}
}
