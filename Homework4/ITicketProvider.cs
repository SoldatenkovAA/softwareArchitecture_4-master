namespace Homework4
{
    public interface ITicketProvider
    {
        public List<Ticket> getTickets();
        public bool buyTicket(Ticket ticket, ICashProvider cashProvider);
    }
}
