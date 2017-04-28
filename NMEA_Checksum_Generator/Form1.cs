using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMEA_Checksum_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateChecksum_Click(object sender, EventArgs e)
        {
            checksumD.Text = getChecksum(toChecksum.ToString());
        }
        private static string getChecksum(string sentence)
        {
            //Start with first Item
            int checksum = Convert.ToByte(sentence[sentence.IndexOf('$') + 1]);
            // Loop through all chars to get a checksum
            for (int i = sentence.IndexOf('$') + 2; i < sentence.IndexOf('*'); i++)
            {
                // No. XOR the checksum with this character's value
                checksum ^= Convert.ToByte(sentence[i]);
            }
            // Return the checksum formatted as a two-character hexadecimal
            return checksum.ToString("X2").ToUpper();
        }

        private static string getChecksum2(string stringToCalculateTheChecksumOver)
        {
            int checksum = 0;
            for (int i = 0; i < stringToCalculateTheChecksumOver.Length; i++)
            {
                checksum ^= Convert.ToByte(stringToCalculateTheChecksumOver[i]);
            }
            // Return the checksum formatted as a two-character hexadecimal
            return checksum.ToString("X2");
        }
    }
}
