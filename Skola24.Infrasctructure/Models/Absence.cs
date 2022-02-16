using System;

namespace Skola24.Infrasctructure.Models
{
    public class Absence
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int AbsenceLength { get; set; }
    }
}
