namespace Homework4
{
    public interface ICashProvider
    {
        public bool buy(double price);
        public bool IsAuthorization(Customer customer);
    }
}
