using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slot_Machine_Simulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int IMAGES = 5;
        const int SPINS = 3;
        decimal betAmount = 0.0m;
        decimal betTotal = 0.0m;
        decimal winTotal = 0.0m; 

        private void SpinButton_Click(object sender, EventArgs e)
        {
            bool parsed = ParseOK(ref betAmount);

            if (parsed)
            {
                SpinImages(ref betAmount, IMAGES, SPINS); 
            }

            else
            {
                MessageBox.Show("Error. Please enter a numerical value only.");
            }
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            TotalBetOutput.Text = "Total amount bet: "+betTotal.ToString("c");
            TotalWinOutput.Text = "Total amount won: "+winTotal.ToString("c"); 
            ResultPanel.Visible = true;
        }


        private bool ParseOK(ref decimal betAmount)
        {
            bool parseOK = false;

            if (decimal.TryParse(AmountInput.Text, out betAmount))
            { 
                parseOK = true;
            }

            return parseOK; 
        }


        private void SpinImages(ref decimal betAmount, int IMAGES, int SPINS)
        {
            int[] results = new int[IMAGES]; 

            Random rand = new Random();
            int index = 0; 

            while (index<SPINS)
            { 
                int randomSpin = rand.Next(0, IMAGES); 
                results[index] = randomSpin;
                index++; 
            }

            pictureBox1.Image = imageList1.Images[results[0]];
            pictureBox2.Image = imageList1.Images[results[1]];
            pictureBox3.Image = imageList1.Images[results[2]];
            betTotal = betAmount+betTotal;

            GetResults(ref betAmount, ref winTotal, results); 
        }


        private void GetResults(ref decimal betAmount, ref decimal winTotal, int[]results)
        {
            int matches = 0;
            
            
            if (results[0] == results[1] && results[1] == results[2])
            {
                matches = 2;
            }
            else if (results[0] == results[1])
            {
                matches = 1;
            }
            else if (results[0] == results[2])
            {
                matches = 1;
            } 
            else if (results[1] == results[2])
            {
                matches = 1; 
            }

            switch (matches)
            {
                case 1:
                    
                    decimal win1 = 0; 
                    win1 += (matches * betAmount);
                    winTotal += win1;
                    WinningsOutput.Text = "+" + win1.ToString("c") + " !!!";
                    WinningsOutput.Visible = true; 
                    break;
                case 2:
                    
                    decimal win2 = 0;
                    win2 += (matches * betAmount);
                    winTotal += win2;
                    WinningsOutput.Text = "+" + win2.ToString("c")+" !!!";
                    WinningsOutput.Visible = true; 
                    break;
                default:
                    WinningsOutput.Visible = false;
                    break; 
            }
      }


    }

}