using System;
using SalesNewApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesNewApp.Services
{
    public class SalesRecordService
    {
        private readonly SalesNewAppContext _context;
        public SalesRecordService (SalesNewAppContext context)
        {
            _context = context;
        }


        public async  Task<List<SalesRecord>> FindByDateAsync (DateTime? minDate,DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }

            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending (x => x.Date)
                .ToListAsync();
        }
    }
}
