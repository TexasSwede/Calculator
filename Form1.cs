using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
        Boolean stackEnter = false;
        Boolean stackPush = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (stackPush)
            {
                pushStack();
                stackPush = false;
            }
            if (stackEnter)
            {
                stackX.Text = "";
            }
            stackX.Text = stackX.Text + "1";
            stackEnter = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (stackPush)
            {
                pushStack();
                stackPush = false;
            }
            if (stackEnter)
            {
                stackX.Text = "";
            }
            stackX.Text = stackX.Text + "2";
            stackEnter = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (stackPush)
            {
                pushStack();
                stackPush = false;
            }
            if (stackEnter)
            {
                stackX.Text = "";
            }
            stackX.Text = stackX.Text + "3";
            stackEnter = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (stackPush)
            {
                pushStack();
                stackPush = false;
            }
            if (stackEnter)
            {
                stackX.Text = "";
            }
            stackX.Text = stackX.Text + "4";
            stackEnter = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (stackPush)
            {
                pushStack();
                stackPush = false;
            }
            if (stackEnter)
            {
                stackX.Text = "";
            }
            stackX.Text = stackX.Text + "5";
            stackEnter = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (stackPush)
            {
                pushStack();
                stackPush = false;
            }
            if (stackEnter)
            {
                stackX.Text = "";
            }
            stackX.Text = stackX.Text + "6";
            stackEnter = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (stackPush)
            {
                pushStack();
                stackPush = false;
            }
            if (stackEnter)
            {
                stackX.Text = "";
            }
            stackX.Text = stackX.Text + "7";
            stackEnter = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (stackPush)
            {
                pushStack();
                stackPush = false;
            }
            if (stackEnter)
            {
                stackX.Text = "";
            }
            stackX.Text = stackX.Text + "8";
            stackEnter = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (stackPush)
            {
                pushStack();
                stackPush = false;
            }
            if (stackEnter)
            {
                stackX.Text = "";
            }
            stackX.Text = stackX.Text + "9";
            stackEnter = false;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (stackPush)
            {
                pushStack();
                stackPush = false;
            }
            if (stackEnter)
            {
                stackX.Text = "";
            }

            stackX.Text = stackX.Text + "0";
            stackEnter = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            stackT.Text = stackZ.Text;
            stackZ.Text = stackY.Text;
            stackY.Text = stackX.Text;
            stackEnter = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            stackX.Text = Convert.ToString(Convert.ToDouble(stackX.Text) + Convert.ToDouble(stackY.Text));
            dropStack();
            stackEnter = true;
            stackPush = true;
        }

        private void dropStack()
        {
            stackY.Text = stackZ.Text;
            stackZ.Text = stackT.Text;
        }

        private void pushStack()
        {
            stackT.Text = stackZ.Text;
            stackZ.Text = stackY.Text;
            stackY.Text = stackX.Text;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            stackX.Text = Convert.ToString(Convert.ToDouble(stackY.Text) - Convert.ToDouble(stackX.Text));
            dropStack();
            stackEnter = true;
            stackPush = true;
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            stackX.Text = Convert.ToString(Convert.ToDouble(stackY.Text) / Convert.ToDouble(stackX.Text));
            dropStack();
            stackEnter = true;
            stackPush = true;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            stackX.Text = Convert.ToString(Convert.ToDouble(stackY.Text) / Convert.ToDouble(stackX.Text));
            dropStack();
            stackEnter = true;
            stackPush = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            stackX.Text = "";
            stackY.Text = "";
            stackZ.Text = "";
            stackT.Text = "";
            stackEnter = false;
            stackPush = false;
        }
    }
}
