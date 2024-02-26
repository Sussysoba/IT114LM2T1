using System;

namespace Module1Exercise1
{
    public partial class Exercise4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string resultText = $"Email: {email.Text}<br/>" +
                                    $"Age: {age.Text}<br/>" +
                                    $"Full Name: {fullName.Text}";

                result.Text = resultText;
            }
        }
    }
}
