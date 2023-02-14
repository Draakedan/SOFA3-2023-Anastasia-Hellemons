using bioscoop;
using NUnit.Framework;
using System;

namespace TestProject1
{
    public class Tests
    {

        private readonly static Movie movie = new("movie1");
        private readonly static MovieScreening screening1 = new(movie, new DateTime(2023, 3, 4, 16, 30, 00), 2);
        private readonly static MovieTicket ticket1s1 = new(screening1, false, 1, 1);
        private readonly static MovieTicket ticket2s1 = new(screening1, false, 1, 2);
        private readonly static MovieTicket ticket3s1 = new(screening1, false, 1, 3);
        private readonly static MovieTicket ticket4s1 = new(screening1, false, 1, 4);
        private readonly static MovieTicket ticket5s1 = new(screening1, false, 1, 5);
        private readonly static MovieTicket ticket6s1 = new(screening1, false, 1, 6);
        private readonly static MovieTicket ticketp1s1 = new(screening1, true, 1, 1);
        private readonly static MovieTicket ticketp2s1 = new(screening1, true, 1, 2);
        private readonly static MovieTicket ticketp3s1 = new(screening1, true, 1, 3);
        private readonly static MovieTicket ticketp4s1 = new(screening1, true, 1, 4);
        private readonly static MovieTicket ticketp5s1 = new(screening1, true, 1, 5);
        private readonly static MovieTicket ticketp6s1 = new(screening1, true, 1, 6);

        private readonly static MovieScreening screening2 = new(movie, new DateTime(2023, 3, 3, 16, 30, 00), 2);
        private readonly static MovieTicket ticketp1s2 = new(screening2, true, 1, 1);
        private readonly static MovieTicket ticketp2s2 = new(screening2, true, 1, 2);
        private readonly static MovieTicket ticket1s2 = new(screening2, false, 1, 5);
        private readonly static MovieTicket ticket2s2 = new(screening2, false, 1, 6);

        [SetUp]
        public void Setup()
        {
            // Method intentionally left empty.
        }

        [Test]
        public void TestPrice_1StudentPrenium()
        {
            Order order = new(1, true);
            order.AddSeatReservation(ticketp1s2);
            var price = order.CalculatePrice();
            Assert.That(price, Is.EqualTo(4));
        }

        [Test]
        public void TestPrice_2StudentPrenium()
        {
            Order order = new(1, true);
            order.AddSeatReservation(ticketp1s2);
            order.AddSeatReservation(ticketp2s2);
            var price = order.CalculatePrice();
            Assert.That(price, Is.EqualTo(4));
        }

        [Test]
        public void TestPrice_1StudentNonPrenium()
        {
            Order order = new(1, true);
            order.AddSeatReservation(ticket1s2);
            var price = order.CalculatePrice();
            Assert.That(price, Is.EqualTo(2));
        }

        [Test]
        public void TestPrice_2StudentNonPrenium()
        {
            Order order = new(1, true);
            order.AddSeatReservation(ticket1s2);
            order.AddSeatReservation(ticket2s2);
            var price = order.CalculatePrice();
            Assert.That(price, Is.EqualTo(2));
        }

        [Test]
        public void TestPrice_1NonStudentPreniumWeekday()
        {
            Order order = new(1, false);
            order.AddSeatReservation(ticketp1s2);
            var price = order.CalculatePrice();
            Assert.That(price, Is.EqualTo(5));
        }

        [Test]
        public void TestPrice_2NonStudentPreniumWeekday()
        {
            Order order = new(1, false);
            order.AddSeatReservation(ticketp1s2);
            order.AddSeatReservation(ticketp2s2);
            var price = order.CalculatePrice();
            Assert.That(price, Is.EqualTo(5));
        }

        [Test]
        public void TestPrice_1NonStudentNonPreniumWeekday()
        {
            Order order = new(1, false);
            order.AddSeatReservation(ticket1s2);
            var price = order.CalculatePrice();
            Assert.That(price, Is.EqualTo(2));
        }

        [Test]
        public void TestPrice_2NonStudentNonPreniumWeekday()
        {
            Order order = new(1, false);
            order.AddSeatReservation(ticket1s2);
            order.AddSeatReservation(ticket2s2);
            var price = order.CalculatePrice();
            Assert.That(price, Is.EqualTo(2));
        }

        [Test]
        public void TestPrice_1NonStudentPreniumWeekend()
        {
            Order order = new(1, false);
            order.AddSeatReservation(ticketp1s1);
            var price = order.CalculatePrice();
            Assert.That(price, Is.EqualTo(5));
        }

        [Test]
        public void TestPrice_6NonStudentPreniumWeekend()
        {
            Order order = new(1, false);
            order.AddSeatReservation(ticketp1s1);
            order.AddSeatReservation(ticketp2s1);
            order.AddSeatReservation(ticketp3s1);
            order.AddSeatReservation(ticketp4s1);
            order.AddSeatReservation(ticketp5s1);
            order.AddSeatReservation(ticketp6s1);
            var price = order.CalculatePrice();
            Assert.That(price, Is.EqualTo(27));
        }

        [Test]
        public void TestPrice_1NonStudentNonPreniumWeekend()
        {
            Order order = new(1, false);
            order.AddSeatReservation(ticket1s1);
            var price = order.CalculatePrice();
            Assert.That(price, Is.EqualTo(2));
        }

        [Test]
        public void TestPrice_6NonStudentNonPreniumWeekend()
        {
            Order order = new(1, false);
            order.AddSeatReservation(ticket1s1);
            order.AddSeatReservation(ticket2s1);
            order.AddSeatReservation(ticket3s1);
            order.AddSeatReservation(ticket4s1); 
            order.AddSeatReservation(ticket5s1);
            order.AddSeatReservation(ticket6s1);
            var price = order.CalculatePrice();
            Assert.That(price, Is.EqualTo(10.8));
        }

    }
}