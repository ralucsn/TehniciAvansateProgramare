using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Member
{
    public interface IMemberManagement
    {
        void AddMember(IMember member);
        bool ContainsMember(IMember member);
    }
}
