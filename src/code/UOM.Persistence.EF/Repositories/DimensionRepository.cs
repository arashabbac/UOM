using UOM.Domain.Models.Dimensions;

namespace UOM.Persistence.EF.Repositories
{
    public class DimensionRepository : IDimensionRepository
    {
        private readonly UomContext _context;

        public DimensionRepository(UomContext uomContext)
        {
            _context = uomContext;
        }

        public void Add(Dimension dimension)
        {
            _context.Dimensions.Add(dimension);
            _context.SaveChanges();
        }

        public Dimension GetById(long id)
        {
            return _context.Dimensions.Find(id);
        }
    }
}
