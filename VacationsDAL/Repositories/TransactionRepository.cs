﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using VacationsDAL.Contexts;
using VacationsDAL.Entities;
using VacationsDAL.Interfaces;

namespace VacationsDAL.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly VacationsContext _context;

        public TransactionRepository(VacationsContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<Transaction> GetAll()
        {
            return _context.Transactions.ToList();
        }

        public Transaction GetById(string id)
        {
            return _context.Transactions.FirstOrDefault(x => x.TransactionID == id);
        }

        public void Remove(string id)
        {
            var obj = _context.Transactions.FirstOrDefault(x => x.TransactionID == id);

            if (obj != null)
            {
                _context.Transactions.Remove(obj);
                _context.SaveChanges();
            }
        }

        public void Add(Transaction Transaction)
        {
       
            
                _context.Transactions.Add(Transaction);
                _context.SaveChanges();
            
           
        }
    }
}
