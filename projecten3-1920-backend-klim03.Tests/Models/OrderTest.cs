using projecten3_1920_backend_klim03.Domain.Models.Domain;
using projecten3_1920_backend_klim03.Domain.Models.CustomExceptions;
using projecten3_1920_backend_klim03.Tests.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace projecten3_1920_backend_klim03.Tests.Models
{
    public class OrderTest : IDisposable
    {
        private readonly DummyApplicationDbContext _dummyApplicationDbContext;
        private Order testOrder;

        public OrderTest()
        {
            _dummyApplicationDbContext = new DummyApplicationDbContext();
            testOrder = _dummyApplicationDbContext.testOrder;
        }

        [Fact]
        public void Order_AddItem_AddsItem()
        {
            int amountBefore = testOrder.OrderItems.Count;

            testOrder.AddOrderItem(_dummyApplicationDbContext.testOrderItem);

            Assert.Equal(amountBefore + 1, testOrder.OrderItems.Count);
        }

        [Fact]
        public void Order_AddItemToSubmittedOrder_ThrowsError()
        {
            testOrder.Submitted = true;
            Assert.Throws<NotSupportedException>(() => testOrder.AddOrderItem(_dummyApplicationDbContext.testOrderItem));
        }

        [Fact]
        public void Order_RemoveItem_RemovesItem()
        {
            int amountBefore = testOrder.OrderItems.Count;

            testOrder.RemoveOrderItem(testOrder.OrderItems.First());

            Assert.Equal(amountBefore - 1, testOrder.OrderItems.Count);
        }

        [Fact]
        public void Order_RemoveItemToSubmittedOrder_ThrowsError()
        {
            testOrder.Submitted = true;
            Assert.Throws<NotSupportedException>(() => testOrder.RemoveOrderItem(testOrder.OrderItems.First()));
        }

        [Fact]
        public void Order_GetOrderItemById_CorrectItem()
        {
            OrderItem it = testOrder.GetOrderItemById(1);

            Assert.NotNull(it);
            Assert.Equal("Karton", it.Product.ProductName);
            Assert.Equal(2, it.Amount);
            Assert.Equal(5, it.Product.Price);
        }

        [Fact]
        public void Order_GetOrderItemByNonExistantId_ThrowsError()
        {
            Assert.Throws<DomainArgumentNullException>(() => testOrder.GetOrderItemById(100));
        }

        [Fact]
        public void Order_CheckOrderPrice_CorrectPrice()
        {
            Assert.Equal(Convert.ToDecimal(55.5), testOrder.GetOrderPrice, 2);
        }

        public void Dispose()
        {
            testOrder = _dummyApplicationDbContext.testOrder;
        }
    }
}
