using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IVisitorRepository
    {
        // visitor-only interface
        void VisitorRegistrationInUser();
        void VisitorAuthorizationInUser();
    }
}
