using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class Culture
	{
		public string Name { get; set; }
		public CultureInfo Value { get; set; }	
		public Culture(string name, CultureInfo value)
		{
			Name = name;
			Value = value;
		}

		public override string ToString()
		{
			// name and vaules name
			return $"{Name} | {Value.Name}";
		}
	}
}
