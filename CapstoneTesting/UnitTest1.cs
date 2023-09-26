using NUnit.Framework;
using MVC.Models;
using System;

namespace MVC.Tests
{
    [TestFixture]
    public class EmpInfoTests
    {
        [Test]
        public void EmpInfo_Id_SetAndGet()
        {
            // Arrange
            var empInfo = new EmpInfo();
            int expectedId = 1;

            // Act
            empInfo.Id = expectedId;
            int actualId = empInfo.Id;

            // Assert
            Assert.AreEqual(expectedId, actualId);
        }

        [Test]
        public void EmpInfo_EmailId_SetAndGet()
        {
            // Arrange
            var empInfo = new EmpInfo();
            string expectedEmail = "test@example.com";

            // Act
            empInfo.EmailId = expectedEmail;
            string actualEmail = empInfo.EmailId;

            // Assert
            Assert.AreEqual(expectedEmail, actualEmail);
        }

        [Test]
        public void EmpInfo_DateOfJoining_SetAndGet()
        {
            // Arrange
            var empInfo = new EmpInfo();
            DateTime expectedDate = DateTime.Now;

            // Act
            empInfo.DateOfJoining = expectedDate;
            DateTime actualDate = empInfo.DateOfJoining;

            // Assert
            Assert.That(actualDate, Is.EqualTo(expectedDate).Within(TimeSpan.FromSeconds(1)));
        }


        [Test]
        public void EmpInfo_PassCode_SetAndGet()
        {
            // Arrange
            var empInfo = new EmpInfo();
            int expectedPassCode = 12345;

            // Act
            empInfo.PassCode = expectedPassCode;
            int actualPassCode = empInfo.PassCode;

            // Assert
            Assert.AreEqual(expectedPassCode, actualPassCode);
        }
    }
}
