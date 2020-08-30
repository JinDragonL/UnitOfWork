namespace SampleMVC_UOW_Pattern.DataAccess.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        public NorthwindDB_SampleEntities northwindDB;

        public NorthwindDB_SampleEntities InitNorthwindDb
        {
            get
            {
                return northwindDB ?? (northwindDB = new NorthwindDB_SampleEntities());
            }
        }

        protected override void DisposeCore()
        {
            if (northwindDB != null)
                northwindDB.Dispose();
        }
    }
}
