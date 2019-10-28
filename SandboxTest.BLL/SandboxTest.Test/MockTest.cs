using Moq;
using SandboxTest.BLL;
using SandboxTest.DAL;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SandboxTest.Test
{
    public class MockTest
    {
        [Fact]
        public void Total_Success()
        {
            var list = new List<PriceEntity>()
            {
                new PriceEntity{Amount = 500},
                new PriceEntity{Amount = 1000}
            };

            Mock<IPriceRepository> mockRepo = new Mock<IPriceRepository>();
            mockRepo.Setup(x => x.GetPrice()).Returns(list);

            IPriceService service = new PriceService(mockRepo.Object);

            var actual = service.Total(1000);
            Assert.Equal(2500, actual);

        }

        [Fact]

        public void Total_Save()
        {
            var list = new List<PriceEntity>()
            {
                new PriceEntity{Amount = 500},
                new PriceEntity{Amount = 1000}
            };

            Mock<IPriceRepository> mockRepo = new Mock<IPriceRepository>();
            mockRepo.Setup(x => x.GetPrice()).Returns(list);
            mockRepo.Setup(x => x.Save()).Verifiable();

            IPriceService service = new PriceService(mockRepo.Object);

            var actual = service.Total(1);

            mockRepo.Verify(x=>x.Save(),Times.Exactly(2));
        }
    }
}
