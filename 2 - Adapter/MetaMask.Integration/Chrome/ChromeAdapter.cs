using MetaMask.Domain.Adapter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MetaMask.Integration.Chrome
{
    public class ChromeAdapter : IChromeAdapter
    {
        IWebDriver driver;
        public void ReturnChrome()
        {
            var chromeOptions = new ChromeOptions(); 
            chromeOptions.BrowserVersion = "96.0.4664.45";
            chromeOptions.AddArgument("headless"); //Inicia sem interface gráfica aparente

            driver = new ChromeDriver("C:\\\\@projetos\\.NET\\Framework\\MetaMask\\6 - Terceiros\\", chromeOptions);
            driver.Url = "http://demo.guru99.com/test/guru99home/";
            driver.Manage().Window.Maximize();
            IWebElement link = driver.FindElement(By.XPath(".//*[@id='rt-header']//div[2]/div/ul/li[2]/a"));
            link.Click();
            driver.Close();
        }
    }
}