using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text,
                    placeNumberValue.Text,
                    prizeAmountValue.Text,
                    prizePercentageValue.Text);

                foreach (IDataConnection connection in GlobalConfig.Connections)
                {
                    connection.CreatePrize(model);
                }

                // reset textboxes
                placeNumberValue.Text = "";
                placeNameValue.Text = "";
                prizeAmountValue.Text = "0.00";
                prizePercentageValue.Text = "0";
            }
            else
            {
                MessageBox.Show("Form validation has failed.");
            }

        }

        private bool IsValidForm()
        {
            bool isValid = true;

            int placeNumber = 0;
            decimal prizeAmount = 0;
            double prizePercentage = 0;
            bool isValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);
            bool isValidAmount = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool isValidPerc = double.TryParse(prizeAmountValue.Text, out prizePercentage) && 
                                double.Parse(prizeAmountValue.Text) > 0 &&
                                double.Parse(prizeAmountValue.Text) <= 100;


            if (!isValidNumber)
            {
                isValid = false; 
            }
            if (placeNumber < 1)
            {
                isValid = false;
            }
            if (String.IsNullOrEmpty(placeNameValue.Text))
            {
                isValid = false;
            }
            if (!isValidAmount)
            {
                isValid = false;
            }
            if (!isValidPerc)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
