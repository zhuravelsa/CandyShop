using CandyShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Components
{

    public class CategoryMenu : ViewComponent
    {

        private readonly ICategoryRepository _categoryRepository;

        public CategoryMenu(ICategoryRepository categoryRepository) 
        {
            this._categoryRepository = categoryRepository;
        }


        public IViewComponentResult Invoke() 
        {
            var categories = this._categoryRepository.GetAllCategories
                                                     .OrderBy(c => c.CategoryName);
            return View(categories);
        }

    }
}
