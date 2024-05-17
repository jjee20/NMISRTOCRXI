﻿using Microsoft.EntityFrameworkCore;
using ServiceLayer.Services.IRepositories;
using InfastructureLayer.Data;
using DomainLayer.Models;
using InfastructureLayer.Repositories;

namespace thesis.Repositories
{
    public class AccountDetailsRepository : Repository<AccountDetails>, IAccountDetailsRepository
    {
        private readonly AppDbContext _context;

        public AccountDetailsRepository(AppDbContext context) : base(context) 
        {
            _context = context;
        }
        public void Update(AccountDetails receivingReport)
        {
            _context.Update(receivingReport);
        }
    }
}