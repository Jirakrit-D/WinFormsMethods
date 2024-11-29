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
            MessageBox.Show("�Թ�յ�͹�Ѻ", "��������ͺ������ǹ���");
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
            //���� "�ӹǳBMI"
            //input �Ѻ��� Textbox
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

            //Process �ӹǳ��� BMI
            //double bmi = weight / Math.Pow(height / 100, 2);
            double bmi = BMI(height, weight);
            //Output �ż� �¹Ӥ�� BMI ����º����ҵðҹ
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
                MessageBox.Show("��͡���������١��ͧ", "�Դ��ͼԴ��Ҵ");
                return false;
            }
            return true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
