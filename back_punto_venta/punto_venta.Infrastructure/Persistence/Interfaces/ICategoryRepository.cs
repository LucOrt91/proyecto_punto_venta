using punto_venta.Domain.Entities;
using punto_venta.Infrastructure.Commons.Bases.Request;
using punto_venta.Infrastructure.Commons.Bases.Response;

namespace punto_venta.Infrastructure.Persistence.Interfaces
{
    public interface ICategoryRepository
    {
        Task<BaseEntityResponse<Category>> ListCategories(BaseFiltersRequest filters);
        Task<IEnumerable<Category>> ListSelectCategories();
        Task<Category> CategoryById(int categoryId);
        Task<bool> RegisterCategory(Category category);
        Task<bool> EditCategory (Category category);
        Task<bool> RemoveCategory(int categoryId);
    }
}
