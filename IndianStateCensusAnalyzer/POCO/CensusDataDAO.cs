namespace IndianStateCensusAnalyzer.POCO
{
    public class CensusDataDAO
    {
        public string state;
        public string population;
        public string area;
        public string density;

        public CensusDataDAO(string state, string population, string area, string density)
        {
            this.state = state;
            this.population = population;
            this.area = area;
            this.density = density;
        }
    }
}
