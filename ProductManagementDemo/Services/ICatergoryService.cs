using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects_;

namespace Services
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
    }
}
