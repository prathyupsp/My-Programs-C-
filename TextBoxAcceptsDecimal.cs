using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxAcceptsDecimal
{
    public partial class keyPress : Form
    {
        int count = 0; bool flag = false;
        public keyPress()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
        }

        
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!flag)
            {
                e.Handled = true;       //handling the event
                
            }
           
        }

        private void btnClear_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        //keypress event
        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            
            flag = false;

            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) || ((e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod) && count < 1) || e.KeyCode == Keys.Back)
            {
              
                flag = true;

                if (e.KeyCode == Keys.Decimal||e.KeyCode==Keys.OemPeriod)
                    count++;
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }
            
        }
    }

