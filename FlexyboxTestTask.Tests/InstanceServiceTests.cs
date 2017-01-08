using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlexyboxTestTask.Tests
{
    [TestClass]
    public class InstanceServiceTests
    {
        [TestMethod]
        public void ShouldReturnValidInstancesCount()
        {
            //Arrange
            var assembly = typeof(Vehicle).Assembly;
            var types = assembly.GetTypes().Where(t => t.BaseType == typeof(Vehicle));
            //Act
            var instances = InstanceService<Vehicle>.GetInstances();
            //Assert
            Assert.IsTrue(types.Count() == instances.Count());
        }
    }
}
