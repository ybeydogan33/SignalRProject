using SignalRApi;

namespace SignalR.DataAccessLayer;

public class EfAboutDal : GenericRepository<About>, IAboutDal
{
    public EfAboutDal(SignalRContext context) : base(context)
    {
    }
}
