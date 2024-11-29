namespace WinFormsMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ยินดีต้อนรับ", "โปรแกรมทดสอบความอ้วนผอม");
            clearForm();
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            txtAge.TextAlign = HorizontalAlignment.Right;
            txtHeight.TextAlign = HorizontalAlignment.Right;
            txtWeight.TextAlign = HorizontalAlignment.Right;
            txtName.Text = "";
            txtAge.Text = "0";
            txtWeight.Text = "0";
            txtHeight.Text = "0";
            txtName.Focus();

        }

        private void InputDataValid(TextBox name, TextBox age)
        {
            if (name.Text.Length != 0)
            {
                name.ForeColor = Color.Red;
            }
            else
            {
                name.ForeColor = Color.Black;
            }
            if (Convert.ToInt32(age.Text) > 0)
            {
                age.ForeColor = Color.Cyan;
            }
            else
            {
                age.ForeColor = Color.Black;
            }
        }



        private void btnBMI_Click(object sender, EventArgs e)
        {
            //ปุ่ม "คำนวณBMI"
            //input รับค่า Textbox
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            //double height = Convert.ToDouble(txtHeight.Text);

            /* if (!double.TryParse(txtHeight.Text, out height))
             {
                 return;
             }
             //double weight = Convert.ToDouble(txtWeight.Text);
             if (double.TryParse(txtWeight.Text, out weight)) 
             {
                 return;
             }*/
            double height = 0;
            double weight = 0;
            if (CheckDouble(txtWeight, txtHeight))
            {
                height = Convert.ToInt32(txtWeight.Text);
                weight = Convert.ToInt32(txtWeight.Text);
            }

            //Process คำนวณค่า BMI
            //double bmi = weight / Math.Pow(height / 100, 2);
            double bmi = BMI(height, weight);
            //Output แปลผล โดยนำค่า BMI มาเทียบค่ามาตรฐาน
            lblReslt.Text = bmi.ToString("0.00");
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            InputDataValid(txtName, txtAge);
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            InputDataValid(txtName, txtAge);
        }

        private double BMI(double h, double w)
        {
            double bmi = w / Math.Pow(h / 100, 2);
            return bmi;
        }

        private bool CheckDouble(TextBox txtW, TextBox txtH)
        {
            double w = 0;
            double h = 0;

            if ((double.TryParse(txtW.Text, out w) == false)
                || double.TryParse(txtH.Text, out h) == false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
                return false;
            }
            return true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
