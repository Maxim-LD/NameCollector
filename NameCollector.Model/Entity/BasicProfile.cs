using System;

namespace NameCollector.Model.Entity
{
    public class BasicProfile
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public int Length { get; set; }
        public int Breadth { get; set; }
    }
}
