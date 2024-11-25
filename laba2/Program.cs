using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public abstract class JewelryItem
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Complexity { get; set; }

        public abstract double CalculatePrice();
    }

    // Конкретні класи для золотих виробів
    public class GoldEarrings : JewelryItem
    {
        public override double CalculatePrice()
        {
            return Weight * 70 + Complexity * 35;
        }
    }

    public class GoldRing : JewelryItem
    {
        public override double CalculatePrice()
        {
            return Weight * 60 + Complexity * 25;
        }
    }

    public class GoldBracelet : JewelryItem
    {
        public override double CalculatePrice()
        {
            return Weight * 80 + Complexity * 40;
        }
    }

    public class GoldPendant : JewelryItem
    {
        public override double CalculatePrice()
        {
            return Weight * 65 + Complexity * 30;
        }
    }

    public class GoldChain : JewelryItem
    {
        public override double CalculatePrice()
        {
            return Weight * 75 + Complexity * 35;
        }
    }

    // Конкретні класи для срібних виробів
    public class SilverEarrings : JewelryItem
    {
        public override double CalculatePrice()
        {
            return Weight * 35 + Complexity * 15;
        }
    }

    public class SilverRing : JewelryItem
    {
        public override double CalculatePrice()
        {
            return Weight * 27 + Complexity * 12;
        }
    }

    public class SilverBracelet : JewelryItem
    {
        public override double CalculatePrice()
        {
            return Weight * 40 + Complexity * 18;
        }
    }

    public class SilverPendant : JewelryItem
    {
        public override double CalculatePrice()
        {
            return Weight * 30 + Complexity * 14;
        }
    }

    public class SilverChain : JewelryItem
    {
        public override double CalculatePrice()
        {
            return Weight * 35 + Complexity * 16;
        }
    }

    // Абстрактна фабрика
    public abstract class JewelryFactory
    {
        public abstract JewelryItem CreateEarrings();
        public abstract JewelryItem CreateRing();
        public abstract JewelryItem CreateBracelet();
        public abstract JewelryItem CreatePendant();
        public abstract JewelryItem CreateChain();
    }

    // Конкретна фабрика для золота
    public class GoldJewelryFactory : JewelryFactory
    {
        public override JewelryItem CreateEarrings()
        {
            return new GoldEarrings() { Name = "Gold Earrings", Weight = 8, Complexity = 3 };
        }

        public override JewelryItem CreateRing()
        {
            return new GoldRing() { Name = "Gold Ring", Weight = 6, Complexity = 2 };
        }

        public override JewelryItem CreateBracelet()
        {
            return new GoldBracelet() { Name = "Gold Bracelet", Weight = 10, Complexity = 4 };
        }

        public override JewelryItem CreatePendant()
        {
            return new GoldPendant() { Name = "Gold Pendant", Weight = 7, Complexity = 2.5 };
        }

        public override JewelryItem CreateChain()
        {
            return new GoldChain() { Name = "Gold Chain", Weight = 12, Complexity = 3.5 };
        }
    }

    // Конкретна фабрика для срібла
    public class SilverJewelryFactory : JewelryFactory
    {
        public override JewelryItem CreateEarrings()
        {
            return new SilverEarrings() { Name = "Silver Earrings", Weight = 8, Complexity = 3 };
        }

        public override JewelryItem CreateRing()
        {
            return new SilverRing() { Name = "Silver Ring", Weight = 7, Complexity = 2 };
        }

        public override JewelryItem CreateBracelet()
        {
            return new SilverBracelet() { Name = "Silver Bracelet", Weight = 10, Complexity = 4 };
        }

        public override JewelryItem CreatePendant()
        {
            return new SilverPendant() { Name = "Silver Pendant", Weight = 7, Complexity = 2.5 };
        }

        public override JewelryItem CreateChain()
        {
            return new SilverChain() { Name = "Silver Chain", Weight = 12, Complexity = 3.5 };
        }
    }

}
