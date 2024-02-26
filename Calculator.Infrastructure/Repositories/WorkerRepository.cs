using Calculator.Domain.Interfaces;
using Calculator.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Infrastructure.Repositories
{
    public class WorkerRepository : IWorkerRepository
    {
        private readonly Context _db;

        public WorkerRepository(Context db)
        {
            _db = db;
        }

        public int AddWorker(Worker worker)
        {
            _db.Workers.Add(worker);
            _db.SaveChanges();
            return worker.Id;
        }

        public void DeleteWorker(int workerId)
        {
            var worker = _db.Workers.FirstOrDefault(w => w.Id == workerId);
            if (worker != null)
            {
                _db.Workers.Remove(worker);
                _db.SaveChanges();
            }
           
        }

        public IQueryable<Worker> GetAllWorkers()
        {
            var workers = _db.Workers;
            return workers;
        }

        public Worker GetWorker(int workerId)
        {
            var worker = _db.Workers.FirstOrDefault(w => w.Id == workerId);
            return worker;
        }

        public int UpdateWorker(Worker worker)
        {
            throw new NotImplementedException();
        }
    }
}
