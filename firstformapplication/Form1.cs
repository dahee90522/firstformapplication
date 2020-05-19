using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstFormApplication
{
    public partial class Form1 : Form
    //partial calss=> 디자인.cs와 코드.cs를 하나로 만들어 주는 것.-> 두개를 하나의 클래스로 만들어주는 것
    {
        public Form1()
        {
            InitializeComponent();

            myButton.Enabled = true;//true=> 화면에서 작동 가능
            myButton.Text = "안녕하세요";
            myButton.Width = 200;

            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                button.Location = new Point(213, 13 + (23 + 3) * i);
                Controls.Add(button);
                button.Text = "동적생성" + i + "번째";
                button.Width = 100;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}