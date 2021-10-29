namespace UOM.Domain.Models.Dimensions
{
    public interface IDimensionRepository
    {
        int NextId();
        void Add(Dimension dimension);
    }
}
