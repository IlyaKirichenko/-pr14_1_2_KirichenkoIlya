using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDown1.Value;
            Stack<int> stack = new Stack<int>();
            int newSize = stack.Count;
            for (int i = 1; i <= n; i++)
            {
                stack.Push(i);
            }
            int nachSize = stack.Count;
            MessageBox.Show($"n = {n}\n Размерность стека = {nachSize}\n Верхний элемент стека = {stack.Peek()}\n Содержимое стека = {string.Join(" ",stack)}\n Новая размерность стека = {newSize} ");
        }
    }
}
