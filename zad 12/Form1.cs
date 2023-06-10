using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateArray_Click(object sender, EventArgs e)
        {
            TextArray.Text = "";
            ChangedArray.Text = "";
            Random rnd = new Random();
            int n = 20;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-10, 11);
                TextArray.Text += String.Format("{0,5}", array[i]);
            }
            TextArray.Visible = true;
            textBox2.Visible = true;
            int m = n;
            int k = 0;
            int l = 0;
            for (int i = 0; i < n; i++)
            {
                int min = ArrayMin(array, k, m);
                int h = ArrayCount(array, k, m);
                int temp = 0;
                if (l % 2 == 0)
                {
                    temp = array[k];
                    array[k] = min;
                    array[h] = temp;
                    k++;
                }
                else
                {
                    temp = array[m-1];
                    array[m-1] = min;
                    array[h] = temp;
                    m--;
                }
                l++;
            }
            for (int i = 0; i < n; i++)
            {
                ChangedArray.Text += String.Format("{0,5}", array[i]);
            }
            ChangedArray.Visible = true;
        }
        public int ArrayMin(int[] arr, int n, int m)
        {
            int mini = arr[n];
            for (int i = n; i < m; i++)
            {
                if (arr[i] < mini)
                    mini = arr[i];
            }
            return mini;
        }
        public int ArrayCount(int[] arr, int n, int m)
        {
            int k = n;
            int mini = arr[n];
            for (int i = n; i < m; i++)
            {
                if (arr[i] < mini)
                {
                    mini = arr[i];
                    k = i;
                }
            }
            return k;
        }
    }
}
