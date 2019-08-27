using CSharp_Katas;
using NUnit.Framework;

namespace Tests
{
	public class Tests
	{
		
		[Test]
		
		public void TimeIsNow()
		{
			Assert.AreEqual("now", HumanTimeFormat.formatDuration(0));
		}

		[Test]
		public void TimeIsOneSecon()
		{
			Assert.AreEqual("1 second", HumanTimeFormat.formatDuration(1));
		}

		[Test]
		public void TimeIsOneMinTwoSeconds()
		{
			Assert.AreEqual("1 minute and 2 seconds", HumanTimeFormat.formatDuration(62));
		}

		[Test]
		public void TimeIsTwoMintues()
		{
			Assert.AreEqual("2 minutes", HumanTimeFormat.formatDuration(120));
		}
	}
}