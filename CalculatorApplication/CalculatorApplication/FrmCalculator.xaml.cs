using Microsoft.Maui.Controls;
using System;

namespace CalculatorApplication
{
    public partial class FrmCalculator : ContentPage
    {
        private CalculatorClass cal;

        public FrmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();
            cbOperator.Items.Add("Choose an Operator");
            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("*");
            cbOperator.Items.Add("/");

            txtBoxInput1.TextChanged += UpdateCalculation;
            txtBoxInput2.TextChanged += UpdateCalculation;
            cbOperator.SelectedIndexChanged += UpdateCalculation;
        }

        private void UpdateCalculation(object sender, EventArgs e)
        {
            double num1, num2;
            if (double.TryParse(txtBoxInput1.Text, out num1) && double.TryParse(txtBoxInput2.Text, out num2))
            {
                if (cbOperator.SelectedIndex > 0) // Check if an actual operator is selected
                {
                    switch (cbOperator.SelectedItem.ToString())
                    {
                        case "+":
                            lblDisplayTotal.Text = "Total: " + cal.GetSum(num1, num2).ToString();
                            break;
                        case "-":
                            lblDisplayTotal.Text = "Total: " + cal.GetDifference(num1, num2).ToString();
                            break;
                        case "*":
                            lblDisplayTotal.Text = "Total: " + cal.GetProduct(num1, num2).ToString();
                            break;
                        case "/":
                            try
                            {
                                lblDisplayTotal.Text = "Total: " + cal.GetQuotient(num1, num2).ToString();
                            }
                            catch (ArgumentException ex)
                            {
                                lblDisplayTotal.Text = ex.Message;
                            }
                            break;
                    }
                }
                else if (cbOperator.SelectedIndex == 0) // Handle the "Choose an Operator" placeholder
                {
                    lblDisplayTotal.Text = "Please select an operator";
                }
            }
            else
            {
                lblDisplayTotal.Text = "Invalid input";
            }
        }

    }
}
