using System;
using Xunit;

namespace XUnitTestProject1
{
    public class TypeTests
    {
        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book 1");
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
