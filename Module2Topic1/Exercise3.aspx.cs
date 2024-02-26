using System;

namespace Module1Exercise1
{
    public partial class Exercise3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Initialize the text value of the finalGrade label
            finalGrade.Text = "Submit your grade percentage to see your final grade!";
        }

        protected void CalculateFinalGrade_Click(object sender, EventArgs e)
        {
            // Parse the percentage grade input
            if (int.TryParse(percentageGrade.Text, out int num))
            {
                // Determine the final grade based on the percentage
                string result = CalculateFinalGrade(num);

                // Display the final grade
                finalGrade.Text = result;

                // Show a congratulatory message for outstanding performance
                if (result == "You have a final grade of 1.00")
                {
                    Response.Write("<script>alert('Congratulations! You are outstanding!')</script>");
                }
            }
            else
            {
                // Handle invalid input
                finalGrade.Text = "Invalid input. Please enter a valid percentage.";
            }
        }

        private string CalculateFinalGrade(int percentage)
        {
            // Determine the final grade based on the percentage
            if (percentage >= 96)
            {
                return "You have a final grade of 1.00";
            }
            else if (percentage >= 91.5)
            {
                return "1.25";
            }
            else if (percentage >= 87)
            {
                return "1.5";
            }
            else if (percentage >= 82.5)
            {
                return "1.75";
            }
            else if (percentage >= 78)
            {
                return "2.00";
            }
            else if (percentage >= 73.5)
            {
                return "2.25";
            }
            else if (percentage >= 69)
            {
                return "2.50";
            }
            else if (percentage >= 64.5)
            {
                return "2.75";
            }
            else if (percentage >= 60)
            {
                return "3.00";
            }
            else
            {
                return "5.00";
            }
        }

        protected void PercentageGrade_TextChanged(object sender, EventArgs e)
        {
            // Additional handling for when the percentageGrade TextBox value changes
        }
    }
}
