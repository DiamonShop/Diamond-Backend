﻿using Diamond.Entities.Data;
using DiamondShop.Data;
using DiamondShop.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiamondShop.Repositories
{
    public class JewelrySettingRepository : IJewelrySettingRepository
    {
        private readonly DiamondDbContext _context;

        public JewelrySettingRepository(DiamondDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<JewelrySettings>> GetAllJewelrySettings()
        {
            return await _context.JewelrySetting.ToListAsync();
        }

        public async Task<JewelrySettings> GetJewelrySettingById(int id)
        {
            return await _context.JewelrySetting.FindAsync(id);
        }

        public async Task<bool> CreateJewelrySetting(JewelrySettings jewelrySetting)
        {
            _context.JewelrySetting.Add(jewelrySetting);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateJewelrySetting(int id, JewelrySettings jewelrySetting)
        {
            var existingSetting = await _context.JewelrySetting.FindAsync(id);
            if (existingSetting == null)
            {
                return false;
            }

            existingSetting.Material = jewelrySetting.Material;

            _context.JewelrySetting.Update(existingSetting);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteJewelrySetting(int id)
        {
            var jewelrySetting = await _context.JewelrySetting.FindAsync(id);
            if (jewelrySetting == null)
            {
                return false;
            }

            _context.JewelrySetting.Remove(jewelrySetting);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
