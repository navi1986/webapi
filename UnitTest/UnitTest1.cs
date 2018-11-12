using System;
using Xunit;
using webapinew.Controllers;
namespace UnitTest
{
    public class UnitTest1
    {
    

        [Fact]
        public void Test1()
        {
      var obj = new HomeController();    
    
      Assert.Contains("navi", "navi");

        }
    }
}
