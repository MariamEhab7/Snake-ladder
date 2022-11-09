namespace ladderSnakeGame
{
    public partial class Form1 : Form
    {
        bool red = false, yellow = false;
        int x = 11, y = 418, value, p = 0, flag = 0, bx = 11, by = 418, q = 0;

        public Form1()
        {
            InitializeComponent();
        }        
        private void Form1_Load(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                button2.Enabled = false;
            }
            pictureBox3.Image = Image.FromFile(@"C:\Users\Acer-\source\repos\ladderSnakeGame\Resources\dice.png");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            value = rule.rollDice(pictureBox3);
            label2.Text = value.ToString();

            if (label2.Text == "6" && red == false) // player enters game cell
            {
                pictureBox4.Visible = true;
                pictureBox1.Visible = false;
                red = true;
                pictureBox4.Location = new Point(x, y);
                //label3.Text = x.ToString();
                //label5.Text = y.ToString();
                label8.Text = p.ToString();
                p++;
            }

            if (red == true)
            {
                p = rule.move(ref x, ref y, value, p, pictureBox4, label8);
            }

            if (p == 100)
            {
                MessageBox.Show(" Winner !! ");
                button1.Enabled = false;
            }

            p = rule.snake(ref x, ref y, p, pictureBox4);
            p = rule.ladder(ref x, ref y, p, pictureBox4);

            label8.Text = p.ToString();

            if (value == 6)
            {
                flag = 0;
            }
            else
            {
                flag = 1;
                button1.Enabled = false;
                button2.Enabled = true;
            }

        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            value = rule.rollDice(pictureBox3);
            label2.Text = value.ToString();
            
            if (yellow == true)
            {
                q = rule.move(ref bx, ref by, value, q, pictureBox5, label9);
            }
            if (label2.Text == "6" && yellow == false) // player enters game cell
            {
                pictureBox5.Visible = true;
                pictureBox2.Visible = false;
                yellow = true;
                pictureBox5.Location = new Point(x, y);
                //label3.Text = x.ToString();
                //label5.Text = y.ToString();
                label9.Text = q.ToString();
                q++;
            }

            if (q == 100)
            {
                MessageBox.Show(" Winner !! ");
                button2.Enabled = false;
            }

            q = rule.snake(ref bx, ref by, q, pictureBox5);
            q = rule.ladder(ref bx, ref by, q, pictureBox5);

            label9.Text = q.ToString();

            if (value == 6)
            {
                flag = 1;
            }
            else
            {
                flag = 0;
                button1.Enabled = true;
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e) // Red
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}