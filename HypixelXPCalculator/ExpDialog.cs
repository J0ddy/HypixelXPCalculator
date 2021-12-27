using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HypixelXPCalculator
{
    public partial class ExpDialog : Form
    {
        public ExpDialog()
        {
            InitializeComponent();
        }

        private string? _type;

        private void btnTypeBooster_Click(object sender, EventArgs e)
        {
            _type = "booster";
            this.Close();
        }

        private void btnTypeDaily_Click(object sender, EventArgs e)
        {
            if (btnTypeDaily.Text == "Daily - Submit")
            {
                _type = "daily:" + numDailyExp.Value;
                this.Close();
            }
            else {
                btnTypeDaily.Text = "Daily - Submit";
                numDailyExp.Show();
                numDailyExp.Focus();
            }
        }
        public string? Type() => this._type;
        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
