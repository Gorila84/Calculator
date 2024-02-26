using Calculator.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain.Interfaces
{
    public interface IWorkerRepository
    {
        void DeleteWorker(int workerId);
        int AddWorker(Worker worker);
        int UpdateWorker(Worker worker);
        Worker GetWorker(int workerId);
        IQueryable<Worker> GetAllWorkers();

    }
}
