
namespace AbstractFactory
{
    interface Manufacturer
    {
        public ICPU createCPU();
        public IGPU createGPU();
    }

    class Intel : Manufacturer
    {
        public ICPU createCPU()
        {
            return new IntelCPU();
        }

        public IGPU createGPU()
        {
            return new IntelGPU();
        }
    }

    class AMD : Manufacturer
    {
        public ICPU createCPU()
        {
            return new AMDCPU();
        }

        public IGPU createGPU()
        {
            return new AMDGPU();
        }
    }

    interface ICPU {}
    interface IGPU {}

    class IntelCPU : ICPU {}
    class IntelGPU : IGPU {}
    class AMDCPU : ICPU {}
    class AMDGPU : IGPU {}


    class AbstractFactory
    {
        public static void CreateComponents(Manufacturer m)
        {
            ICPU cpu = m.createCPU();
            IGPU gpu = m.createGPU();

            Console.WriteLine(cpu.GetType());
            Console.WriteLine(gpu.GetType());
        }

        public static void Execute()
        {
            CreateComponents(new Intel());
            Console.WriteLine();
            CreateComponents(new AMD());
        }
    }
}