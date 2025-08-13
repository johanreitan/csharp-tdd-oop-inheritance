﻿using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            ReadingObject book = new Book("JUnit Rocks", new Author("Johan", "123456", "123spill.no"));
            Assert.AreEqual("item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            ReadingObject book = new Book("JUnit Rocks", new Author("Johan", "123456", "123spill.no"));
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            ReadingObject book = new Book("JUnit Rocks", new Author("Johan", "123456", "123spill.no"));
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            ReadingObject book = new Book("JUnit Rocks", new Author("Johan", "123456", "123spill.no"));

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }
    }
}