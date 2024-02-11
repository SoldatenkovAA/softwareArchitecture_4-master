namespace Homework4
{
    public class Customer
    {
        public int Id { get; set; }
        public List<Ticket> Tickets { get; set; }
        public ICashProvider CashProvider { get; set; }
        public Customer(int id, ICashProvider cashProvider) {
            Tickets = new List<Ticket>();
            Id = id;
            CashProvider = cashProvider;
        }

        public List<Ticket> searchTickets(ITicketProvider ticketProvider)
        {
            return ticketProvider.getTickets();
        }

        public bool buyTicket(Ticket ticket, ITicketProvider ticketProvider)
        {
            bool answer = ticketProvider.buyTicket(ticket, CashProvider);
            if (answer) { Tickets.Add(ticket); }
            return answer;
        }
    }
}
