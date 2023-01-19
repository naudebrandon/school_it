/*
 * Calculate the average marks of a subject based in 2 marks.
 */

namespace ReportCard
{
    public partial class frmReportCard : Form
    {
        public frmReportCard()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        { 
            decimal mark1 = Convert.ToDecimal(edtMark1.Text);
            decimal mark2 = Convert.ToDecimal(edtMark2.Text);

            decimal avg = (mark1 + mark2) / 2; 

            lblSubject.Text = edtSubject.Text;
            lblMark1.Text = edtMark1.Text;
            lblMark2.Text = edtMark2.Text;

            lblAverage.Text = avg.ToString(); // Average Calculated

        }
    }
}
