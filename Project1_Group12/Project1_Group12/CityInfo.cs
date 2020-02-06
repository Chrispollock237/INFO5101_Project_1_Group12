namespace Project1_Group12
{
    /// <summary>
    /// Class CityInfo
    /// </summary>
    public class CityInfo
    {
        // Properties
        public string CityID { get; set; }
        public string CityName { get; set; }
        public string CityAscii { get; set; }
        public int Population { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        // Ctors


        // Methods
        // Get the province of the city
        public string GetProvince()
        {
            // REPLACE THIS
            return "";
        }

        // Get the Population of the city
        public int GetPopulation()
        {
            // REPLACE THIS
            return Population;
        }

        // Get the Location of the city
        public string GetLocation ()
        {
            // REPLACE THIS
            return $"Lat: {Latitude}, Long: {Longitude}";
        }
    }
}
