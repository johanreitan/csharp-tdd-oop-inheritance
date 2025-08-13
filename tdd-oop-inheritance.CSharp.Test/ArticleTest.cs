using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
            {
                ReadingObject article = new Article("JUnit Rocks", new Author("Johan", "123456", "123spill.no"));
                Assert.AreEqual("item has been checked out", article.checkOut());
            }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
            {
                ReadingObject article = new Article("JUnit Rocks", new Author("Johan", "123456", "123spill.no"));
                article.checkOut();

                Assert.AreEqual("item is currently on loan", article.checkOut());
            }

        [Test]
        public void shouldCheckInIfOnLoan()
            {
                ReadingObject article = new Article("JUnit Rocks", new Author("Johan", "123456", "123spill.no"));
                article.checkOut();

                Assert.AreEqual("item has been checked in", article.checkIn());
            }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
            {
                ReadingObject article = new Article("JUnit Rocks", new Author("Johan", "123456", "123spill.no"));

                Assert.AreEqual("item is not currently on loan", article.checkIn());
            }
    }
}