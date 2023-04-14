using HRM.API;

namespace HRM.Test
{
    [TestClass]
    public class UnitTest1
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [TestMethod]
        public void TestMethod1()
        {
            var result =  Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            bool result = true;
            Assert.IsTrue(result);
        }
    }
}