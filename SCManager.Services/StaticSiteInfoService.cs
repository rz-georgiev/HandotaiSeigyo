﻿using Microsoft.EntityFrameworkCore;
using SCManager.Data;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using System;
using System.Threading.Tasks;

namespace SCManager.Services
{
    public class StaticSiteInfoService : IStaticSiteInfoService
    {
        private readonly SCManagerDbContext _context;

        public StaticSiteInfoService(SCManagerDbContext context)
        {
            _context = context;
        }

        public async Task<StaticSiteInfo> GetByIdAsync(int? id)
        {
            return await _context.StaticSiteInfos
                .SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<StaticSiteInfo> GetByNameAsync(string name)
        {
            return await _context.StaticSiteInfos
                .SingleOrDefaultAsync(x => x.Name == name);
        }

        public async Task<bool> SaveChangesAsync(StaticSiteInfo info)
        {
            try
            {
                if (info == null)
                {
                    await _context.AddAsync(info);
                }
                else
                {
                    _context.Update(info);
                }

                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}