using Calculator.Domain.Interfaces;
using Calculator.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Infrastructure.Repositories
{
    public class MaterialRepository : IMaterialRepository
    {
        private readonly Context _db;

        public MaterialRepository(Context db)
        {
            _db = db;
        }

        public int AddMaterial(Material material)
        {
            _db.Materials.Add(material);
            _db.SaveChanges();
            return material.Id;
        }

        public void DeleteMaterial(int materialId)
        {
            var material = _db.Materials.FirstOrDefault(w => w.Id == materialId);
            if (material != null)
            {
                _db.Materials.Remove(material);
                _db.SaveChanges();
            }
        }

        public IQueryable<Material> GetAllMaterials()
        {
            var materials = _db.Materials;
            return materials;
        }

        public Material GetMaterial(int materialId)
        {
            var material = _db.Materials.FirstOrDefault(w => w.Id == materialId);
            return material;
        }

        public int UpdateMaterial(Material material)
        {
            throw new NotImplementedException();
        }
    }
}
