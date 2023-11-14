using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7Ex2
{
    public class Member
    {
        public string MemberType { get; set; }
        public string MemberName { get; set; }
        public DateTime Joindate { get; set; }
        public static int NumberofMembers { get; set; }


        public override string ToString()

        {
            return string.Format("{0}{1}{2}", MemberName, MemberType, Joindate.ToShortDateString());
        }
    }
}
