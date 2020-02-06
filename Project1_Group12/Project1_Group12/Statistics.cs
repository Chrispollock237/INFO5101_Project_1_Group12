using System.Collections.Generic;

namespace Project1_Group12
{
    /// <summary>
    /// Class Statistics
    /// </summary>
    public class Statistics
    {
        // Properties
        // Not sure about this... it feels like he wants all cities stored here
        private Dictionary<string, CityInfo> CityCatalogue;
        //private List<Dictionary<string, CityInfo>> cityCatalogue;

        // Ctor
        public Statistics(string filename, string filetype)
        {
            CityCatalogue = DataModeler.ParseFile(filename, filetype);
        }

        // Methods
        // City
        // DisplayCityInformation
        public CityInfo DisplayCityInformation(string cityname)
        {
            // Find city in dictionary, return it
            return new CityInfo();
        }

        // Find largest population in a province
        public double DisplayLargestPopulationCity(string province)
        {
            // compare populations and return largest
            return 0.0;
        }

        // Find smallest population in a province
        public double DisplaySmallestPopulationCity(string province)
        {
            // compare populations and return largest
            return 0.0;
        }

        // Compares population between two cities
        public CityInfo CompareCitiesPopulation(CityInfo cityA, CityInfo cityB)
        {
            // compare population, return
            return new CityInfo();
        }

        // BONUS METHOD
        public void ShowCityOnMap (CityInfo city)
        {
            // open map api to show city
        }

        public double CalculateDistanceBetweenCities(CityInfo cityA, CityInfo cityB)
        {
            // Use google geocoding and return distance
            return 0.0;
        }

        // Province Methods
        // Returns total population in province
        public double DisplayProvincePopulation(string provname)
        {
            // go through dictionary and sum population for that province
            return 0.0;
        }

        // Returns all cities in prov
        public List<CityInfo> DisplayProvinceCities(string provname)
        {
            // go through dictionary and returns a List of all cities in that prov
            return new List<CityInfo>();
        }

        // Ranks each province by population
        public string RankProvincesByPopulation()
        {
            // calls DisplayProvincePopulation on each prov
            // returns rank as string?
            return "";
        }

        public string RankProvincesByCities()
        {
            // calculate which province has more cities
            // return as string?
            return "";
        }
    }
}
