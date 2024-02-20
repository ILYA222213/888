using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxWidth.Text, out int width) &&
                int.TryParse(textBoxHeight.Text, out int height))
            {
                int area;
                int perimeter;

                GetRectangleData(width, height, out area, out perimeter);

                MessageBox.Show($"Площадь прямоугольника: {area}\nПериметр прямоугольника: {perimeter}");
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения для ширины и высоты!");
            }
        }

        void GetRectangleData(int width, int height, out int rectArea, out int rectPerimeter)
        {
            rectArea = width * height;
            rectPerimeter = (width + height) * 2;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

