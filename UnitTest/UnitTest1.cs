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
      var res = new ValuesController();
      res.Get();
      Assert.Contains("navi", "navi");

        }
    }
}
