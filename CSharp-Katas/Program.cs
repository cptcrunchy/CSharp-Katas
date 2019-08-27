using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;

namespace CSharp_Katas
{
	public class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine(HumanTimeFormat.formatDuration(1));
			
		}

		
	}
	
	public static class HumanTimeFormat
	{
		public static string formatDuration(int seconds)
		{
			int yearsCount = 0;
			int daysCount = 0;
			int hrsCount = 0;
			int minsCount = 0;
			int oneMinute = 60;
			var humanDateBuilder = new StringBuilder();

			if( seconds > 0)
			{
				if (seconds < oneMinute)
				{
					humanDateBuilder.Append(Humanize(seconds, "second"));
				}
				else
				{ 
					while (seconds >= oneMinute)
					{
						seconds -= oneMinute;
						if(minsCount == 59)
						{
							if (hrsCount == 23)
							{
								if(daysCount == 364)
								{
									yearsCount++;
									daysCount = 0;
								}
								else { daysCount++; }
								hrsCount = 0;
							}
							else { hrsCount++; }
							minsCount = 0;
						}
						else { minsCount++; }
					}

					string yearsText = Humanize(yearsCount, "year");
					string daysText = Humanize(daysCount, "day");
					string hoursText = Humanize(hrsCount, "hour");
					string minsText = Humanize(minsCount, "minute");
					string secsText = Humanize(seconds, "second");
					int[] values = { yearsCount, daysCount, hrsCount, minsCount };


									   
					if (!string.IsNullOrEmpty(yearsText) && seconds == 0)
					{
						humanDateBuilder.Append(yearsText + ", ");
					}
					else
					{
						humanDateBuilder.Append(yearsText);
					}

					if(!string.IsNullOrEmpty(daysText) && seconds == 0)
					{
						humanDateBuilder.Append(daysText + ", ");
					}
					else
					{
						humanDateBuilder.Append(daysText);
					}

					if (!string.IsNullOrEmpty(hoursText) && seconds == 0)
					{
						humanDateBuilder.Append(hoursText + ", ");
					}
					else
					{
						humanDateBuilder.Append(hoursText);
					}

					if (!string.IsNullOrEmpty(minsText) && values.Sum() > 0)
					{
						humanDateBuilder.Append(minsText + ", ");
					}
					else
					{
						humanDateBuilder.Append(minsText);
					}

					if (!string.IsNullOrEmpty(secsText) && values.Sum() > 0)
					{
						humanDateBuilder.Append(" and " + secsText);
					}
					else
					{
						humanDateBuilder.Append(secsText);
					}
				}
			}
			else
			{
				humanDateBuilder.Append("now");
			}
			return humanDateBuilder.ToString();
		}

		

		public static string Humanize(int timeCount, string timeType)
		{
			var humanTime = new StringBuilder();
			if(timeCount > 1 )
			{
				humanTime.Append(timeCount + " " + timeType + "s");
			}
			else if (timeCount == 1)
			{
				humanTime.Append(timeCount + " " + timeType);
			}
			else
			{
				humanTime.Append("");
			}

			return humanTime.ToString();
		}
	}
		
}
