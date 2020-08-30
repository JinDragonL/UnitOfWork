using SampleMVC_UOW_Pattern.DataAccess;
using System.Collections.Generic;

namespace SampleMVC_UOW_Pattern.Service.Repository
{
    public interface IProductRepository
    {
        List<GetListAllProduct_Result> GetAllData(int page, int pageSize, ref int total);
    }
}