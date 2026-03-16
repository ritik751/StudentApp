using System;

namespace StudentApp.Models
{
    public enum StreamType
    {
        Arts,
        Commerce,
        Science
    }

    public class Student
    {
        public string Image { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public StreamType Stream { get; set; }

        public DateTime DateOfJoining { get; set; }

        public int DueFee { get; set; }

        public int TotalFee { get; set; }
    }
}