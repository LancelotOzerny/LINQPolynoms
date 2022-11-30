using System;
using System.Collections;
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
        
        // Критерий выборки (элемент < 50, любой или > 50)
        enum WhereCrytery { Less50 = -1, Nothing = 0, MoreEqual50 = 1 };
        WhereCrytery critery = WhereCrytery.Nothing;

        // Сортировка - прямая, никакая или обратная
        enum Sorting { Ascending, Nothing, Descending }
        Sorting sort;

        // Сортировка - прямая, никакая или обратная
        bool grouping;

        public Form1()
        {
            InitializeComponent();

            // Ставим случайный X
            xCoeff = rand.Next(1, 5);
            label_xValue.Text = $"X = {xCoeff}";
        }

        /// <summary>
        /// Метод, который позволяет реализовать добавление случайного полинома
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            label_allDataCount.Text = $"Элементов: {listbox_polinomsData.Items.Count}";
        }

        /// <summary>
        /// МетодЮ которйы пощволяет очистить все данные
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            polynomials.Clear();
            listbox_filtredData.Items.Clear();
            listbox_polinomsData.Items.Clear();
        }

        /// <summary>
        /// Метод, который позволяет сменить критерий выборки на <50, >=50, любые
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (critery == WhereCrytery.Less50)
            {
                critery = WhereCrytery.Nothing;
            }

            else if (critery == WhereCrytery.Nothing)
            {
                critery = WhereCrytery.MoreEqual50;
            }

            else
            {
                critery = WhereCrytery.Less50;
            }

            SetQuery();
        }

        /// <summary>
        /// Метод, который позволяет реализовать выборку
        /// </summary>
        private void SetQuery()
        {
            listbox_filtredData.Items.Clear();
            IEnumerable<LINQPolinoms.Polynomial> result = from polynom in polynomials select polynom;

            result = WhereQuery(result);

            foreach (var polynom in result)
            {
                listbox_filtredData.Items.Add($"{polynom.ToString()} ({polynom.GetResult(xCoeff)})");
            }

            label_filtredDataCount.Text = $"Элементов: {listbox_filtredData.Items.Count}";
        }

        /// <summary>
        /// Метод, который позволяет реализовать критерий
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private IEnumerable<LINQPolinoms.Polynomial> WhereQuery(IEnumerable<LINQPolinoms.Polynomial> data)
        {
            if (critery == WhereCrytery.Less50)
            {
                data = from field in data where field.GetResult(xCoeff) < 50 select field;
                btn_critery.Text = "Результат < 50";
            }

            else if (critery == WhereCrytery.MoreEqual50)
            {
                data = from field in data where field.GetResult(xCoeff) >= 50 select field;
                btn_critery.Text = "Результат >= 50";
            }

            else
            {
                data = from field in data select field;
                btn_critery.Text = "Результат не важен";
            }

            return data;
        }
    }
}