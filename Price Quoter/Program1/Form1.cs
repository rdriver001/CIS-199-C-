// Program 1
// CS-199-50
// By: Raeshawn Driver
// Due date: 9/26/2024
/*
 * Program is a windows form that calculates takes in multiple parameters
 * to calculate a repair cost for a car.
 */

namespace Program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string clientName, carType;
            int workHours = 0, staffAssigned = 0, isSeniorCitizen = 0;
            double partsCost = 0;
            double seniorDiscount = .1;
            int consultationFee = 100;
            int laborCharge = 75;

            //Assigns inputs to variables
            clientName = clientNameBox.Text;
            carType = carTypeBox.Text;
            workHours = int.Parse(workHoursBox.Text);
            partsCost = double.Parse(partCostBox.Text);
            staffAssigned = int.Parse(staffBox.Text);
            isSeniorCitizen = int.Parse(seniorBox.Text);

            //Caculates total cost and then discount
            double totalCost = consultationFee + (laborCharge * workHours * staffAssigned) + partsCost;
            totalCost = totalCost - (totalCost * seniorDiscount * isSeniorCitizen);

            //Displays total with currency format
            costBox.Text = totalCost.ToString("C");
            
        }

    }
}
