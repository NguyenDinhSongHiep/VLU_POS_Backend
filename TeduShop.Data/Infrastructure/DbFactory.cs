namespace TeduShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private HeadDbContext dbContext;

        public HeadDbContext Init()
        {
            return dbContext ?? (dbContext = new HeadDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}