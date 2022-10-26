using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Star
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcbutton_Click(object sender, EventArgs e)
        {
            int? rows = Getrows();

            if(rows.HasValue==false)
            {
                MessageBox.Show("請輸入列數");
                return;
            }
            else if(rows.Value<=0||rows.Value>10)
            {
                MessageBox.Show("列數必須是1~10之間");
                return;
            }

            string stars = GenerateStarsL(rows.Value)+GenerateStarsF(rows.Value)+ GenerateStarsR(rows.Value);

              showTextBox.Text=stars;
        }
        private string GenerateStarsL(int rows)
        {
            string result =string.Empty;
            for(int i = 1; i <= rows; i++)
            {
                result+=new string('*', i)+"\r\n";
            }
            return result;

        }
        private string GenerateStarsF(int rows)
        {
            string result = string.Empty;

            for (int t = 1; t <= rows; t++)
            {
                string space = new string(' ', rows - t);
                string stars = new string('*', 2 * t-1);

                result+= space + stars+"\r\n";
            }
            return result;
        }
        private string GenerateStarsR(int rows)
        {
            string result = string.Empty;
            for( int v = 1; v <= rows; v++)
            {
                string space = new string(' ', rows - v);
                string stars = new string('*', v- 1);

                result += space + stars + "\r\n";
            }
            return result;
        }

            private int?Getrows()
        {
            string input=inputTextBox.Text;
            bool isInt=int.TryParse(input, out int rows);
            if (isInt) { return rows; }
            else { return null; }

        }

    }
}
