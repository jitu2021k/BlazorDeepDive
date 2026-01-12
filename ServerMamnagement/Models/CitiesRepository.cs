namespace ServerMamnagement.Models
{
    public static class CitiesRepository
    {
        public static List<string> GetCities() {

            List<string> cities = new() { "Toronto",
                "Montreal",
                "Ottawa",
                "Calgary",
                "Halifax"};

            return cities;
        } 
    }
}
