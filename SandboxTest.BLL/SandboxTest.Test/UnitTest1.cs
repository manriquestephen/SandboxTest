using SandboxTest.BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace SandboxTest.Test
{
    public class GenericClass : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Theory]
        [ClassData(typeof(MultiplicationEnumerable))]
        public void Multiplication_TheoryClassData(int param1, int param2, int expectedResult)
        {
            var service = new MultiplicationService();
            var actualResult = service.Multiplication(param1, param2);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void IsEven_ArithmeticException()
        {
            var service = new MultiplicationService();


            Assert.Throws<ArithmeticException>(() => service.IsEven(1));
        }



        public static IEnumerable<object[]> GetMemberData =>
            new List<object[]>
            {
                new object[]{1,2, 2  },
                new object[]{2,2, 4}
            };

        [Theory]
        [MemberData(nameof(GetMemberData))]
        public void Multiplication_TheoryMemberData(int param1, int param2, int expectedResult)
        {
            var service = new MultiplicationService();
            var actualResult = service.Multiplication(param1, param2);
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 2, 8)]
        [InlineData(3, 2, 6)]
        [InlineData(5, 2, 10)]
        public void Multiplication_Theory(int param1, int param2, int expectedResult)
        {
            var service = new MultiplicationService();
            var actualResult = service.Multiplication(param1, param2);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Multiplication_Success()
        {
            var service = new MultiplicationService();
            var actualResult = service.Multiplication(5, 10);
            Assert.Equal(50, actualResult);
        }

       

     
    }
}

