namespace HospitalRestApi.Models
{
    public class Location : BaseEntity
    {
        public string HospitalName { get; set; }
        public string Address { get; set; }
        public int MaximumBeds { get; set; }

        public Location()
        {

        }

        public Location(string hospitalName, string address, int maxBeds)
        {
            HospitalName = hospitalName;
            Address = address;
            MaximumBeds = maxBeds;
        }

    }
}