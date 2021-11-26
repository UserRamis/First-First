namespace LAB
{
    class Building : Creation
    {
        private double high;
        private int storeys;
        private int aparts;
        private int entrances;

        static int indexer = 0;

        public Building()
        {
            index = indexer++;
        }

        public Building(double high, int storeys, int aparts, int entrances)
        {
            index = indexer++;
            this.high = high;
            this.storeys = storeys;
            this.aparts = aparts;
            this.entrances = entrances;
        }
    }
}