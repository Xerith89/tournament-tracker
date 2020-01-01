using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequester callingForm;
        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if (ValiateForm())
            {
                PrizeModel model = new PrizeModel(placeNumberValue.Text, placeNameValue.Text, prizeAmountValue.Text, prizePercentageValue.Text);

                GlobalConfig.Connection.CreatePrize(model);

                callingForm.PrizeComplete(model);

                this.Close();
            }
            else
                MessageBox.Show("The form has invalid data, please fix and try again.");
        }

        private bool ValiateForm()
        {
            int placeNumber = 0;
            if (!int.TryParse(placeNumberValue.Text,out placeNumber))
                return false;

            if (placeNumber < 1)
                return false;

            if (placeNameValue.Text.Length == 0)
                return false;

            decimal prizeAmount = 0;
            if (!decimal.TryParse(prizeAmountValue.Text, out prizeAmount))
                return false;

            double prizePercentage = 0;
            if (!double.TryParse(prizePercentageValue.Text, out prizePercentage))
                return false;

            if (prizeAmount <= 0 && prizePercentage <= 0)
                return false;

            if (prizePercentage < 0 || prizePercentage > 100)
                return false;

            return true;
        }
    }
}
