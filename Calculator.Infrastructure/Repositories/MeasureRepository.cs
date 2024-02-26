using Calculator.Domain.Interfaces;
using Calculator.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Infrastructure.Repositories
{
    public class MeasureRepository : IMeasureRepository
    {
        private readonly Context _db;

        public MeasureRepository(Context db)
        {
            _db = db;
        }

        public int AddMeasure(Measure measure)
        {
            _db.Measures.Add(measure);
            _db.SaveChanges();
            return measure.Id;
        }

        public void DeleteMeasure(int measureId)
        {
            var measure = _db.Measures.FirstOrDefault(w => w.Id == measureId);
            if (measure != null)
            {
                _db.Measures.Remove(measure);
                _db.SaveChanges();
            }
        }

        public IQueryable<Measure> GetAllMeasures()
        {
            var measures = _db.Measures;
            return measures;
        }

        public Measure GetMeasure(int measureId)
        {
            var measure = _db.Measures.FirstOrDefault(w => w.Id == measureId);
            return measure;
        }

        public int UpdateMeasure(Measure measure)
        {
            throw new NotImplementedException();
        }
    }
}
