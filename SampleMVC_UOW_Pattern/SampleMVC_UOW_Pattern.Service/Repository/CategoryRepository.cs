using SampleMVC_UOW_Pattern.DataAccess;
using SampleMVC_UOW_Pattern.DataAccess.Infrastructure;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;

namespace SampleMVC_UOW_Pattern.Service.Repository
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public List<GetListAllCategory_Result> GetAllData(int page, int pageSize, ref int total)
        {
            var totalRow = new ObjectParameter("totalRow", total);
            var lsData = InitNorthwindDb.GetListAllCategory(page, pageSize, totalRow).ToList();
            total = (int)totalRow.Value;

            return lsData;
        }

        public bool CreateUpdate(Category obj)
        {
            //do something
            base.Add(obj);
            base.Update(obj);

            base.SaveChange();

            return true;
        }
    }
}
