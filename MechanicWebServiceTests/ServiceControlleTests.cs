using MechanicWebService.Data;
using MechanicWebService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicWebServiceTests
{
    public class ServiceControlleTests
    {
        [Fact]
        public void Service_Description_Should_Not_Be_Null()
        {
            // Arrange
            var service = new Service { ServiceId = 1, Description = null, Price = 50 };

            // Act
            var validationResults = ValidateModel(service);

            // Assert
            Assert.Single(validationResults, r => r.MemberNames.Contains("Description") && r.ErrorMessage.Contains("required"));
        }

        [Fact]
        public void Service_Price_Should_Be_Greater_Than_Zero()
        {
            // Arrange
            var service = new Service { ServiceId = 1, Description = "Oil change", Price = -10 };

            // Act
            var validationResults = ValidateModel(service);

            // Assert
            Assert.Single(validationResults, r => r.MemberNames.Contains("Price") && r.ErrorMessage.Contains("greater than 0"));
        }

        private List<ValidationResult> ValidateModel(object model)
        {
            var validationResults = new List<ValidationResult>();
            var context = new ValidationContext(model, serviceProvider: null, items: null);
            Validator.TryValidateObject(model, context, validationResults, validateAllProperties: true);

            return validationResults;
        }
    }
}
