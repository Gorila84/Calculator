using Calculator.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain.Interfaces
{
    public interface IMeasureRepository
    {
        void DeleteMeasure(int measureId);
        int AddMeasure(Measure measure);
        int UpdateMeasure(Measure measure);
        Measure GetMeasure(int measureId);
        IQueryable<Measure> GetAllMeasures();
    }
}
