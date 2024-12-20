using System;

namespace uppfinnaren_1_0_MilicaBl.Models;

public interface IMaterialRepository
{

    IEnumerable<Material> GetAllMaterials();
}
