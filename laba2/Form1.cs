using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2
{
    public partial class Form1 : Form
    {
        private List<JewelryItem> jewelryItems = new List<JewelryItem>();
        public Form1()
        {
            InitializeComponent();
            LoadJewelryItems();
        }

        private void LoadJewelryItems()
        {
            // Завантаження виробів із золота та срібла
            JewelryFactory goldFactory = new GoldJewelryFactory();
            JewelryFactory silverFactory = new SilverJewelryFactory();

            jewelryItems.Add(goldFactory.CreateEarrings());
            jewelryItems.Add(goldFactory.CreateRing());
            jewelryItems.Add(goldFactory.CreateBracelet());
            jewelryItems.Add(goldFactory.CreateChain());
            jewelryItems.Add(goldFactory.CreatePendant());
            jewelryItems.Add(silverFactory.CreateEarrings());
            jewelryItems.Add(silverFactory.CreateRing());
            jewelryItems.Add(silverFactory.CreateBracelet());
            jewelryItems.Add(silverFactory.CreateChain());
            jewelryItems.Add(silverFactory.CreatePendant());


        }

        private void DisplayJewelryItems(string category)
        {
            listBox1.Items.Clear();
            foreach (var item in jewelryItems)
            {
                if (category == "Gold" && (item is GoldEarrings || item is GoldRing || item is GoldBracelet || item is GoldChain || item is GoldPendant))
                {
                    listBox1.Items.Add($"{item.Name} - Price: {item.CalculatePrice()}");
                }
                else if (category == "Silver" && (item is SilverEarrings || item is SilverRing || item is SilverBracelet || item is SilverChain || item is SilverPendant))
                {
                    listBox1.Items.Add($"{item.Name} - Price: {item.CalculatePrice()}");
                }
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                DisplayJewelryItems("Gold");
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                DisplayJewelryItems("Silver");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
