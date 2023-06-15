
namespace Singleton
{
    class World
    {
        private static World? world;
        public int population;

        private World(int population)
        {
            this.population = population;
        }

        public static World GetInstance()
        {
            if (world == null)
            {
                world = new(0);
            }

            return world;
        }
    }

    class Singleton
    {
        public static void Execute()
        {

        }
    }
}