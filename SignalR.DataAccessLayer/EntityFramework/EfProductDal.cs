using SignalRApi;

namespace SignalR.DataAccessLayer;

public class EfProductDal : GenericRepository<Product>, IProductDal
{
    public EfProductDal(SignalRContext context) : base(context)
    {
    }
}
