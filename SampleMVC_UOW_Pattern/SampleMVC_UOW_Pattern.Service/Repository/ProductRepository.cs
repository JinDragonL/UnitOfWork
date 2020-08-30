using SampleMVC_UOW_Pattern.DataAccess;
using SampleMVC_UOW_Pattern.DataAccess.Infrastructure;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;

namespace SampleMVC_UOW_Pattern.Service.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public List<GetListAllProduct_Result> GetAllData(int page, int pageSize, ref int total)
        {
            var totalRow = new ObjectParameter("totalRow", total);
            var lsData = InitNorthwindDb.GetListAllProduct(page, pageSize, totalRow).ToList();
            total = (int)totalRow.Value;

            return lsData;
        }


    }
}
