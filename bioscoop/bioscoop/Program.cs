using bioscoop;
using System;

Console.WriteLine("Hello, World!");

Movie movie = new("movie1");
MovieScreening screening1 = new(movie, new DateTime(2023, 3, 3, 16, 30, 00), 6.50);
MovieTicket ticket1s1 = new(screening1, false, 1, 1);
MovieTicket ticket2s1 = new(screening1, false, 1, 2);
MovieTicket ticket3s1 = new(screening1, false, 1, 3);
MovieTicket ticket4s1 = new(screening1, false, 1, 4);
MovieTicket ticket5s1 = new(screening1, false, 1, 5);
MovieTicket ticket6s1 = new(screening1, false, 1, 6);

MovieScreening screening2 = new(movie, new DateTime(2023, 3, 3, 16, 30, 00), 6.50);
MovieTicket ticket1s2 = new(screening2, true, 1, 1);
MovieTicket ticket2s2 = new(screening2, true, 1, 2);
MovieTicket ticket3s2 = new(screening2, true, 1, 3);
MovieTicket ticket4s2 = new(screening2, true, 1, 4);
MovieTicket ticket5s2 = new(screening2, false, 1, 5);
MovieTicket ticket6s2 = new(screening2, false, 1, 6);
MovieTicket ticket7s2 = new(screening2, false, 1, 7);
MovieTicket ticket8s2 = new(screening2, false, 1, 8);
MovieTicket ticket9s2 = new(screening2, false, 1, 9);

Order order1 = new(1, false);
order1.AddSeatReservation(ticket1s1);
order1.AddSeatReservation(ticket2s1);
order1.AddSeatReservation(ticket3s1);
order1.AddSeatReservation(ticket4s1);
order1.AddSeatReservation(ticket5s1);
order1.AddSeatReservation(ticket6s1);
Console.WriteLine(order1.CalculatePrice());
order1.Export(TicketExportFormat.PLAINTEXT, content, content);
order1.Export(TicketExportFormat.JSON, content, content);


Order order2 = new(2, false);
order2.AddSeatReservation(ticket1s2);
order2.AddSeatReservation(ticket2s2);
order2.AddSeatReservation(ticket3s2);
Console.WriteLine(order2.CalculatePrice());

Order order3 = new(3, false);
order3.AddSeatReservation(ticket1s2);
order3.AddSeatReservation(ticket2s2);
order3.AddSeatReservation(ticket3s2);
order3.AddSeatReservation(ticket4s2);
order3.AddSeatReservation(ticket5s2);
order3.AddSeatReservation(ticket6s2);
order3.AddSeatReservation(ticket7s2);
order3.AddSeatReservation(ticket8s2);
order3.AddSeatReservation(ticket9s2);
Console.WriteLine(order3.CalculatePrice());

Order order4 = new(4, true);
order4.AddSeatReservation(ticket1s1);
order4.AddSeatReservation(ticket2s1);
order4.AddSeatReservation(ticket3s1);
order4.AddSeatReservation(ticket4s1);
order4.AddSeatReservation(ticket5s1);
order4.AddSeatReservation(ticket6s1);
Console.WriteLine(order4.CalculatePrice());

Order order5 = new(5, true);
order5.AddSeatReservation(ticket1s2);
order5.AddSeatReservation(ticket2s2);
order5.AddSeatReservation(ticket3s2);
order5.AddSeatReservation(ticket4s2);
order5.AddSeatReservation(ticket5s2);
order5.AddSeatReservation(ticket6s2);
order5.AddSeatReservation(ticket7s2);
order5.AddSeatReservation(ticket8s2);
order5.AddSeatReservation(ticket9s2);
Console.WriteLine(order5.CalculatePrice());

