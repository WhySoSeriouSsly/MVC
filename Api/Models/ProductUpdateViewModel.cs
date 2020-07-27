using Entities.Concrete;
using System.Collections.Generic;

namespace Api.Models
{
    class ProductUpdateViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}