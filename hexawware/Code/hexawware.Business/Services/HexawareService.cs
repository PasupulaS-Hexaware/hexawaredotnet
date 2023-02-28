using hexawware.Business.Interfaces;
using hexawware.Data.Interfaces;
using hexawware.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace hexawware.Business.Services
{
    public class HexawareService : IHexawareService
    {
        IHexawareRepository _HexawareRepository;

        public HexawareService(IHexawareRepository HexawareRepository)
        {
           this._HexawareRepository = HexawareRepository;
        }
        public IEnumerable<Hexaware> GetAll()
        {
            return _HexawareRepository.GetAll();
        }

        public Hexaware Save(Hexaware Hexaware)
        {
            _HexawareRepository.Save(Hexaware);
            return Hexaware;
        }

        public Hexaware Update(Hexaware Hexaware)
        {
            return _HexawareRepository.Update( Hexaware);
        }

        public bool Delete(int id)
        {
            return _HexawareRepository.Delete(id);
        }
        public Hexaware GetById(int id)
        {
            return _HexawareRepository.GetById(id);
        }
    }
}
