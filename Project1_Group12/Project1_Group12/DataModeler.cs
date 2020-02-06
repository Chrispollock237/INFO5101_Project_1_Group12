using System.Collections.Generic;

namespace Project1_Group12
{
    /// <summary>
    /// Class DataModeler
    /// </summary>
    public class DataModeler
    {
        public delegate void Delegate(string filename);

        // Parses XML
        private static void ParseXML (string filename)
        {

        }

        // Parses JSON
        private static void ParseJSON(string filename)
        {

        }

        // Parses CSV
        private static void ParseCSV(string filename)
        {

        }

        // Parses any file by calling other functions
        public static Dictionary<string, CityInfo> ParseFile(string filename, string filetype)
        {
            Delegate del;
            if (filetype == "xml")
            {
                del = ParseXML;
                del(filename);
            }
            else if (filetype == "json")
            {
                del = ParseJSON;
                del(filename);
            }
            else
            {
                del = ParseCSV;
                del(filename);
            }

            // REPLACE THIS
            return new Dictionary<string, CityInfo>();
        }
    }
}
