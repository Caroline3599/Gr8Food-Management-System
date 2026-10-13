using System;
using System.Linq;
using System.Windows.Forms;

namespace IOOP_Manager
{
    public partial class FeedbackResponse : Form
    {
        public FeedbackResponse()
        {
            InitializeComponent();
            btnM3Up.Text = "Update";
        }

        // Constructor #2: for updating existing Feedback record
        public FeedbackResponse(Feedback feedback)
        {
            InitializeComponent();
            btnM3Up.Text = "Update Feedback";

            //tbFID.Text = feedback.FeedbackID.ToString();
            //tbFOID.Text = feedback.OrderID.HasValue ? feedback.OrderID.Value.ToString() : "";
            //tbFText.Text = feedback.Text;
            labelFID.Text = feedback.FeedbackID.ToString();
            labelOID.Text = feedback.OrderID.HasValue ? feedback.OrderID.Value.ToString() : "";
            labelText.Text = feedback.Text;

            tbFResponse.Text = feedback.Response;
            labelMID.Text = feedback.ManagerID.HasValue ? feedback.ManagerID.Value.ToString() : "";

            // ResponseDate is nullable, so check before assigning
            if (feedback.ResponseDate.HasValue)
            {
                dtpFDate.Value = feedback.ResponseDate.Value;
            }
            else
            {
                dtpFDate.Value = DateTime.Now; // fallback if null
            }
        }

        private void btnM3Up_Click(object sender, EventArgs e)
        {
            {
                string responseText = tbFResponse.Text.Trim();

                // 1. check if empty
                if (string.IsNullOrEmpty(responseText))
                {
                    MessageBox.Show("Response cannot be empty. Please enter valid text.");
                    return;
                }

                // 2. check if too short (less than 2 characters)
                if (responseText.Length < 2)
                {
                    MessageBox.Show("Response is too short. Please enter more than one character.");
                    return;
                }

                // 4. other rules: for example, only allow letters and numbers
                if (!responseText.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("Response contains invalid characters. Please use only letters and numbers.");
                    return;
                }

                // if all checks passed, proceed to update the feedback response
                Feedback feedback = new Feedback(
                    int.Parse(labelFID.Text),                // FeedbackID
                    labelText.Text,                          // Text (feedback content)
                    int.Parse(labelMID.Text),                // ManagerID
                    responseText,                            // Response (manager reply)
                    dtpFDate.Value,                          // ResponseDate
                    int.Parse(labelOID.Text)                 // OrderID
                );
                feedback.FeedbackResponse();
                MessageBox.Show("Feedback Response Updated");
                this.Close();
            }
        }

        private void btnM3Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FeedbackResponse_Load(object sender, EventArgs e)
        {

        }
    }
}
