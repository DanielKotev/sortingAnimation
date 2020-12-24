using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sortingAnimation
{

    public class BubbleSort
    {
        Form1 form = new Form1();
        public const int num_values = 10;
        public static int[] Numbers = new int[num_values];

        public static Color[] colors = new Color[]
        {
            Color.Blue,
            Color.Red,
        };

        public static void paint(PictureBox label_pic)
        {
            int wid = label_pic.ClientSize.Width / num_values;
            for (int i = 0; i < num_values; i++)
            {
                // Make a label to be the histogram.
                Label label_hist = new Label();
                label_hist.Parent = label_pic;
                if (i == Form1.j ||
                    Form1.j + 1 == i &&
                    i!=Form1.j)
                {
                    label_hist.BackColor = colors[1];
                }
                //else if (Form1.j==num_values)
                //{
                //    label_hist.BackColor = colors[0];
                //}
                else
                {
                    label_hist.BackColor = colors[0];
                }

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
        public static void Sort(int[] array, ref int j)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {

                for (; j < array.Length - i - 1;)
                {

                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }

                    break;
                }
                if (j == array.Length)
                    j = 0;

            }
        }
    }
}
