using Demo;
using System;
using Xunit;

namespace XUnitTestProject2
{
    public class TypeTests
    {
        [Fact]
        public void Test1()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");

            Assert.Equal("New Name", book1.name);
        }

        public void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.name);
        }

        public void SetName(Book book, string name)
        {
            book.name = name;
        }


    }
}
