using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CSGO_Coordinates
{
    public partial class CSGOCoords : Form
    {
        public CSGOCoords()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            X1textbox.Text = X1textbox.Text.Replace(".", System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            X1textbox.Text = X1textbox.Text.Replace(",", System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            Y1textbox.Text = Y1textbox.Text.Replace(".", System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            Y1textbox.Text = Y1textbox.Text.Replace(",", System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            Z1textbox.Text = Z1textbox.Text.Replace(".", System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            Z1textbox.Text = Z1textbox.Text.Replace(",", System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            X1textbox.Text = Regex.Replace(X1textbox.Text, "[^0-9.,-]", "");
            Y1textbox.Text = Regex.Replace(Y1textbox.Text, "[^0-9.,-]", "");
            Z1textbox.Text = Regex.Replace(Z1textbox.Text, "[^0-9.,-]", "");

            X2textbox.Text = Convert.ToString(Convert.ToDouble(Y1textbox.Text) * -1 * 100);

            Y2textbox.Text = Convert.ToString(Convert.ToDouble(Z1textbox.Text) * -1 * 100);

            Z2textbox.Text = Convert.ToString(Convert.ToDouble(X1textbox.Text) * 100);

            X2textbox.Text = X2textbox.Text.Replace(",", ".");
            Y2textbox.Text = Y2textbox.Text.Replace(",", ".");
            Z2textbox.Text = Z2textbox.Text.Replace(",", ".");

            string copy;
            copy = "Adobe After Effects 8.0 Keyframe Data\r\n";
            copy = copy + "\r\n";
            copy = copy + "Transform	Position\r\n";
            copy = copy + "	Frame	X pixels	Y pixels	Z pixels	\r\n";
            copy = copy + string.Format("		{0}	{1}	{2}	\r\n", X2textbox.Text, Y2textbox.Text, Z2textbox.Text);
            copy = copy + "\r\n";
            copy = copy + "\r\n";
            copy = copy + "End of Keyframe Data";
            Clipboard.SetText(copy);
        }

        private void X1textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}
