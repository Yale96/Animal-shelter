using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DierenAsiel
{
    public partial class Form1 : Form
    {
        public Shelter shelter;
        public Form1()
        {
            InitializeComponent();
            shelter = new Shelter();
        }

        private void comboBoxAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxAnimals.SelectedIndex == 0)
            {
                lblInformation.Visible = false;
                tbInformation.Visible = false;

                lblRegNumber.Visible = true;
                tbRegNumber.Visible = true;
                lblName.Visible = true;
                tbName.Visible = true;
                lblPrice.Visible = true;
                tbPrice.Visible = true;
                lblDateOfBirth.Visible = true;
                dtpDateOfBirth.Visible = true;
                lblLastWalkDate.Visible = true;
                dtpLastWalkDate.Visible = true;
            }
            if(comboBoxAnimals.SelectedIndex == 1)
            {
                lblLastWalkDate.Visible = false;
                dtpLastWalkDate.Visible = false;

                lblInformation.Visible = true;
                tbInformation.Visible = true;
                lblRegNumber.Visible = true;
                tbRegNumber.Visible = true;
                lblName.Visible = true;
                tbName.Visible = true;
                lblPrice.Visible = true;
                tbPrice.Visible = true;
                lblDateOfBirth.Visible = true;
                dtpDateOfBirth.Visible = true;
            }
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            listBoxReservedAnimals.Items.Clear();
            listBoxUnreservedAnimals.Items.Clear();

            Date birthDay = new Date(dtpDateOfBirth.Value.Day, dtpDateOfBirth.Value.Month, dtpDateOfBirth.Value.Year);

            int regNumber;
            int price;

            Int32.TryParse(tbRegNumber.Text, out regNumber);
            Int32.TryParse(tbPrice.Text, out price);
            if(comboBoxAnimals.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an animal");
            }

            else if (comboBoxAnimals.SelectedIndex == 0) //Dog is selected
            {
                Date lastWalked = new Date(dtpLastWalkDate.Value.Day, dtpLastWalkDate.Value.Month, dtpLastWalkDate.Value.Year);

                Animal dog = new Dog(regNumber, tbName.Text, price, birthDay, lastWalked);
                shelter.Add(dog);
            }
            else if(comboBoxAnimals.SelectedIndex == 1)//Cat is selected
            {
                Animal cat = new Cat(regNumber, tbName.Text, price, birthDay, tbInformation.Text);
                shelter.Add(cat);
            }
           
            foreach (Animal animalToAdd in shelter.Animals)
            {
                listBoxUnreservedAnimals.Items.Add(animalToAdd);
            }

            UpdateForm();
        }

        private void UpdateForm()
        {
            tbName.Clear();
            tbPrice.Clear();
            tbRegNumber.Clear();
            tbInformation.Clear();

            comboBoxAnimals.SelectedIndex = -1;

            Refresh();
        }
    }
}
