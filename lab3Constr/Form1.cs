using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace lab3Constr
{
    public partial class Form1 : MetroForm
    {
        int[] mas = new int[30];
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            SetInitialData();
        }

        private void SetInitialData()
        {
            InitialData.Text = "";
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(100);
                InitialData.Text += mas[i] + "; ";
            }
        }

        private void SetResult()
        {
            resultData.Text = "";
            for (int i = 0; i < mas.Length; i++)
                resultData.Text += mas[i] + "; ";
        }

        private void sort1_Click(object sender, EventArgs e)
        {
            InsertionSort.insertionSort(ref mas, 0, mas.Length);
            SetResult();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SetInitialData();
        }
    }
}
