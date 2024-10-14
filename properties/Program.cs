namespace properties
{

    public class Computer
    {
        // Properties for the base class Computer
        public string Processor { get; set; }
        public int RamSize { get; set; }
        public int HardDiskSize { get; set; }
        public int GraphicCard { get; set; }
    }

    public class Desktop : Computer
    {
        // Properties specific to Desktop
        public int MonitorSize { get; set; }
        public int PowerSupplyVolt { get; set; }
        public double DesktopPriceCalculation()
        {
            int processorCost = GetProcessorCost();
            double price = processorCost + (RamSize * 200) + (HardDiskSize * 1500) +
                           (GraphicCard * 2500) + (MonitorSize * 250) + (PowerSupplyVolt * 20);
            return price;
        }

        private int GetProcessorCost()
        {
            switch (Processor)
            {
                case "i3": return 1500;
                case "i5": return 3000;
                case "i7": return 4500;
                default: return 0;
            }
        }
    }

    public class Laptop : Computer
    {
        public int DisplaySize { get; set; }
        public int BatteryVolt { get; set; }

        public double LaptopPriceCalculation()
        {
            int processorCost = GetProcessorCost();
            double price = processorCost + (RamSize * 200) + (HardDiskSize * 1500) +
                           (GraphicCard * 2500) + (DisplaySize * 250) + (BatteryVolt * 20);
            return price;
        }
        private int GetProcessorCost()
        {
            switch (Processor)
            {
                case "i3": return 2500;
                case "i5": return 5000;
                case "i7": return 6500;
                default: return 0; 
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Desktop");
            Console.WriteLine("2. Laptop");
            Console.Write("Choose the option: ");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Desktop desktop = new Desktop();

                Console.Write("Enter the processor (i3, i5, i7): ");
                desktop.Processor = Console.ReadLine();

                Console.Write("Enter the ram size (GB): ");
                desktop.RamSize = int.Parse(Console.ReadLine());

                Console.Write("Enter the hard disk size (TB): ");
                desktop.HardDiskSize = int.Parse(Console.ReadLine());

                Console.Write("Enter the graphic card size (GB): ");
                desktop.GraphicCard = int.Parse(Console.ReadLine());

                Console.Write("Enter the monitor size (inch): ");
                desktop.MonitorSize = int.Parse(Console.ReadLine());

                Console.Write("Enter the power supply volt: ");
                desktop.PowerSupplyVolt = int.Parse(Console.ReadLine());

                double desktopPrice = desktop.DesktopPriceCalculation();
                Console.WriteLine($"Desktop price is {desktopPrice}");
            }
            else if (option == 2)
            {
                Laptop laptop = new Laptop();

                Console.Write("Enter the processor (i3, i5, i7): ");
                laptop.Processor = Console.ReadLine();

                Console.Write("Enter the ram size (GB): ");
                laptop.RamSize = int.Parse(Console.ReadLine());

                Console.Write("Enter the hard disk size (TB): ");
                laptop.HardDiskSize = int.Parse(Console.ReadLine());

                Console.Write("Enter the graphic card size (GB): ");
                laptop.GraphicCard = int.Parse(Console.ReadLine());

                Console.Write("Enter the display size (inch): ");
                laptop.DisplaySize = int.Parse(Console.ReadLine());

                Console.Write("Enter the battery volt: ");
                laptop.BatteryVolt = int.Parse(Console.ReadLine());

                double laptopPrice = laptop.LaptopPriceCalculation();
                Console.WriteLine($"Laptop price is {laptopPrice}");
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
        }
    }
}
