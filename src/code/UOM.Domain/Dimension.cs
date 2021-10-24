namespace UOM.Domain
{
    public class Dimension
    {
        public Dimension(long id,string name, string symbol)
        {
            Id = id;
            Name = name;
            Symbol = symbol;
        }

        public long Id { get; private set; }
        public string Name { get; private set; }

        public string Symbol { get; set; }
    }
}