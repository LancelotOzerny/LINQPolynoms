using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQPolinoms
{
    public partial class Form1 : Form
    {
        // Список всех полиномов
        List<Polynomial> polynomials = new List<Polynomial>();
        Random rand = new Random();

        int xCoeff;

        public Form1()
        {
            InitializeComponent();

            xCoeff = rand.Next(1, 5);
            MessageBox.Show($"Так как изучается LINQ, то под x (для выборки) подставим значение x = { xCoeff }");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Polynomial addedPolynomal = new Polynomial(100);

            int elements_count = rand.Next(1, 5);

            for (int i = 0; i < elements_count; ++i)
            {
                int pow = rand.Next(0, 20);
                addedPolynomal.SetCoefficient(pow, i);
            }

            polynomials.Add(addedPolynomal);
            listbox_polinomsData.Items.Add($"{ addedPolynomal.ToString() } ({addedPolynomal.GetResult(xCoeff)})");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            polynomials.Clear();
            listbox_filtredData.Items.Clear();
            listbox_polinomsData.Items.Clear();
        }
    }
}
