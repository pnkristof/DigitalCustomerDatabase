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

        // mellbőség
        public int Bust { get; set; }
        // derékbőség
        public int Waistline { get; set; }
        // csípőbőség
        public int Hip { get; set; }
        // külsőhossz
        public int OuterLength { get; set; }
        // belsőhossz
        public int InnerLength { get; set; }
        // ujjhossz
        public int SleeveLength { get; set; }
        // egészhossz
        public int FullLength { get; set; }
        // hátszélesség
        public int BackWidth { get; set; }
        // vállszélesség
        public int ShoulderWidth { get; set; }
        // combbőség
        public int ThighCircumference { get; set; }
        // térdbőség
        public int KneeCircumference { get; set; }
        // aljabőség
        public int Aljaboseg { get; set; }
        // térdmagas
        public int KneeHeight { get; set; }
        // hasbőség
        public int AbdomenCircumference { get; set; }
        // karbőség
        public int ArmCircumference { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
