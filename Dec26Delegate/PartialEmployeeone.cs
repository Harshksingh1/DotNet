using System;
namespace PartialDemo
{
    public partial class PartialEmployee{
        private string firstName;
        private string lastName;
        private double salary;
        private string gender;

        public string FirstName
        {
            get{return firstName;}
            set{firstName=value;}
        }
        public string LastName
        {
            get{return lastName;}
            set{lastName=value;}
        }
        public double Salary
        {
            get{return salary;}
            set{salary=value;}
        }
        public string Gender
        {
            get{return gender;}
            set{gender=value;}
        }
          partial void PartialMethod();

    }
}