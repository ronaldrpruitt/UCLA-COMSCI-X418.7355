using System;
using System.Linq;
using System.Windows.Forms;

namespace GatesCandyStore_PruittRon
{
    public partial class CandyForm : Form
    {
        private readonly CandyType candyType;
        private readonly MainCandyStore mainCandyStore;
        private readonly string name;
        private readonly Order order;
        private readonly decimal price;
        private string selection;

        public CandyForm(MainCandyStore main, CandyType candyType, Type flavor, decimal price)
        {
            InitializeComponent();
            this.price = price;
            this.Text = candyType.ToString();
            this.candyType = candyType;
            candyComboBox.DataSource = Enum.GetValues(flavor);
            mainCandyStore = main;
            name = mainCandyStore.NameInputTextbox;
            candyComboBox.SelectedIndex = -1;
            this.selection = mainCandyStore.DefaultSelectionValue;

            //Repopulate form if order is existing
            order = mainCandyStore.orderList.Where(o => o.CandyItem?.CandyType == candyType).FirstOrDefault();
            if (order != null)
            {
                candyComboBox.SelectedIndex = candyComboBox.FindStringExact(order.CandyItem.Flavor.ToString());
                candyQuantityTextBox.Text = order.Quantity.ToString();
                selection = order.CandyItem.Flavor;
            }
            candyFlavorResultLabel.Text = $"{name} selected: {selection}";
            candyPriceLabel.Text = price.ToString("C");
        }

        private void lollipopClearButton_Click(object sender, EventArgs e)
        {
            //clear form fields and set order status to inactive
            var order = mainCandyStore.orderList.Where(x => x.CandyItem.CandyType == candyType).FirstOrDefault();
            if (order != null)
            {
                order.Status = OrderStatus.InActive;
            }

            candyQuantityTextBox.Text = string.Empty;
            candyComboBox.SelectedIndex = -1;
            candyFlavorResultLabel.Text = $"{name} selected: {mainCandyStore.DefaultSelectionValue}";
        }

        private void lollipopComboBox_SelectedChangeCommitted(object sender, EventArgs e)
        {
            if (candyComboBox.SelectedIndex != -1)
            {
                string selectedText = candyComboBox.SelectedItem.ToString();
                selection = selectedText;
                candyFlavorResultLabel.Text = $"{name} selected: {selection}";
            }
        }

        private void lollipopReturnButton_Click(object sender, EventArgs e)
        {
            bool hasExistingOrder = mainCandyStore.orderList.Any(a => a.CandyItem.CandyType == candyType && a.Status == OrderStatus.Active);
            if (candyComboBox.SelectedIndex != -1 && !hasExistingOrder)
            {
                int quantity;
                bool isSuccess = Int32.TryParse(candyQuantityTextBox.Text, out quantity);

                if (quantity > 0 && isSuccess)
                {
                    var order = new Order
                    {
                        CandyItem = new Candy
                        {
                            CandyType = candyType,
                            Flavor = candyComboBox.SelectedItem.ToString()
                        },
                        Quantity = quantity,
                        Price = price,
                        Status = OrderStatus.Active
                    };

                    mainCandyStore.orderList.Add(order);
                }
            }

            this.Close();
        }
    }
}