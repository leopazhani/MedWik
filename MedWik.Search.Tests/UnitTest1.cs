using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MedWik.Training.Components.Controllers;

namespace MedWik.Search.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ResourceExtractController controller = new ResourceExtractController();
            var result=controller.ExtractFromWebsite("http://www.healthline.com/health/pregnancy/complications-treatments#Amnioticfluidcomplications8")?.Result;

        }
        [TestMethod]
        public void TestMethod2()
        {
            ResourceExtractController controller = new ResourceExtractController();
            var result = controller.ExtractFromImage("https://cdn.theatlantic.com/assets/media/old_wire/img/upload/2012/09/24/shutterstock_101392744/lead_large.jpg")?.Result;

        }
    }
}
