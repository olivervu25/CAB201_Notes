using System;

namespace Week7_samples
{
    class Map
    {
        protected string Title = "A Map";
        protected string DistanceAlgorithmName = "Euclidian Distance";

        public void DisplayInfo()
        {
            Console.WriteLine($"Title {Title}");
            
            Console.WriteLine($"Distance algorithm {DistanceAlgorithmName}");
        }

    }

    class CityMap : Map
    {
        public CityMap()
        {
            // Modify the protected fileds
            Title = "City Map";
            DistanceAlgorithmName = "Manhattan Distance"; 
        }
    }

    class WorldMap : Map
    {
        public WorldMap()
        {
            // Modify the protected fileds
            Title = "World Map";
            DistanceAlgorithmName = "Great-circle Distance";

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Map basicMap = new Map();
            basicMap.DisplayInfo();

            CityMap cityMap = new CityMap();
            cityMap.DisplayInfo();

            WorldMap worldMap = new WorldMap();
            worldMap.DisplayInfo();

            //Console.WriteLine(basicMap.Title); 
        }

    }
}
