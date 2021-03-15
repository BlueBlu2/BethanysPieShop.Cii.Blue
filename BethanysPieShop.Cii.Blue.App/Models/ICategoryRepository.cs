using System.Collections.Generic;

namespace BethanysPieShop.Cii.Blue.App.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
