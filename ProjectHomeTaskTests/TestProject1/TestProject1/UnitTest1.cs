using NUnit.Framework;
using OpenQA.Selenium;

namespace TestProject1
{
	private IWebDriver driver;
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
			driver = new OpenQA.Selenium.Chrome.ChromeDriver();
			driver.Navigate().GoToUrl("https://www.google.com/");
		}

		[Test]
		public void Test1()
		{
			Assert.Pass();
		}

		[TearDown]
		public void TearDown()
		{

		}
	}
}