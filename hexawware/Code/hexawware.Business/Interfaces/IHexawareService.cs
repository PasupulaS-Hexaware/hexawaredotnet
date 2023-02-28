using hexawware.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace hexawware.Business.Interfaces
{
    public interface IHexawareService
    {      
        IEnumerable<Hexaware> GetAll();
        Hexaware Save(Hexaware classification);
        Hexaware Update(Hexaware classification);
        bool Delete(int id);
        Hexaware  GetById(int id);

    }
}
