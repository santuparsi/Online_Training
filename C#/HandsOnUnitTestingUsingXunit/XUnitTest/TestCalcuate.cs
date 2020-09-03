using System;
using Xunit;
using CalculateService;
using System.Collections.Generic;

namespace XUnitTest
{
    public class TestCalcuate
    {
      
        
        [Fact]
        public void TestAdd()
        {
            //Act
            Calculate obj = new Calculate();
            //Arrange
            int actual = obj.Add(1, 2);
            int expected = 2;
            //Assessrt
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void TestDiv()
        {
            Calculate obj = new Calculate();
            int actual = obj.Div(1,0);
            
        }
        [Fact]
        public void TestGetNo()
        {
            //Act
            Calculate obj = new Calculate();
            List<int> list = obj.GetNos();
            Assert.NotNull(list);
            Assert.Equal(5, list.Count);
           
        }
    }
}
