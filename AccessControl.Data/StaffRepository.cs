using AccessControl.Domain.Entities;
using AccessControl.EF;

namespace AccessControl.Data
{
    public class StaffRepository : GenericRepository<Staff>
    {
        private DemoContext Context;

        public StaffRepository(DemoContext Context):base(Context) 
        {
            this.Context = Context;
        }
        
    }
}