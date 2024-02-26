using Calculator.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain.Interfaces
{
    public interface IMaterialRepository
    {
        void DeleteMaterial(int materialId);
        int AddMaterial(Material material);
        int UpdateMaterial(Material material);
        Material GetMaterial(int materialId);
        IQueryable<Material> GetAllMaterials();
    }
}
