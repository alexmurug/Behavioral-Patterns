namespace StrategyPattern
{
    public class StrategyContext
    {
        private readonly PriceStrategy _priceStrategy;
        public StrategyContext(PriceStrategy priceStrategy)
        {
            _priceStrategy = priceStrategy;
        }

        public void ContextInterface(int price)
        {
            _priceStrategy.AlgorithmCalculatings(price);
        }
    }
}
