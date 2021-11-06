namespace UOM.Domain.Models.Dimensions
{
    public interface IDimensionRepository
    {
        void Add(Dimension dimension);
        Dimension GetById(long id);
    }
}
