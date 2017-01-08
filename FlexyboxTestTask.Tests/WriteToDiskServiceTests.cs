using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlexyboxTestTask.Tests
{
    [TestClass]
    public class WriteToDiskServiceTests
    {
        private readonly List<Vehicle> _instances
            = new List<Vehicle> { new Bicycle(), new Bus(), new Car(), new AbcVehicle() };

        [TestMethod]
        public void ShouldWriteToFile()
        {
            //Arrange
            var writeService = new WriteToDiskService();
            string mydocpath =
               Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //Act
            writeService.Write(_instances);
            var fileText = File.ReadLines(mydocpath + @"\Types.txt");
            //Assert
            Assert.IsTrue(fileText.Count() == 4);
        }
    }
}
