using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GatesCandyStore_PruittRon
{
    public partial class MainCandyStore : Form
    {
        public List<Order> orderList;
        private const string defaultValue = "nothing";
        private CandyForm candyForm;

        public MainCandyStore()
        {
            InitializeComponent();
            orderList = new List<Order>();
        }

        public string DefaultSelectionValue { get { return defaultValue; } }
        public string NameInputTextbox { get { return nameInputTextbox.Text; } }

        private void candyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCandyResultLabel.Text = candyComboBox.Text;
        }

        private void ClearValues()
        {
            foreach (var order in orderList)
            {
                if (order.Status == OrderStatus.InActive)
                {
                    order.Price = 0;
                    order.Quantity = 0;
                    order.CandyItem.Flavor = defaultValue;
                }
            }
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            ClearValues();
            foreach (var order in orderList)
            {
                switch (order?.CandyItem?.CandyType)
                {
                    case CandyType.Lollipop:
                        mainLollipopSelectionQuantityResultLabel.Text = order.Quantity.ToString();
                        mainLollipopSelectionPriceResultLabel.Text = order.Price.ToString("C");
                        mainLollipopSelectionResultLabel.Text = order.CandyItem.Flavor;
                        mainlollipopTotalLabel.Text = order.Total.ToString("C");
                        break;

                    case CandyType.Gum:
                        mainGumSelectionQuantityResultLabel.Text = order.Quantity.ToString();
                        mainGumSelectionPriceResultLabel.Text = order.Price.ToString("C");
                        mainGumSelectionResultLabel.Text = order.CandyItem.Flavor;
                        mainGumTotalLabel.Text = order.Total.ToString("C");
                        break;

                    case CandyType.Chocolate:
                        mainChocolateSelectionQuantityResultLabel.Text = order.Quantity.ToString();
                        mainChocolateSelectionPriceResultLabel.Text = order.Price.ToString("C");
                        mainChocolateSelectionResultLabel.Text = order.CandyItem.Flavor;
                        mainChocolateTotalLabel.Text = order.Total.ToString("C");
                        break;
                }
            }

            //Removed cleared orders
            RemoveInactiveOrders();

            //Calculate order total for all candy types
            decimal total = (from or in orderList select or.Total).Sum();
            mainOrderTotalLabel.Text = total.ToString("C");
        }

        private void MainCandyStore_Load(object sender, EventArgs e)
        {
            candyComboBox.DataSource = Enum.GetValues(typeof(CandyType));
            mainLollipopSelectionResultLabel.Text = defaultValue;
            mainGumSelectionResultLabel.Text = defaultValue;
            mainChocolateSelectionResultLabel.Text = defaultValue;
            candyComboBox.SelectedIndex = -1;
        }

        private void processSelectionButton_Click(object sender, EventArgs e)
        {
            var selectedCandy = candyComboBox.SelectedItem;
            switch (selectedCandy)
            {
                case CandyType.Lollipop:
                    candyForm = new CandyForm(this, CandyType.Lollipop, typeof(LollipopFlavor), 1.99M);
                    candyForm.Show();
                    candyForm.FormClosed += new FormClosedEventHandler(Form_Closed);
                    break;

                case CandyType.Chocolate:
                    candyForm = new CandyForm(this, CandyType.Chocolate, typeof(ChocolateFlavor), 2.99M);
                    candyForm.Show();
                    candyForm.FormClosed += new FormClosedEventHandler(Form_Closed);
                    break;

                case CandyType.Gum:
                    candyForm = new CandyForm(this, CandyType.Gum, typeof(GumFlavor), .99M);
                    candyForm.Show();
                    candyForm.FormClosed += new FormClosedEventHandler(Form_Closed);
                    break;

                default:
                    break;
            }
        }

        private void RemoveInactiveOrders()
        {
            orderList.RemoveAll(x => x.Status == OrderStatus.InActive);
        }
    }
}