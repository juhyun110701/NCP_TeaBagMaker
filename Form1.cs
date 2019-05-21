using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        int CountNum = 0;

        string[] tea = new string[] { "홍차", "녹차", "루이보스차", "국화차" };
        
        int[] times=new int[]{120,180,300,120};
        int time = 0;
   

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < tea.Length; i++)
            {
                this.combobox.Items.Add(tea[i]);
                time = times[i];
                if (combobox.Items.Count > 0)
                {
                    this.combobox.SelectedIndex = 0;
                }
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                this.timelabel.Text = "시간 : " + time;
        }

        private void Timelabel_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            Timer_Tick(sender,e);
        }
         
        private void Timer_Tick(object sender, EventArgs e)
        {
            {
                if (time < 1)
                {
                    this.timer.Enabled = false;
                    this.timelabel.Text = "";
                    MessageBox.Show("티백을 건지세요!", "알림", MessageBoxButtons.OK);
                    this.combobox.Focus();
                }
                else
                {
                    time--;
                    this.timelabel.Text = Convert.ToString(time / 60 + "분 " + time % 60 + "초 남았습니다!");
                }
            }
            }
    }
}
