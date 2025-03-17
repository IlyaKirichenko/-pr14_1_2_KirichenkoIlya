using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_3
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
            Queue<int> queue = new Queue<int>();
            for (int i = 1; i <= n; i++)
            {
                queue.Enqueue(i);
            }
            string res = $"n = {n}\n";
            res+= $"Размерность стека ={queue.Count}\n";
            res += $"Верхний элемент стека = {queue.Peek()}\n";
            res +=$"Содержимое стека = {string.Join(" ", queue)}\n";
            queue.Clear();
            res+=$"Новая размерность стека = {queue.Count}";
            MessageBox.Show(res,"info");
        }
    }
}
