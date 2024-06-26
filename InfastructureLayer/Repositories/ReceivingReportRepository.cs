﻿using Microsoft.EntityFrameworkCore;
using ServiceLayer.Services.IRepositories;
using InfastructureLayer.Data;
using DomainLayer.Models;
using InfastructureLayer.Repositories;

namespace thesis.Repositories
{
    public class ReceivingReportRepository : Repository<ReceivingReport>, IReceivingReportRepository
    {
        private readonly AppDbContext _context;

        public ReceivingReportRepository(AppDbContext context) : base(context) 
        {
            _context = context;
        }
        public void Update(ReceivingReport receivingReport)
        {
            _context.Update(receivingReport);
        }
    }
}
