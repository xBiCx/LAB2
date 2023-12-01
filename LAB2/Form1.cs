namespace LAB2
{
    public partial class Form1 : Form
    {
        int arrayIndex = 0;
        int arraySum = 0;
        //create array
        string[] arrName = new string[1000];
        string[] arrID = new string[1000];
        int[] arrScore = new int[1000];
        double maxNumber;
        double minNumber;


        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //get input data from textbox
            string inputID = tbInputId.Text;
            string inputName = tbInputName.Text;
            string inputScore = tbInputScore.Text;
            //add data to array
            arrID[arrayIndex] = inputID;
            arrName[arrayIndex] = inputName;
            arrScore[arrayIndex] = int.Parse(inputScore);
            //index
            arrayIndex++;
            arraySum += int.Parse(inputScore);
            tbInputId.Text = "";
            tbInputName.Text = "";
            tbInputScore.Text = "";

            maxNumber = arrScore.Max();
            int i = int.Parse(inputScore);
            int x = int.Parse(inputScore);

            if (i >= maxNumber)
            {
                maxNumber = i;
                tbidmax.Text = inputID;
                tbnamemax.Text = inputName;
                tbscoremax.Text = inputScore;

            }


            minNumber = maxNumber;
            for (int k = 0; k < arrayIndex; k++)
            {
                if (arrScore[k] < minNumber)
                {
                    minNumber = arrScore[k];
                }
            }
            if (x <= minNumber)
            {
                minNumber = x;
                tbidmin.Text = inputID;
                tbnamemin.Text = inputName;
                tbscoremin.Text = inputScore;

            }
            double sum = (arraySum / arrayIndex);
            allsum.Text = sum.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbidmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void allsum_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbInputScore_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
