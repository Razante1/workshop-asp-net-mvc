﻿
using SalesNewApp.Models;


namespace SalesNewApp.Services
{
    public class SellerService
    {

        private readonly SalesNewAppContext _context;

        public SellerService(SalesNewAppContext context) 
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj) 
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}
