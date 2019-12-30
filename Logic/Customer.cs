using System;

namespace Logic
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Brust { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
