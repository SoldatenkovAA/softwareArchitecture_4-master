
namespace Homework4.CashProviders
{
    internal class CardPay : ICashProvider
    {
        public long NumberCard { get; set; }
        public bool IsAuth {  get; set; }

        public CardPay(Customer customer, long numberCard)
        {
            IsAuth = IsAuthorization(customer);
            NumberCard = numberCard;
            
        }

        public bool IsAuthorization(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool buy(double price)
        {
            throw new NotImplementedException();
        }

    }
}
