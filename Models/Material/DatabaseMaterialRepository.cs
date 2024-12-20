using System;

namespace uppfinnaren_1_0_MilicaBl.Models;

public class DatabaseMaterialRepository : IMaterialRepository
{
    private readonly AppDbContext _context;
    public DatabaseMaterialRepository(AppDbContext context)
    {
        _context = context;
    }
    public IEnumerable<Material> GetAllMaterials()
    {
        return _context.Materials.ToList();
    }
}
