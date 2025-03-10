using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Задание_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string exp = textBox1.Text;
            string resMessage = BalanceSkob(exp);
            label1.Text = resMessage;
            File.WriteAllText("t.txt", exp);
        }
        private string BalanceSkob(string exp)
        {
            int balance = 0;
            for (int i = 0; i <exp.Length; i++)
            {
                if (exp[i] == '(')
                {
                    balance++;
                }
                else if (exp[i] == ')')
                {
                    balance--;
                }
                if (balance < 0)
                {
                    return $"Лишняя скобка ( в позиции : {i+1}";
                }
            }
            if (balance > 0)
            {
                return $"Лишняя скобка ) в позиции : {exp.Length}";
            }
            return "Скобки сбалансированы";
        }
       /* private string FixBalanceSkob(string exp)
        {

        }*/

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
