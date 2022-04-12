namespace FInal___643450070_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void updateSelectData() {
            this.textBox1.Text = this.radioButton1.Checked ? "กลางแจ้ง มีร่ม พัดลม" : "ห้องแอร์";

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.updateSelectData();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.updateSelectData();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "ชาไทย";
            if (this.textBox2.Text != "")
                        this.textBox2.Text = this.textBox2.Text + ", ";            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "วาฟเฟิลชาเขียว";
            if (this.textBox2.Text != "")
                this.textBox2.Text = this.textBox2.Text + ", ";            
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "วาฟเฟิลไอศกรีม";
            if (this.textBox2.Text != "")
                this.textBox2.Text = this.textBox2.Text + ", ";            
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "แพนเค้กกล้วยหอม";
            if (this.textBox2.Text != "")
                this.textBox2.Text = this.textBox2.Text + ", ";            
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "แพนเค้กราสป์เบอร์รี";
            if (this.textBox2.Text != "")
                this.textBox2.Text = this.textBox2.Text + ", ";
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "ฮันนี่โทสต์มะม่วง";
            if (this.textBox2.Text != "")
                this.textBox2.Text = this.textBox2.Text + ", ";
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "นมสดโอริโอ้ปั่น";
            if (this.textBox2.Text != "")
                this.textBox2.Text = this.textBox2.Text + ", ";
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "กีวีโซดา";
            if (this.textBox2.Text != "")
                this.textBox2.Text = this.textBox2.Text + ", ";
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "ส้มโซดา";
            if (this.textBox2.Text != "")
                this.textBox2.Text = this.textBox2.Text + ", ";
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "บลูฮาวายโซดา";
            if (this.textBox2.Text != "")
                this.textBox2.Text = this.textBox2.Text + ", ";
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "องุ่นโซดา";
            if (this.textBox2.Text != "")
                this.textBox2.Text = this.textBox2.Text + ", ";
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "นมสดเย็น";
            if (this.textBox2.Text != "")
                this.textBox2.Text = this.textBox2.Text + ", ";
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "โอวันติน";
            if (this.textBox2.Text != "")
                this.textBox2.Text = this.textBox2.Text + ", ";
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "มอคค่า";
            if (this.textBox2.Text != "")
                this.textBox2.Text = this.textBox2.Text + ", ";
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "คาปูชิโน่เย็น";
            if (this.textBox2.Text != "")
                this.textBox2.Text = this.textBox2.Text + ", ";
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "ลาเต้เย็น";
            if (this.textBox2.Text != "")
                this.textBox2.Text = this.textBox2.Text + ", ";
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "อเมริกาโน่เย็น";
            if (this.textBox2.Text != "")
                this.textBox2.Text = this.textBox2.Text + ", ";
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "เอสเปรสโซ่เย็น";
            if (this.textBox2.Text != "")
                this.textBox2.Text = this.textBox2.Text + ", ";
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "น้ำผึ้งมะนาว"; 
            if (this.textBox2.Text != "")
                this.textBox2.Text = this.textBox2.Text + ", ";
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "แดงโซดามะนาว";
            if (this.textBox2.Text != "")
                this.textBox2.Text = this.textBox2.Text + ", ";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "ชาเขียวมะนาว";
            if (this.textBox2.Text != "")
                this.textBox2.Text = this.textBox2.Text + ", ";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "ชามะนาว";
            if (this.textBox2.Text != "")
                this.textBox2.Text = this.textBox2.Text + ", ";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "ชาเขียวนมสด";
            if (this.textBox2.Text != "")
                this.textBox2.Text = this.textBox2.Text + ", ";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "ชาไทยนมสด";
            if (this.textBox2.Text != "")
                this.textBox2.Text = this.textBox2.Text + ", ";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "ชาเขียว";
            if (this.textBox2.Text != "")
                this.textBox2.Text = this.textBox2.Text + ", ";
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "ช็อกโกแลตลาวา";
            if (this.textBox2.Text != "")
                this.textBox2.Text = this.textBox2.Text + ", ";
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "พานาคอตต้าสตรอว์เบอร์รี";
            if (this.textBox2.Text != "")
                this.textBox2.Text = this.textBox2.Text + ", ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sitting = this.textBox1.Text;
            string coffeemenu = this.textBox2.Text;
            string[] arrMenu = coffeemenu.Split(',');

            sitting mm = new sitting();
            mm.createMoney(sitting, coffeemenu);
           int price = (int)mm.saleMoney();

            playment p = new playment(price);
            p.ShowDialog();
        }
    }
}