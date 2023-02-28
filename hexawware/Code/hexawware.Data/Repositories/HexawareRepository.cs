using hexawware.Data.Interfaces;
using hexawware.Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace hexawware.Data.Repositories
{
    public class HexawareRepository : IHexawareRepository
    {
        private readonly DataContext _context;        

        public HexawareRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Hexaware> GetAll()
        {            
            return _context.Hexaware.ToList();
        }

        public bool Save(Hexaware entity)
        {
            if (entity == null)
            return false;
            _context.Hexaware.Add(entity);
            var created= _context.SaveChanges();
            return created>0;
        }

        public Hexaware Update(Hexaware entity)
        {     
             _context.Hexaware.Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public bool Delete(int id)
        {          

            int deleted = 0;
            var entity = _context.Hexaware.FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                _context.Remove(entity);
                deleted = _context.SaveChanges();
            }
            return deleted > 0;
        }
        public Hexaware GetById(int id)
        {
            return _context.Hexaware.FirstOrDefault(x => x.Id == id);            
             
        }
    }
}
