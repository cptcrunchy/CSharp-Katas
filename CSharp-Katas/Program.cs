using System;
using System.Text;

namespace CSharp_Katas
{
	public static class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine();
		}
				
	}
	
	public static class HumanTimeFormat
	{
		public static string FormatDuration(int seconds)
		{

			StringBuilder humanTime = new StringBuilder();
			TimeSpan time = TimeSpan.FromSeconds(seconds);

			if(time.TotalSeconds == 0)
			{
				humanTime.Append("now");
			}

			if(time.Days != 0)
			{
				if (time.TotalDays >= 365)
				{
					int years = (int)time.TotalDays / 365;
					humanTime.AppendFormat("{0} {1}", years, Pluralize("year", years));
					if (time.Days > 0 || time.Hours > 0 || time.Minutes > 0 || time.Seconds > 0)
					{
						humanTime.Append(", ");
					}

					humanTime.AppendFormat("{0} {1}", time.Days - (years * 365), Pluralize("day", time.Days));
					if (time.Hours > 0 || time.Minutes > 0 || time.Seconds > 0)
					{
						humanTime.Append(", ");
					}
				}
				else
				{
					humanTime.AppendFormat("{0} {1}", time.Days, Pluralize("day", time.Days));
					if (time.Hours > 0 || time.Minutes > 0 || time.Seconds > 0)
					{
						humanTime.Append(", ");
					}
				}
				
			}

			if(time.Hours != 0)
			{
				humanTime.AppendFormat("{0} {1}", time.Hours, Pluralize("hour", time.Hours));
				if (time.Minutes > 0 && time.Seconds == 0)
				{
					humanTime.Append(" and ");
				}
				
				if(time.Minutes > 0 && time.Seconds > 0)
				{
					humanTime.Append(", ");
				}
			}

			if(time.Minutes != 0)
			{
				humanTime.AppendFormat("{0} {1}", time.Minutes, Pluralize("minute", time.Minutes));
				if (time.Seconds > 0)
				{
					humanTime.Append(" and ");
				}
			}

			if(time.Seconds != 0)
			{

				humanTime.AppendFormat("{0} {1}", time.Seconds, Pluralize("second", time.Seconds));
			}


			return humanTime.ToString();
			
		}

		public static string Pluralize(this string value, int count) => (count == 1) ? value : value + "s";
		
	}
		
}

