using SignalR.EntityLayer;

namespace SignalR.DataAccessLayer;

public class EfContactDal : GenericRepository<Contact>, IContactDal
{
    public EfContactDal(SignalRContext context) : base(context)
    {
    }
}
