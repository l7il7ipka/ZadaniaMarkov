using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateArray_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            ArrayOne.Text = "";
            ArrayTwo.Text = "";
            ArrayRezult.Text = "";
            int[] arr1 = new int[10];
            int[] arr2 = new int[17];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rnd1.Next(-7, 9);
            }
            Array.Sort(arr1);
            for (int i = 0; i < arr1.Length; i++)
            {
                ArrayOne.Text += String.Format("{0,5}", arr1[i]);
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = rnd2.Next(-10, 11);
            }
            Array.Sort(arr2);
            Array.Reverse(arr2);
            for (int i = 0; i < arr2.Length; i++)
            {
                ArrayTwo.Text += String.Format("{0,5}", arr2[i]);
            }
            ArrayOne.Visible = true;
            ArrayTwo.Visible = true;
            textBox2.Visible = true;
            Dictionary<int, bool> dict = new Dictionary<int, bool>();
            List<int> uniqueList = new List<int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                if (!dict.ContainsKey(arr1[i]))
                {
                    dict[arr1[i]] = true;
                }
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                if (!dict.ContainsKey(arr2[i]))
                {
                    uniqueList.Add(arr2[i]);
                    dict[arr2[i]] = true;
                }
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                if (!dict[arr1[i]])
                {
                    uniqueList.Add(arr1[i]);
                    dict[arr1[i]] = true;
                }
            }
            int[] resultArr = uniqueList.ToArray();
            for (int i = 0; i < resultArr.Length; i++)
            {
                ArrayRezult.Text += String.Format("{0,5}", resultArr[i]);
            }
            ArrayRezult.Visible = true;
        }
    }
}
