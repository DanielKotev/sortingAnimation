﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sortingAnimation
{
    public partial class Form1 : Form
    {
        static int j = 0;
        const int num_values = 10;
        public int[] Numbers = new int[num_values];
        public Form1()
        {
            InitializeComponent();
            label_pic.Invalidate();
            //typeof(PictureBox).InvokeMember("DoubleBuffered",
            //    BindingFlags.SetProperty |
            //    BindingFlags.Instance |
            //    BindingFlags.NonPublic,
            //    null,
            //    label_pic,
            //    new object[] { true });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void paint()
        {

        }
        private void Generate_Click(object sender, EventArgs e)
        {
            j = 0;
            label_pic.Controls.Clear();
            FormBorderStyle = FormBorderStyle.FixedDialog;

            Random rand = new Random();
           
            int wid = label_pic.ClientSize.Width / num_values;
            for (int i = 0; i < num_values; i++)
            {
                int value = rand.Next(1, 96);
                Numbers[i] = value;
                // Make a label to be the histogram.
                Label label_hist = new Label();
                label_hist.Parent = label_pic;
                label_hist.BackColor = Color.Blue;
                label_hist.BorderStyle = BorderStyle.FixedSingle;
                label_hist.Width = wid;
                label_hist.Height =
                    (int)(label_pic.ClientSize.Height * value / 100f);
                label_hist.Left = i * wid;
                label_hist.Top = label_pic.ClientSize.Height - label_hist.Height;


                // Make a label to display the value.
                Label label_value = new Label();
                label_value.Parent = label_pic;
                label_value.BackColor = Color.Transparent;
                label_value.Text = value.ToString();
                label_value.TextAlign = ContentAlignment.TopCenter;
                label_value.Left = label_hist.Left;
                label_value.Width = label_hist.Width;
                label_value.Height = 15;
                label_value.Top = label_hist.Top - label_value.Height;
            }
            label_pic.Invalidate();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            
            BubbleSort.Sort(Numbers,ref j);
            j++;
            label_pic.Controls.Clear();
            int wid = label_pic.ClientSize.Width / num_values;
            for (int i = 0; i < num_values; i++)
            {
                // Make a label to be the histogram.
                Label label_hist = new Label();
                label_hist.Parent = label_pic;
                label_hist.BackColor = Color.Blue;
                label_hist.BorderStyle = BorderStyle.FixedSingle;
                label_hist.Width = wid;
                label_hist.Height =
                    (int)(label_pic.ClientSize.Height * Numbers[i] / 100f);
                label_hist.Left = i * wid;
                label_hist.Top = label_pic.ClientSize.Height - label_hist.Height;


                // Make a label to display the value.
                Label label_value = new Label();
                label_value.Parent = label_pic;
                label_value.BackColor = Color.Transparent;
                label_value.Text = Numbers[i].ToString();
                label_value.TextAlign = ContentAlignment.TopCenter;
                label_value.Left = label_hist.Left;
                label_value.Width = label_hist.Width;
                label_value.Height = 15;
                label_value.Top = label_hist.Top - label_value.Height;
            }

        }

     
    }
}