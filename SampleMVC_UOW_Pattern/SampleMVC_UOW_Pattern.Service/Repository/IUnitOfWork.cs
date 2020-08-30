namespace SampleMVC_UOW_Pattern.Service.Repository
{
    public interface IUnitOfWork
    {
        ICategoryRepository CategoryRepository { get; }
        IProductRepository ProductRepository { get; }
    }
}