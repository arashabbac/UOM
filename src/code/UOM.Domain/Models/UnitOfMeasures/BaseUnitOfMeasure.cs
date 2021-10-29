using UOM.Domain.Models.Dimensions;

namespace UOM.Domain.Models.UnitOfMeasures
{
    public class BaseUnitOfMeasure
    {
        public BaseUnitOfMeasure(long id,string name , string symbol , Dimension dimension)
        {
            Id = id;
            Name = name;
            Symbol = symbol;
            DimensionId = dimension.Id;
        }

        public long Id { get; private set; }
        public string Name { get; private set; }
        public string Symbol { get; private set; }
        public long DimensionId { get; private set; }
    }
}
