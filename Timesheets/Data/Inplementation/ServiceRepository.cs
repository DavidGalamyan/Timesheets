using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Data.Interfaces;
using Timesheets.Models;

namespace Timesheets.Data.Inplementation
{
    public class ServiceRepository : IServiceRepository
    {
        public void Add(Service service)
        {
            throw new NotImplementedException();
        }

        public Service GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Service> GetItems()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
