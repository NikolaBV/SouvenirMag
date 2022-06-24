using _11a_Souvenirs_Zadacha.Controller;
using _11a_Souvenirs_Zadacha.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11a_Souvenirs_Zadacha
{
    public partial class Form1 : Form
    {
        SouvenirController souvenirController = new SouvenirController();
        SouvenirTypeController souvenirTypeBusiness = new SouvenirTypeController();
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadRecord(Souvenir souvnir) // LoadRecord done
        {
            textBox1.BackColor = Color.White;
            textBox1.Text = souvnir.Id.ToString();
            textBox2.Text = souvnir.Name;
            textBox3.Text = souvnir.Price.ToString();
            textBox5.Text = souvnir.Description.ToString();
            comboBox1.Text = souvnir.SouvenirType.Name;
        }
        private void Form1_Load(object sender, EventArgs e) //Form load done
        {
            List<SouvenirType> allTypes = souvenirTypeBusiness.GetAllTypes();
            comboBox1.DataSource = allTypes;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            button4_Click(sender, e);
        }
        private void button1_Click(object sender, EventArgs e) //Add method done
        {
            if (textBox2.Text == "" || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Vuvedete ime!");
                return;
            }
            Souvenir souvenir = new Souvenir();
            souvenir.Name = textBox2.Text;
            souvenir.Description = textBox3.Text;
            souvenir.Price = decimal.Parse(textBox5.Text);
            souvenir.SouvenirTypeId = (int)comboBox1.SelectedValue;
            souvenirController.Add(souvenir);
            button4_Click(sender, e);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (string.IsNullOrEmpty(textBox1.Text) || !textBox1.Text.All(char.IsDigit))
            {
                MessageBox.Show("Vuvedete Id");
                textBox1.BackColor = Color.Red;
                return;
            }
            else
            {
                id = int.Parse(textBox1.Text);
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                Souvenir souvenir = souvenirController.Get(id);
                if (souvenir == null)
                {
                    MessageBox.Show("Nqma takav sovinir v bazata \n Vuvedete ID.");
                    textBox1.BackColor = Color.Red;
                    return;
                }
                LoadRecord(souvenir);
            }
            else
            {
                Souvenir souvenir2 = new Souvenir();
                souvenir2.Name = textBox2.Text;
                souvenir2.Price = decimal.Parse(textBox3.Text);
                souvenir2.Description = textBox5.Text;
                souvenir2.SouvenirTypeId = (int)comboBox1.SelectedValue;
                souvenirController.Update(id, souvenir2);
                button4_Click(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e) //Delete button done
        {
            int id = 0;
            if (string.IsNullOrEmpty(textBox1.Text) || !textBox1.Text.All(char.IsDigit))
            {
                MessageBox.Show("Vuvedete element za triene!");
                textBox1.BackColor = Color.Red;
                return;
            }
            else
            {
                id = int.Parse(textBox1.Text);
            }
            Souvenir souvenir1 = souvenirController.Get(id);
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                if (souvenir1 == null)
                {
                    MessageBox.Show("Nqma takav product v bazata \n Vuvedete ID.");
                    textBox1.BackColor = Color.Red;
                    return;
                }
            }
            LoadRecord(souvenir1);

            DialogResult delete = MessageBox.Show("Iskate li da produljite s iztrivaneto?", "Delete", MessageBoxButtons.YesNo);
            if (delete == DialogResult.Yes)
            {
                souvenirController.Delete(id);
            }
            button4_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e) //GetAll Done
        {
            List<Souvenir> souvenir = souvenirController.GetAll();
            listBox1.Items.Clear();

            foreach (var item in souvenir)
            {
                listBox1.Items.Add($"{item.Id} Ime: {item.Name} Cena: {item.Price} leva Opisanie:{item.Description} Tip: {item.SouvenirType.Name}");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
