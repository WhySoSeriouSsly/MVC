using Api.Models;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.ViewComponents
{
    public class CategoryListViewComponent:ViewComponent
    {
       private ICategoryService _categoryService;

        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ViewViewComponentResult Invoke()
        {

            //return View(new StudenListViewModel
            //{
            //    Students = _context.Students.Where(s => s.FirstName.ToLower().Contains(filter)).ToList()
            //});
            var model = new CategoryListViewModel
            {
                Categories = _categoryService.GetAll(),
                CurrentCategory=Convert.ToInt32(HttpContext.Request.Query["category"])//urlden kategoriyi yakalama

            };
            return View(model);
        }
    }
}
