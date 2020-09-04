using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarShopGUI;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        Store store = new Store();

        BindingSource CarListBinding = new BindingSource();
        BindingSource ShoppingListBinding = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            SetBindings();
        }

        private void SetBindings()
        {
            CarListBinding.DataSource = store.CarList;
            listBox1.DataSource = CarListBinding;
            listBox1.DisplayMember = "Display";
            listBox1.ValueMember = "Display";

            ShoppingListBinding.DataSource = store.ShoppingList;
            listBox2.DataSource = ShoppingListBinding;
            listBox2.DisplayMember = "Display";
            listBox2.ValueMember = "Display";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void isNewLabel_Click(object sender, EventArgs e)
        {

        }

        private void bodyConditionLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createCarButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear(); // Give the error provider a fresh run each submission

            Car newCar = new Car();
            newCar.Make = makeInput.Text;
            newCar.Model = modelInput.Text;
            if(Decimal.TryParse(priceInput.Text, out decimal price))
            {
                newCar.Price = price;
            } else
            {
                errorProvider1.SetError(priceInput, "Only decimals are allowed");
                return;
            }

            // Gets the checked radio button in the group box
            var checkedButton = isNewGroupBox.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);

            // If the selected radio is "New", then the strings will be compared for equality.
            // Since it's a radio, the only other option would be "Used"
            newCar.IsNew = string.Compare(checkedButton.Text, "New") == 0;

            newCar.BodyCondition = Convert.ToInt32(bodyConditionInput.Value);

            store.CarList.Add(newCar);
   
            CarListBinding.ResetBindings(false);
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            store.ShoppingList.Add((Car)listBox1.SelectedItem);

            ShoppingListBinding.ResetBindings(false);
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            decimal total = store.Checkout();
            totalCostValueLabel.Text = total.ToString();
        }
    }
}
