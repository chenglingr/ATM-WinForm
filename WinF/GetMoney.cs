﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinF
{
    public partial class GetMoney : Form
    {
        public string CardID;
        public GetMoney()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal num = numericUpDown1.Value;
            BLL.cardinfo bll = new BLL.cardinfo();
            bool isOk = bll.UpdateBalance(CardID, -num,textBox1.Text);
            if (isOk) { label2.Text = "取款成功！"; }
            else
            {
                label2.Text = "取款失败！";
            }
        }
    }
}
