using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;


namespace WebApplication4.Tests
{
    public class Tests
    {


        [Fact]
        public void ReservationFormTest()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://localhost:7214/Users/Reservation/Create");
            var startBox = driver.FindElement(By.Name("reservationStart"));
            var stopBox = driver.FindElement(By.Name("reservationEnd"));
            var vehicle = driver.FindElement(By.Name("VehicleId"));
            var resButton = driver.FindElement(By.Name("resBtn"));

            startBox.SendKeys("05070020230800");
            stopBox.SendKeys("05070020231500");
            vehicle.SendKeys("Giant");
            resButton.Click();
           
            string text = driver.SwitchTo().Alert().Text;               
            Assert.Equal("Zarezerwowano pojazd.", text);
            driver.SwitchTo().Alert().Accept();         

            driver.Quit();
        }
        

        //[Fact]
        //public void ReservationFormTest_1()
        //{
        //    ChromeDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("https://localhost:7214/Users/Reservation/Create");
        //    var startBox = driver.FindElement(By.Name("reservationStart"));
        //    var stopBox = driver.FindElement(By.Name("reservationEnd"));
        //    var vehicle = driver.FindElement(By.Name("VehicleId"));
        //    var resButton = driver.FindElement(By.Name("resBtn"));

        //    startBox.SendKeys("08070020230800");
        //    stopBox.SendKeys("04080020230800");
        //    vehicle.SendKeys("Honda");
        //    resButton.Click();
        //    driver.SwitchTo().Alert().Accept();
        //    driver.Quit();
        //}

    }
}
