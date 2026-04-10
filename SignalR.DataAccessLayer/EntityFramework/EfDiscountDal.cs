using SignalRApi;

namespace SignalR.DataAccessLayer;

public class EfDiscountDal : GenericRepository<Discount>, IDiscountDal
{
    public EfDiscountDal(SignalRContext context) : base(context)
    {
    }
}
