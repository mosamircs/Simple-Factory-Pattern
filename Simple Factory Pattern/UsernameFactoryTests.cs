using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Simple_Factory_Pattern
{
    public class UsernameFactoryTests
    {
        private UsernameFactory _factory;

        public UsernameFactoryTests()
        {
            _factory = new UsernameFactory();
        }

        [Fact]
        public void ShouldGetFirstNameFirst()
        {
            //arrange
            var user = "Gary Woodfine";

            //act
            var username = _factory.GetUserName(user);

            //assert
            Assert.Equal("Gary", username.FirstName);
            Assert.Equal("Woodfine", username.LastName);

        }

        [Fact]
        public void ShouldGetLastNameFirst()
        {
            //arrange
            var user = "Woodfine, Gary";

            //act
            var username = _factory.GetUserName(user);

            //assert
            Assert.Equal("Gary", username.FirstName);
            Assert.Equal("Woodfine", username.LastName);

        }
    }
}
