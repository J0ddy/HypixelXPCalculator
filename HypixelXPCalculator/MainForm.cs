namespace HypixelXPCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string? ExpType;
        private string? Type;

        private void OpenError(string message)
        {
            MessageBox.Show(message,"Oops!",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void ShowResult(double[] result)
        {
            panelResult_Icons.Show();
            if (Type == "daily")
            {
                /** enable 3,4
                 * Total XP Needed
                 * Days Needed
                 */

                lblResult3.Text = "Total XP Needed: " + result[0].ToString("N0");
                lblResult4.Text = "Days Needed: " + result[1].ToString("N1");

            } else if (Type == "booster")
            {
                /** enable all
                 * 1-6 60k-110k
                 * Total XP Needed
                 */
                lblResult1.Text = "60k Players Online - " + result[0].ToString("N0")+" Boosters";
                lblResult2.Text = "70k Players Online - " + result[1].ToString("N0") + " Boosters";
                lblResult3.Text = "80k Players Online - " + result[2].ToString("N0") + " Boosters";
                lblResult4.Text = "90k Players Online - " + result[3].ToString("N0") + " Boosters";
                lblResult5.Text = "100k Players Online - " + result[4].ToString("N0") + " Boosters";
                lblResult6.Text = "110k Players Online - " + result[5].ToString("N0") + " Boosters";
                lblResult7.Text = "Total XP Needed: " + result[6].ToString("N0");
            }
            else OpenError("An unknown error occurred.\nPlease report this to the developer. (0)");
        }

        private void btnTypeEXP_Click(object sender, EventArgs e)
        {
            ExpDialog expDialog = new ExpDialog();
            expDialog.ShowDialog();
            this.ExpType = expDialog.Type();
            expDialog.Dispose();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ExpType == null)
            {
                OpenError("You need to select a EXP Type!");
                return;
            }

            Level currentLevel = new Level(decimal.ToInt64(numLevelCurrent.Value),"level");
            Level goalLevel = new Level(decimal.ToInt64(numLevelGoal.Value),"level");
            double expDifference = goalLevel.EXP - currentLevel.EXP;
            if (ExpType.Contains(':'))
            {
                Type = "daily";
                int expPerDay = int.Parse(ExpType.Split(':').ToArray()[1]);
                double days = Math.Round(expDifference / expPerDay, 2);
                ShowResult(new []{ expDifference, days });
            }

            else if (ExpType == "booster")
            {
                Type = "booster";
                double[] result =
                {
                    Math.Ceiling(expDifference/740000),
                    Math.Ceiling(expDifference/1070000),
                    Math.Ceiling(expDifference/1400000),
                    Math.Ceiling(expDifference/1730000),
                    Math.Ceiling(expDifference/2060000),
                    Math.Ceiling(expDifference/2400000),
                    expDifference
                };
                ShowResult(result);
            }

            else OpenError("An unknown error occurred.\nPlease report this to the developer. (1)");
        }
    }
}