using MechanicWebService.Data;
using MechanicWebService.Models;
using MechanicWebService.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace MechanicWebServiceTests
{
    public class PaymentRepositoryTests
    {
        private readonly PaymentRepository _repository;
        private readonly Mock<AppDbContext> _mockContext;

        public PaymentRepositoryTests()
        {
            _mockContext = new Mock<AppDbContext>();
            _repository = new PaymentRepository(_mockContext.Object);
        }

        [Fact]
        public async Task GetByIdAsync_WithExistingId_ReturnsPayment()
        {
            // Arrange
            var expectedPayment = new Payment { PaymentId = 1, ReservationId = 1, PaymentMethod = "Credit card", Amount = 100 };
            _mockContext.Setup(c => c.Payments.FindAsync(expectedPayment.PaymentId)).ReturnsAsync(expectedPayment);

            // Act
            var result = await _repository.GetByIdAsync(expectedPayment.PaymentId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedPayment.PaymentId, result.PaymentId);
            Assert.Equal(expectedPayment.ReservationId, result.ReservationId);
            Assert.Equal(expectedPayment.PaymentMethod, result.PaymentMethod);
            Assert.Equal(expectedPayment.Amount, result.Amount);
        }

        [Fact]
        public async Task GetByIdAsync_WithNonExistingId_ReturnsNull()
        {
            // Arrange
            var nonExistingId = 1;
            _mockContext.Setup(c => c.Payments.FindAsync(nonExistingId)).ReturnsAsync((Payment)null);

            // Act
            var result = await _repository.GetByIdAsync(nonExistingId);

            // Assert
            Assert.Null(result);
        }

        //[Fact]
        //public async Task AddAsync_WithValidPayment_SavesPayment()
        //{
        //    // Arrange
        //    var payment = new Payment { PaymentId = 1, ReservationId = 1, PaymentMethod = "Cash", Amount = 50 };

        //    // Act
        //    await _repository.AddAsync(payment);

        //    // Assert
        //    _mockContext.Verify(expression: c => c.Payments.AddAsync(payment), Times.Once);
        //    _mockContext.Verify(c => c.SaveChangesAsync(default), Times.Once);
        //}

    }
}
