﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bioscoop
{
    internal class Order
    {
        [JsonProperty]
        private int OrderNr { get; set; }
        [JsonProperty]
        private bool IsStudentOrder { get; set; }
        [JsonProperty]
        private List<MovieTicket> Tickets { get; set; }

        public Order(int orderNr, bool isStudentOrder)
        {
            this.OrderNr = orderNr;
            this.IsStudentOrder = isStudentOrder;
            this.Tickets = new List<MovieTicket>();
        }

        public int GetOrderNr()
        {
            return this.OrderNr;
        }

        public void AddSeatReservation(MovieTicket ticket)
        {
            this.Tickets.Add(ticket);
        }

        public double CalculatePrice()
        {
            double price = 0;
            if (this.IsStudentOrder)
                foreach (MovieTicket ticket in Tickets)
                {
                    if (Tickets.IndexOf(ticket) % 2 != 0)
                    {
                        if (ticket.IsPremiumTicket())
                            price += ticket.GetPrice() + 2;
                        else price += ticket.GetPrice();
                    }
                }
            else
                foreach (MovieTicket ticket in Tickets)
                {
                    if (ticket.ToString().Contains("Sunday") || ticket.ToString().Contains("Saturday"))
                    {
                        if (ticket.IsPremiumTicket())
                            price += ticket.GetPrice() + 3;
                        else price += ticket.GetPrice();

                        if (Tickets.Count >= 6)
                            price *= 0.9;
                    }
                    else
                    {
                        if (Tickets.IndexOf(ticket) % 2 != 0)
                        {
                            if (ticket.IsPremiumTicket())
                                price += ticket.GetPrice() + 3;
                            else price += ticket.GetPrice();
                        }
                    }
                }
            return price;
        }

        public void Export(TicketExportFormat exportFormat)
        {
            string content = "";
            if (exportFormat == TicketExportFormat.JSON)
            {
                content = JsonConvert.SerializeObject(this, Formatting.Indented);
                Console.WriteLine(content);
            }
            else
            {
                content += "Order: " + OrderNr + "\nstudentOrder: " + IsStudentOrder + "\n";
                foreach (MovieTicket ticket in Tickets)
                {
                    content += "\t" + ticket.ToString() + "\n\n";
                }
            }
            TextWriter? writer = null;
            try
            {

                writer = new StreamWriter("content.txt", false);
                writer.Write(content);
            }
            finally
            {
                writer?.Close();
            }
        }
    }
}
