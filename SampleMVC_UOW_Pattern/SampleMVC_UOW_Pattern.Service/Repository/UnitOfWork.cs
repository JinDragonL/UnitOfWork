using SampleMVC_UOW_Pattern.DataAccess.Infrastructure;

namespace SampleMVC_UOW_Pattern.Service.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        IDbFactory _dbFactory;
        ICategoryRepository _categoryRepository;
        IProductRepository _productRepository;

        public UnitOfWork(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public ICategoryRepository CategoryRepository
        {
            get
            {
                return _categoryRepository ?? (_categoryRepository = new CategoryRepository(_dbFactory));
            }
        }

        public IProductRepository ProductRepository
        {
            get
            {
                return _productRepository ?? (_productRepository = new ProductRepository(_dbFactory));
            }
        }
    }
}
