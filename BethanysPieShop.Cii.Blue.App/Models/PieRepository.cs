using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Cii.Blue.App.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _appDbContext;

        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> AllPies => _appDbContext.Pies.Include(p => p.Category).OrderBy(p => p.Name);

        public IEnumerable<Pie> PiesOfTheWeek => _appDbContext.Pies.Include(p => p.Category).Where(p => p.IsPieOfTheWeek).OrderBy(p => p.Name);

        public Pie GetPieById(int pieId)
        {
            return _appDbContext.Pies.Include(p => p.Category).SingleOrDefault(p =>p.PieId==pieId);
        }
    }
}
