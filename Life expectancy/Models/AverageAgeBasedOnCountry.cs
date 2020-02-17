namespace Life_expectancy.Models
{
   public class AverageAgeBasedOnCountry
    {
        public int Id { get;}
        public string CountyName { get;}
        public double AverageAgeInCounty { get;}

        public AverageAgeBasedOnCountry()
        {

        }

        public AverageAgeBasedOnCountry(int id, string countryName, double averageAge)
        {
            Id = id;
            CountyName = countryName;
            AverageAgeInCounty = averageAge;
        }
    }
}
