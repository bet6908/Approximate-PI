namespace Approximate_PI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            
            double pi_over_4 = 0;
            int num_terms = int.Parse(txt_terms.Text);
            double sign = 1;

            for (int term = 0; term < num_terms; term++)
            {
                pi_over_4 += sign / (term * 2 + 1);
                sign *= -1;

            }                
            double pi = 4 * pi_over_4;
            
            lbl_terms.Text = "Approximate value of pi after " + num_terms + " terms";
            lbl_results.Text = "= " + pi.ToString();
        }
    }
}