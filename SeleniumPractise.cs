using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public static class SeleniumPractise
{
    public static void Main()
    {
        IWebDriver driver =new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/web-form.html");
        var Title = driver.Title;

        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);

        var textBox = driver.FindElement(By.Name("my-text"));
        var textarea = driver.FindElement(By.Name("my-textarea"));
        var datepicker = driver.FindElement(By.Name("my-date"));
        var dropdown = driver.FindElement(By.Name("my-select"));


        var submitButton = driver.FindElement(By.TagName("button"));
        textBox.SendKeys("Selenium");
        textarea.SendKeys("hi this is sajid");
        datepicker.SendKeys("26-10-1993");
        dropdown.SendKeys("two");
        submitButton.Click();
   
       
        var message = driver.FindElement(By.Id("message"));
        var value = message.Text;
        driver.Quit();
    }
}
