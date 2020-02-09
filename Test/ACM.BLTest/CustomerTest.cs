using ACM.BL;
using Xunit;

namespace ACM.BLTest
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Johan",
                LastName = "Elvemo"
            };
            string expected = "Elvemo, Johan";
            //Act
            string actual = customer.FullName;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                LastName = "Elvemo"
            };
            string expected = "Elvemo";
            //Act
            string actual = customer.FullName;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Johan"
            };
            string expected = "Johan";
            //Act
            string actual = customer.FullName;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void StaticTest()
        {
            //-- Arrange
            var c1 = new Customer();
            c1.FirstName = "Lars";

            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Per";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Luka";
            Customer.InstanceCount += 1;

            //-- Act

            //-- Assert
            Assert.Equal(3, Customer.InstanceCount);
        }
        [Fact]
        public void ValidateValid()
        {
            //-- Arrange
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "fbaggins@hobbiton.me"
            };

            var expected = true;

            //-- Act
            var actual = customer.Validate();

            //-- Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ValidateMissingLastName()
        {
            //-- Arrange
            var customer = new Customer
            {
                EmailAddress = "fbaggins@hobbiton.me"
            };

            var expected = false;

            //-- Act
            var actual = customer.Validate();

            //-- Assert
            Assert.Equal(expected, actual);
        }

    }
}
