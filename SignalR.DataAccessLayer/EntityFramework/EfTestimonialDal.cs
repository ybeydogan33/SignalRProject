using SignalR.EntityLayer;

namespace SignalR.DataAccessLayer;

public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
{
    public EfTestimonialDal(SignalRContext context) : base(context)
    {
    }
}
