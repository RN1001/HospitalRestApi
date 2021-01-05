namespace HospitalRestApi.Models
{
    public class Nurse : Employee
    {
        public Nurse()
        {

        }

        public Nurse(int id, string firstname, string lastname)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
        }

    }
}