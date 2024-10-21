using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            startGame();
        }

        private int Counter ;
        private int score=0 ;
        private bool ButtonUpdateMode=true ;


        Class1 class1 = new Class1();

 
        private void startGame()
        {
            Counter = 0;
            EnableAllButtons();
            pictureBox2.Enabled = true;
            UpdateLampImage();
            UpdateImage();
            class1.GetRandomState();
            class1.SetdisplayState(class1.GetUnderscore());
            UpdateDisplay();
        }

       
        private void UpdateDisplay()
        {
            stateLabel.Text = class1.GetdisplayState();
        }


        private void Check()
        {
            ButtonUpdateMode = true;
            if (class1.LetterIsFound())
            {
                UpdateDisplay();
                


                if (!class1.GetdisplayState().Contains("_"))
                {
                    DisableAllButtons();
                    startGame();
                    ButtonUpdateMode = false;
                    UpdateScore(10);
                    return;
                }
            }
            else
            {
                Counter++;
                UpdateImage();
      
                if (Counter >=6)
                {
                    DisableAllButtons();
                    score = 0;
                    UpdateScore();
                    MessageBox.Show("     Oyunu Kaybettin     ");
                    startGame();
                    ButtonUpdateMode = false;
                    return;
                }
            }
        }



        private void DisableAllButtons()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button && ctrl.Name.StartsWith("button"))
                {
                    ((Button)ctrl).Enabled = false;
                }
            }
        }

        
        private void EnableAllButtons()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button && ctrl.Name.StartsWith("button"))
                {
                    ((Button)ctrl).Enabled = true;
                }
            }
        }


        private void UpdateImage()  
        {
          
            switch (Counter) 
            {
               case 0: pictureBox1.Image = Properties.Resources.pic_1; break;
               case 1: pictureBox1.Image = Properties.Resources.pic_2; break;
               case 2: pictureBox1.Image = Properties.Resources.pic_3; break;
               case 3: pictureBox1.Image = Properties.Resources.pic_4; break;
               case 4: pictureBox1.Image = Properties.Resources.pic_5; break;
               case 5: pictureBox1.Image = Properties.Resources.pic_6; break;
               case 6: pictureBox1.Image = Properties.Resources.pic_7; break;
            }


        } 

        private void UpdateLampImage()
        {
            if (pictureBox2.Enabled)
               {
                pictureBox2.Image = Properties.Resources.lamp1;
            }
           else
            {
               pictureBox2.Image = Properties.Resources.lamp2;
            }
             
        }


        private void UpdateScore(int i =0)
        {
            score = score + i;
            Score.Text =score .ToString()+"+";
        }

        private void Resstart_Click(object sender, EventArgs e)
        {
            startGame();
            score = 0;
            UpdateScore();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    
        private void button_O_Click(object sender, EventArgs e)
        {
            class1.SetLetter('O');
            Check();
            if (ButtonUpdateMode)
                button_O.Enabled = false;
            
        }

        private void button_E_Click(object sender, EventArgs e)
        {
            class1.SetLetter('E');
            Check();
            if (ButtonUpdateMode)
                button_E.Enabled = false;
            
        }

        private void button_W_Click(object sender, EventArgs e)
        {
            class1.SetLetter('W');
            Check();
            if (ButtonUpdateMode)
                button_W.Enabled = false;
            
        }

        private void button_R_Click(object sender, EventArgs e)
        {
            class1.SetLetter('R');
            Check();
            if (ButtonUpdateMode)
                button_R.Enabled = false;
            
        }

        private void button_T_Click(object sender, EventArgs e)
        {
            class1.SetLetter('T');
            Check();
            if(ButtonUpdateMode)
            button_T.Enabled = false;
            
        }

        private void button_Y_Click(object sender, EventArgs e)
        {
            class1.SetLetter('Y');
            Check();
            if (ButtonUpdateMode)
                button_Y.Enabled = false;
            
        }

        private void button_U_Click(object sender, EventArgs e)
        {
            class1.SetLetter('U');
            Check();
            if (ButtonUpdateMode)
                button_U.Enabled = false;
            
        }

        private void button_I_Click(object sender, EventArgs e)
        {
            class1.SetLetter('I');
            Check();
            if (ButtonUpdateMode)
                button_I.Enabled = false;
            
        }

        private void button_p_Click(object sender, EventArgs e)
        {
            class1.SetLetter('P');
            Check();
            if (ButtonUpdateMode)
                button_p.Enabled = false;
            
        }

        private void button_ğ_Click(object sender, EventArgs e)
        {
            class1.SetLetter('Ğ');
            Check();
            if (ButtonUpdateMode)
                button_ğ.Enabled = false;
           
        }

        private void button_ü_Click(object sender, EventArgs e)
        {
            class1.SetLetter('Ü');
            Check();
            if (ButtonUpdateMode)
                button_ü.Enabled = false;
            
        }

        private void button_S_Click(object sender, EventArgs e)
        {
            class1.SetLetter('S');
            Check();
            if (ButtonUpdateMode)
                button_S.Enabled = false;
            
        }

        private void button_d_Click(object sender, EventArgs e)
        {
            class1.SetLetter('D');
            Check();
            if (ButtonUpdateMode)
                button_d.Enabled = false;
            
        }

        private void button_f_Click(object sender, EventArgs e)
        {
            class1.SetLetter('F');
            Check();
            if (ButtonUpdateMode)
                button_f.Enabled = false;
            
        }

        private void button_g_Click(object sender, EventArgs e)
        {
            class1.SetLetter('G');
            Check();
            if (ButtonUpdateMode)
                button_g.Enabled = false;
            
        }

        private void button_h_Click(object sender, EventArgs e)
        {
            class1.SetLetter('H');
            Check();
            if (ButtonUpdateMode)
                button_h.Enabled = false;
            
        }

        private void button_j_Click(object sender, EventArgs e)
        {
            class1.SetLetter('J');
            Check();
            if (ButtonUpdateMode)
                button_j.Enabled = false;
            
        }

        private void button_k_Click(object sender, EventArgs e)
        {
            class1.SetLetter('K');
            Check();
            if (ButtonUpdateMode)
                button_k.Enabled = false;
            
        }

        private void button_L_Click(object sender, EventArgs e)
        {
            class1.SetLetter('L');
            Check();
            if (ButtonUpdateMode)
                button_L.Enabled = false;
            
        }

        private void button_ş_Click(object sender, EventArgs e)
        {
            class1.SetLetter('Ş');
            Check();
            if (ButtonUpdateMode)
                button_ş.Enabled = false;
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            class1.SetLetter('İ');
            Check();
            if (ButtonUpdateMode)
                button9.Enabled = false;
            
        }

        private void button_z_Click(object sender, EventArgs e)
        {
            class1.SetLetter('Z');
            Check();
            if (ButtonUpdateMode)
                button_z.Enabled = false;
            
        }

        private void button_x_Click(object sender, EventArgs e)
        {
            class1.SetLetter('X');
            Check();
            if (ButtonUpdateMode)
                button_x.Enabled = false;
            
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            class1.SetLetter('C');
            Check();
            if (ButtonUpdateMode)
                button_C.Enabled = false;
            
        }

        private void button_v_Click(object sender, EventArgs e)
        {
            class1.SetLetter('V');
            Check();
            if (ButtonUpdateMode)
                button_v.Enabled = false;
            
        }

        private void button_B_Click(object sender, EventArgs e)
        {
            class1.SetLetter('B');
            Check ();
             if (ButtonUpdateMode)
            button_B.Enabled = false;
            
        }

   
        private void button_A_Click(object sender, EventArgs e)
        {
            class1.SetLetter('A');
            Check();
            if (ButtonUpdateMode)
                button_A.Enabled = false;
            
        }

        private void button_Q_Click(object sender, EventArgs e)
        {

            class1.SetLetter('Q');
            Check();
            if (ButtonUpdateMode)
                button_Q.Enabled = false;
            
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            class1.SetLetter('N');
            Check();
            if (ButtonUpdateMode)
                buttonN.Enabled = false;
            
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            class1.SetLetter('M');
            Check();
            if (ButtonUpdateMode)
                buttonM.Enabled = false;
            
        }

        private void buttonÖ_Click(object sender, EventArgs e)
        {
            class1.SetLetter('Ö');
            Check();
            if (ButtonUpdateMode)
                buttonÖ.Enabled = false;
            
        }

        private void buttonÇ_Click(object sender, EventArgs e)
        {
            class1.SetLetter('Ç');
            Check();
            if (ButtonUpdateMode)
                buttonÇ.Enabled = false;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            string state = class1.GetState();
            int index = class1.GetRandomLatter();
            class1.SetLetter(state[index]);
            class1.SaveDisplayState(index);
            UpdateDisplay();
            pictureBox2.Enabled = false;
            UpdateLampImage();

        }
    }
}

