using NUnit.Framework;
using WebApi.Controllers;
using Moq;
using Microsoft.Extensions.Logging;
using WebApi;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApi.Tests
{
    public class WeatherForecastControllerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DatesRepresentFiveDayForecast()
        {
            Mock<ILogger<WeatherForecastController>> mockLogger = new Mock<ILogger<WeatherForecastController>>();
            Mock<IDateTimeService> mockDateTimeService = new Mock<IDateTimeService>();
            mockDateTimeService.Setup(x => x.Now).Returns(DateTime.Parse("2021-07-01"));
            WeatherForecastController controller = new WeatherForecastController(mockLogger.Object, mockDateTimeService.Object);
            DateTime[] expectedForecaseDates = new DateTime[] 
            { 
                DateTime.Parse("2021-07-02"), 
                DateTime.Parse("2021-07-03"), 
                DateTime.Parse("2021-07-04"), 
                DateTime.Parse("2021-07-05"), 
                DateTime.Parse("2021-07-06")
            };
            IEnumerable<WeatherForecast> actualForecasts = controller.Get();
            DateTime[] actualForecastDates = actualForecasts.Select(forecast => forecast.Date).ToArray();
            Assert.That(actualForecastDates, Is.EquivalentTo(expectedForecaseDates));
        }
    }
}