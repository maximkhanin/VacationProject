﻿using System;
using System.Linq;
using VacationsDAL.Contexts;
using VacationsDAL.Entities;
using VacationsDAL.Interfaces;

namespace VacationsDAL.Repositories
{
    public class TransactionTypeRepository : ITransactionTypeRepository
    {
        private readonly VacationsContext _context;

        public TransactionTypeRepository(VacationsContext dbContext)
        {
            _context = dbContext;
        }

        public TransactionType[] Get(Func<TransactionType, bool> whereCondition = null)
        {
            IQueryable<TransactionType> baseCondition = _context.TransactionTypes;
            return whereCondition == null ?
                baseCondition.ToArray() :
                baseCondition.Where(whereCondition).ToArray();
        }

        public TransactionType GetById(string id)
        {
            return _context.TransactionTypes.FirstOrDefault(x => x.TransactionTypeID == id);
        }

        public void Remove(string id)
        {
            var obj = _context.TransactionTypes.FirstOrDefault(x => x.TransactionTypeID == id);

            if (obj != null)
            {
                _context.TransactionTypes.Remove(obj);
                _context.SaveChanges();
            }
        }

        public void Add(TransactionType TransactionType)
        {
            _context.TransactionTypes.Add(TransactionType);
            _context.SaveChanges();
        }  


        public TransactionType GetByType(string type)
        {
            return _context.TransactionTypes.FirstOrDefault(x => x.TransactionTypeName.Equals(type));
        }
    }
}
