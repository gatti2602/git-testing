using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "new name");

            Assert.Equal("new name", book1.Name);

            
        }

        private void SetName(Book book1, string v)
        {
            book1.Name = v;
        }
        
        [Fact]
        public void CSharpISPassByValue()
        {
            var book1 = GetBook("Book 1");
            GetSetName(book1, "new name");

            Assert.Equal("Book 1", book1.Name);

            
        }

        private void GetSetName(Book book1, string v)
        {
            book1 = new Book(v);
        }

       [Fact]
        public void CSharpISPassByRef()
        {
            var book1 = GetBook("Book 1");
            GetSetName(ref book1, "new name"); //tmb se puede usar out

            Assert.Equal("new name", book1.Name);

            
        }

        private void GetSetName(ref Book book1, string v)
        {
            book1 = new Book(v);
        }


        [Fact]
        public void Test1()
        {
            var book1 = GetBook("Book 1");

            Assert.Equal("Book 1", book1.Name);
            
        }
        [Fact]
        public void TwoVarsReferencesSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1,book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
