
namespace Homework4.TicketProviders
{
    internal class CinemaProvider : ITicketProvider
    {
        public bool buyTicket(Ticket ticket, ICashProvider cashProvider)
        {
            bool answer = cashProvider.buy(ticket.Price);
            //меняем статус билета в б.д.
            return answer;
        }

        public List<Ticket> getTickets()
        {
            List<Ticket> result = new List<Ticket>();
            //запрос в б.д.
            return result;
        }
    }
}
