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
        enum Sorting { Ascending = -1, Nothing = 0, Descending = 1 }
        Sorting sorting;

        // Сортировка - прямая, никакая или обратная
        bool grouping;





        // LINQ -  КРИТЕРИЙ, СОРТИРОВКА, ГРУППИРОВКА 





        /// <summary>
        /// Метод, который позволяет реализовать выборку
        /// </summary>
        private void SetQuery()
        {
            // Очищаем все данные из listbox
            listbox_filtredData.Items.Clear();

            // выбираем все данные
            IEnumerable<LINQPolinoms.Polynomial> result = from polynom in polynomials select polynom;

            // Выборка + сортировка + Группировка
            result = WhereQuery(result);
            result = SortQuery(result);

            // (Если группировка есть - то вывод уже другой)
            if (grouping)
            {
                var gouped = from field in result group field by (int)(field.GetResult(xCoeff) / 10); // Группируем по 10 чисел (по десяткам)

                foreach (var polynomsGroup in gouped)
                {
                    foreach (var polynom in polynomsGroup)
                    {
                        listbox_filtredData.Items.Add($"{polynom.ToString()} ({polynom.GetResult(xCoeff)})");
                    }
                    listbox_filtredData.Items.Add("");
                }

                btn_group.Text = "Разгруппировать";
            }
            else
            {
                // Выводим данные на listbox
                foreach (var polynom in result)
                {
                    listbox_filtredData.Items.Add($"{polynom.ToString()} ({polynom.GetResult(xCoeff)})");
                }
            }
            // Выводим кол-во элементов
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
            }
            else if (critery == WhereCrytery.MoreEqual50)
            {
                data = from field in data where field.GetResult(xCoeff) >= 50 select field;
            }

            return data;
        }

        /// <summary>
        /// Метод, который позволяет реализовать сортировку данных
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private IEnumerable<LINQPolinoms.Polynomial> SortQuery(IEnumerable<LINQPolinoms.Polynomial> data)
        {
            if (sorting == Sorting.Ascending)
            {
                data = from field in data orderby field.GetResult(xCoeff) ascending select field;
            }
            else if (sorting == Sorting.Descending)
            {
                data = from field in data orderby field.GetResult(xCoeff) descending select field;
            }

            return data;
        }



        // ФОРМА И НАЖАТИ НА КНОПКИ



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
        /// МетодЮ который пощволяет очистить все данные
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clear_Click(object sender, EventArgs e)
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
        private void btn_critery_Click(object sender, EventArgs e)
        {
            if (critery == WhereCrytery.Less50)
            {
                critery = WhereCrytery.Nothing;
                btn_critery.Text = "Результат не важен";
            }

            else if (critery == WhereCrytery.Nothing)
            {
                critery = WhereCrytery.MoreEqual50;
                btn_critery.Text = "Результат >= 50";
            }

            else
            {
                critery = WhereCrytery.Less50;
                btn_critery.Text = "Результат < 50";
            }

            SetQuery();
        }

        /// <summary>
        /// Метод, который позволяет установить сортировку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_sort_Click(object sender, EventArgs e)
        {
            if (sorting == Sorting.Ascending)
            {
                sorting = Sorting.Nothing;
                btn_sort.Text = "Без сортировки";
            }

            else if (sorting == Sorting.Nothing)
            {
                sorting = Sorting.Descending;
                btn_sort.Text = "По убыванию";
            }

            else
            {
                sorting = Sorting.Ascending;
                btn_sort.Text = "По возрастанию";
            }

            SetQuery();
        }

        /// <summary>
        /// Метод, который позволяет включить группировку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_group_Click(object sender, EventArgs e)
        {
            btn_group.Text = "Сгруппировать";
            grouping = !grouping;
            SetQuery();
        }
    }
}