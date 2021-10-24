using System;

namespace UOM.Domain
{
    public class ScaledUnitOfMeasure
    {
        public ScaledUnitOfMeasure(long id, string name, string symbol,decimal conversionRate, BaseUnitOfMeasure baseUnitOfMeasure)
        {
            Id = id;
            Name = name;
            Symbol = symbol;
            ConversionRate = conversionRate;
            BaseUnitOfMeasureId = baseUnitOfMeasure.Id;
        }

        public long Id { get; private set; }
        public string Name { get; private set; }
        public string Symbol { get; private set; }
        public decimal ConversionRate { get; private set; }
        public long BaseUnitOfMeasureId { get; private set; }

        public decimal ConvertToBase(decimal amount)
        {
            return amount * ConversionRate;
        }

        public decimal ConvertTo(ScaledUnitOfMeasure targetUOM, decimal amount)
        {
            var valueInBase = ConvertToBase(amount);
            return valueInBase / targetUOM.ConversionRate;
        }
    }
}
