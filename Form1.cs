namespace Advanced
{
    public partial class Form1 : Form
    {

        private double num1 = 0;
        private string operation = "";
        private bool isOperationClicked = false;
        private double memory = 0;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.ControlBox = true;

            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;        
            // this.KeyDown += Form1_KeyDown

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btn_nine_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            if (textBox1_display.Text == "0" || isOperationClicked)
                textBox1_display.Text = btn.Text;
            else
                textBox1_display.Text += btn.Text;

            isOperationClicked = false;

        }
        private void btn_eight_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (textBox1_display.Text == "0" || isOperationClicked)
                textBox1_display.Text = btn.Text;
            else
                textBox1_display.Text += btn.Text;

            isOperationClicked = false;
        }
        private void btn_seven_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            if (textBox1_display.Text == "0" || isOperationClicked)
                textBox1_display.Text = btn.Text;
            else
                textBox1_display.Text += btn.Text;

            isOperationClicked = false;
        }

        private void btn_four_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            if (textBox1_display.Text == "0" || isOperationClicked)
                textBox1_display.Text = btn.Text;
            else
                textBox1_display.Text += btn.Text;

            isOperationClicked = false;
        }

        private void btn_fivw_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            if (textBox1_display.Text == "0" || isOperationClicked)
                textBox1_display.Text = btn.Text;
            else
                textBox1_display.Text += btn.Text;

            isOperationClicked = false;
        }

        private void btn_six_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            if (textBox1_display.Text == "0" || isOperationClicked)
                textBox1_display.Text = btn.Text;
            else
                textBox1_display.Text += btn.Text;

            isOperationClicked = false;
        }

        private void btn_Three_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            if (textBox1_display.Text == "0" || isOperationClicked)
                textBox1_display.Text = btn.Text;
            else
                textBox1_display.Text += btn.Text;

            isOperationClicked = false;
        }

        private void btn_two_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            if (textBox1_display.Text == "0" || isOperationClicked)
                textBox1_display.Text = btn.Text;
            else
                textBox1_display.Text += btn.Text;

            isOperationClicked = false;
        }

        private void btn_One_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            if (textBox1_display.Text == "0" || isOperationClicked)
                textBox1_display.Text = btn.Text;
            else
                textBox1_display.Text += btn.Text;

            isOperationClicked = false;
        }

        private void btn_Zero_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            if (textBox1_display.Text == "0" || isOperationClicked)
                textBox1_display.Text = btn.Text;
            else
                textBox1_display.Text += btn.Text;

            isOperationClicked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e) => SetOperation("+");
        private void btn_Multiply_Click(object sender, EventArgs e) => SetOperation("*");
        private void btn_MMinus_Click(object sender, EventArgs e) => SetOperation("-");
        // private void btn_division_Click1(object sender, EventArgs e) => SetOperation("/");
        private void btn_division_Click_1(object sender, EventArgs e)
        {
            SetOperation("/");
        }
        private void SetOperation(string op)
        {
            num1 = double.Parse(textBox1_display.Text);
            operation = op;
            isOperationClicked = true;
        }

        private void btn_Equals_Click(object sender, EventArgs e)
        {
            double num2 = double.Parse(textBox1_display.Text);
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;

                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }
                    result = num1 / num2;
                    break;
                case "%":
                    result = num1 % num2;
                    break;
            }
            textBox1_display.Text = result.ToString();
            isOperationClicked |= true;

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            textBox1_display.Text = "0";
            num1 = 0;
            operation = "";
            isOperationClicked = false;

        }

        private void btn_dot_Click(object sender, EventArgs e)
        {

            if (!textBox1_display.Text.Contains("."))
                textBox1_display.Text += ".";

        }

        private void btn_Sin_Click(object sender, EventArgs e) => ApplyScientific(Math.Sin);
        private void btn_Cos_Click(object sender, EventArgs e) => ApplyScientific(Math.Cos);
        private void btn_tan_Click(object sender, EventArgs e) => ApplyScientific(Math.Tan);
        private void btn_log_Click(object sender, EventArgs e) => ApplyScientific(Math.Log10);



        private void ApplyScientific(Func<double, double> func)
        {
            double value = double.Parse(textBox1_display.Text);
            textBox1_display.Text = func(value).ToString();
        }

        private void btn_MC_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void btn_mr_Click(object sender, EventArgs e)
        {
            textBox1_display.Text = memory.ToString();
        }

        private void btn_MPlus_Click(object sender, EventArgs e)
        {
            memory += double.Parse(textBox1_display.Text);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btn_Equals.PerformClick();
                e.Handled = true;
            }

        }
    }
}
