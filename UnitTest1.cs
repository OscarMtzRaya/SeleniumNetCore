using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumNetCore
{
    public class Tests
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://demo.aspnetawesome.com/");
            var element = driver.FindElement(By.Id("Meal"));
            element.SendKeys("Tomato");
            var selection = driver.FindElement(By.XPath("//input[@name='ChildMeal1']/following-sibling::div[text()='Celery']"));
            selection.Click();
            Assert.True(true);
        }
    }
}