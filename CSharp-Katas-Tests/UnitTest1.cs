using CSharp_Katas;
using NUnit.Framework;

namespace Tests
{
	public class Tests
	{
		
		[Test]
		
		public void TimeIsNow()
		{
			Assert.AreEqual("now", HumanTimeFormat.FormatDuration(0));
		}

		[Test]
		public void TimeIsOneSecond()
		{
			Assert.AreEqual("1 second", HumanTimeFormat.FormatDuration(1));
		}

		[Test]
		public void TimeIsOneMinTwoSeconds()
		{
			Assert.AreEqual("1 minute and 2 seconds", HumanTimeFormat.FormatDuration(62));
		}

		[Test]
		public void TimeIsTwoMintues()
		{
			Assert.AreEqual("2 minutes", HumanTimeFormat.FormatDuration(120));
		}

		[Test]
		public void TimeIsOneHour()
		{
			Assert.AreEqual("1 hour", HumanTimeFormat.FormatDuration(3600));
		}

		[Test]
		public void TimeIsTwoHours()
		{
			Assert.AreEqual("2 hours", HumanTimeFormat.FormatDuration(7200));
		}

		[Test]
		public void TimeIsOneHourOneMinTwoSeconds()
		{
			Assert.AreEqual("1 hour, 1 minute and 2 seconds", HumanTimeFormat.FormatDuration(3662));
		}

		[Test]
		public void TimeIsOneYear()
		{
			Assert.AreEqual("1 year", HumanTimeFormat.FormatDuration(32227200));
		}

		[Test]
		public void TimeIsOneYearTenDaysSixHoursTwoMinOneSecond()
		{
			Assert.AreEqual("1 year, 10 days, 6 hours, 2 minutes and 1 second", HumanTimeFormat.FormatDuration(32421721));
		}

		[Test]
		public void TimeIsFourYearsSixEightDaysThreeHoursFourMin()
		{
			Assert.AreEqual("4 years, 68 days, 3 hours and 4 minutes", HumanTimeFormat.FormatDuration(132030240));
		}

	}
}