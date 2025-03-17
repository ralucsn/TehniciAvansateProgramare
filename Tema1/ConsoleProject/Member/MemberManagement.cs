using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Member
{
    public class MemberManagement: IMemberManagement
    {
        private List<IMember> _members = new();

        public void AddMember(IMember member)
        {
            _members.Add(member);
        }

        public bool ContainsMember(IMember member)
        {
            return _members.Contains(member);
        }
    }
}
