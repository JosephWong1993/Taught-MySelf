using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chapter01_04
{
	public struct Address
	{
		private readonly string province;
		private readonly string city;
		private readonly string zip;
		private readonly string[] phones;

		public Address(string province, string city, string zip, string[] phones)
		{
			this.city = city;
			this.province = province;
			this.zip = zip;
			this.phones = new string[phones.Length];
			phones.CopyTo(this.phones, 0);
			CheckZip(zip);  //	验证格式
		}

		public string Province
		{
			get { return province; }
		}

		public string City
		{
			get { return city; }
		}

		public string Zip
		{
			get { return zip; }
		}

		public string[] Phones
		{
			get
			{
				string[] rtn = new string[phones.Length];
				phones.CopyTo(rtn, 0);
				return rtn;
			}
		}

		//	检测是不是正确的zip
		private void CheckZip(string value)
		{
			string pattern = @"\d{6}";
			if (!Regex.IsMatch(value, pattern))
				throw new Exception("Zip is invalid!");
		}

		public override string ToString()
		{
			return String.Format("Province: {0}, City: {1}, Zip: {2}", province, city, zip);
		}
	}
}
