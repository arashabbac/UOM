namespace UOM.Domain.Models.Dimensions
{
    public class Dimension
    {
        public Dimension(string name, string symbol)
        {
            Name = name;
            Symbol = symbol;
        }

        public long Id { get; private set; }
        public string Name { get; private set; }

        public string Symbol { get; private set; }
    }
}