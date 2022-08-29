namespace EX3_Q3_Mortgage
{
    public partial class Mortgage : Form
    {
        public Mortgage()
        {
            InitializeComponent();
        }
        static double emi_calculator(double p,
                             double r, double t)
        {
            double emi;

            r = r / (12 * 100); // one month interest
            t = t * 12; // one month period
            emi = (p * r * Math.Pow(1 + r, t))
                   / (Math.Pow(1 + r, t) - 1);

            return (emi);
        }
        
    
          
            private void PrincipalBox_TextChanged(object sender, EventArgs e)
            {
          
            }

            private void RateBox_TextChanged(object sender, EventArgs e)
            {
           
            }

            private void TimeBox_TextChanged(object sender, EventArgs e)
            {
      

            }

            private void MonthlyInstallments_Click(object sender, EventArgs e)
            {
            double principal, rate, time, MonthlyInstallments; 
            var sourcePrincipal = PrincipalBox.Text;
            double.TryParse(sourcePrincipal, out principal);
            var sourceRate = RateBox.Text;
            double.TryParse(sourceRate, out rate);
            var sourceTime = TimeBox.Text;
            double.TryParse(sourceTime, out time);
            MonthlyInstallments = emi_calculator(principal, rate, time);
            var EMI = (MonthlyInstallments).ToString();
            MessageBox.Show("The monthly EMI is = " + EMI);
            }
            
    } 
}