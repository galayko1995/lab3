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
        int[] Array;
        int ArrayLength;
        Random rand = new Random();
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayLength = 100;
            Array = new int[ArrayLength];
            SetInitialData();
        }

        private void SetInitialData()
        {
            InitialData.Text = "";
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = rand.Next(ArrayLength);
                InitialData.Text += Array[i] + "; ";
            }
        }

        private void SetResult()
        {
            resultData.Text = "";
            for (int i = 0; i < Array.Length; i++)
                resultData.Text += Array[i] + "; ";
        }

        private void sort1_Click(object sender, EventArgs e)
        {
            sw.Start();
            InsertionSort.insertionSort(ref Array, 0, Array.Length);
            sw.Stop();
            lblTimerCount.Text = "Sorted in " + sw.ElapsedTicks * 1000000+ "ns";
            sw.Reset();
            SetResult();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SetInitialData();
        }

        private void fastSort_Click(object sender, EventArgs e)
        {
            sw.Start();
            Qsort.quicksort(ref Array, 0, Array.Length-1);
            sw.Stop();
            lblTimerCount.Text = "Sorted in " + sw.Elapsed.TotalMilliseconds * 1000000 + "ns";
            sw.Reset();
            SetResult();
        }
    }
}
