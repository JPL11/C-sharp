using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4Question3MagicSquareGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            int size = (int)numericUpDown1.Value;
            magicSquare(size);
            printSquare(magicSquare(size), size);
        }

        static int[,] magicSquare(int n)
        {
            int[,] arr = new int[n, n];

            if (n % 2 == 0)
            {
                int i, j;
                // filling matrix with its count
                // value starting from 1;
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        arr[i, j] = (n * i) + j + 1;
                    }
                }

                // change value of Array elements
                // at fix location as per rule
                // (n*n+1)-arr[i][j]
                // Top Left corner of Matrix
                // (order (n/4)*(n/4))
                for (i = 0; i < n / 4; i++)
                {
                    for (j = 0; j < n / 4; j++)
                    {
                        arr[i, j] = (n * n + 1) - arr[i, j];
                    }
                }

                // Top Right corner of Matrix
                // (order (n/4)*(n/4))
                for (i = 0; i < n / 4; i++)
                {
                    for (j = 3 * (n / 4); j < n; j++)
                    {
                        arr[i, j] = (n * n + 1) - arr[i, j];
                    }
                }

                // Bottom Left corner of Matrix
                // (order (n/4)*(n/4))
                for (i = 3 * n / 4; i < n; i++)
                {
                    for (j = 0; j < n / 4; j++)
                    {
                        arr[i, j] = (n * n + 1) - arr[i, j];
                    }
                }

                // Bottom Right corner of Matrix
                // (order (n/4)*(n/4))
                for (i = 3 * n / 4; i < n; i++)
                {
                    for (j = 3 * n / 4; j < n; j++)
                    {
                        arr[i, j] = (n * n + 1) - arr[i, j];
                    }
                }

                // Centre of Matrix (order (n/2)*(n/2))
                for (i = n / 4; i < 3 * n / 4; i++)
                {
                    for (j = n / 4; j < 3 * n / 4; j++)
                    {
                        arr[i, j] = (n * n + 1) - arr[i, j];
                    }
                }
            }
            else
            {
                int i = n / 2;
                int j = n - 1;

                // One by one put all values in magic square
                for (int num = 1; num <= n * n;)
                {
                    if (i == -1 && j == n) // 3rd condition
                    {
                        j = n - 2;
                        i = 0;
                    }
                    else
                    {
                        // 1st condition helper if next number
                        // goes to out of square's right side
                        if (j == n)
                            j = 0;

                        // 1st condition helper if next number is
                        // goes to out of square's upper side
                        if (i < 0)
                            i = n - 1;
                    }

                    // 2nd condition
                    if (arr[i, j] != 0)
                    {
                        j -= 2;
                        i++;
                        continue;
                    }
                    else
                        // set number
                        arr[i, j] = num++;

                    // 1st condition
                    j++;
                    i--;
                }
            }
            return arr;
        }

        private void printSquare(int[,] arr, int size)
        {
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.Clear(Color.White);
            for (int i = 0; i < size; i++)
            {   
                for (int j = 0; j < size; j++)
                {
                    int xPos = 40 * i + 20;
                    int yPos = 40 * j + 40;
                    Rectangle rect = new Rectangle(xPos,yPos, 40, 40);
                    formGraphics.FillRectangle(new SolidBrush(Color.Green), rect);
                    formGraphics.DrawRectangle(new Pen(Color.Black, 3), rect);
                    formGraphics.DrawString(arr[i, j].ToString(), new Font("Arial", 16), new SolidBrush(Color.Black), xPos-2, yPos+10);
                }
            }
        }
    }
}
