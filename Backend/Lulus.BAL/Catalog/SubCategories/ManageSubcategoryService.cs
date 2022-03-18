﻿using Lulus.BAL.Catalog.SubCategories.Interfaces;
using Lulus.Data.EF;
using Lulus.ViewModels.SubCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lulus.Data.Entities;

namespace Lulus.BAL.Catalog.SubCategories
{
    public class ManageSubcategoryService : IManageSubcategoryService
    {
        private readonly LulusDBContext _context;
        public ManageSubcategoryService(LulusDBContext context)
        {
            _context = context;
        }
        public async Task<int> CreateSubCategory(CreateSubCategoryRequest request)
        {
            var subcate = new Subcategory()
            {
                ID = request.CategoryID,
                Name = request.Name
            };
            _context.Subcategories.Add(subcate);
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteSubCategory(int id)
        {
            var subcate = await _context.Subcategories.FindAsync(id);
            if (subcate == null) return false;
            _context.Subcategories.Remove(subcate);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<int> EditSubCategory(EditSubCategoryRequest request)
        {
            var subcate = await _context.Subcategories.FindAsync(request.ID);
            if (subcate == null) return 0;
            subcate.ID = request.CategoryID;
            subcate.Name = request.Name;
            return await _context.SaveChangesAsync();
        }
        public async Task<SubCateViewModel> GetSubCateDetailByID(GetSubCateDetailByID request)
        {
            //var subcate = await _context.Subcategories.FindAsync(request.ID);
            //if (subcate == null) return null;
            //var data = new SubCateViewModel()
            //{
            //    ID = subcate.ID,
            //    Name = subcate.Name
            //};
            //var category = await _context.Categories.FindAsync(subcate.ID);
            //data.Category = new ViewModels.Categories.CategoryViewModel()
            //{
            //    ID = category.Category_ID,
            //    Name = category.Category_Name
            //};
            //return data;
            return null;
        }
    }
}
