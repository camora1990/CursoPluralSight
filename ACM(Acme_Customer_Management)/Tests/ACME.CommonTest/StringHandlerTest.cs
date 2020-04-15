using System;
using ACME.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACME.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //-- Arrange (Organizar)
         
            var source = "PirelliPilot";
            var expected = "Pirelli Pilot";
            //-- Act (Actuar)
            var actual = source.InsertSpaces();

            //-- Assert (Asignar)
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesWithExistingSpaces()
        {
            //-- Arrange (Organizar)
            var source = "Pirelli Pilot";
            var expected = "Pirelli Pilot";
            //-- Act (Actuar)
            var actual = source.InsertSpaces();

            //-- Assert (Asignar)
            Assert.AreEqual(expected, actual);
        }
    }
}
