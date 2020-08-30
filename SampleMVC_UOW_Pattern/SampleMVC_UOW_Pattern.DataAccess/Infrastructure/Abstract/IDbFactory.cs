namespace SampleMVC_UOW_Pattern.DataAccess.Infrastructure
{
    public interface IDbFactory
    {
        NorthwindDB_SampleEntities InitNorthwindDb { get; }
    }
}