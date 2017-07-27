using System;

namespace Admiral.Api
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }        

        public string Address { get; set; }
        public Member()
        {
            Id = 1;
            Name ="Ashok";
            Address = "Gurgaon";
        }
    }
}
