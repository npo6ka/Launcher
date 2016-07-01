﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laucher
{
    class AccountPanel
    {
        Panel panel;
        Label label;
        static int height = 30;
        int num;

        public Panel Panel
        {
            get
            {
                return panel;
            }

            set
            {
                panel = value;
            }
        }

        public static int Height
        {
            get
            {
                return height;
            }

            private set
            {
                height = value;
            }
        }

        public AccountPanel (int num, int size, String nickname)
        {
            label = new System.Windows.Forms.Label();
            Panel = new System.Windows.Forms.Panel();
            Panel.SuspendLayout();

            this.num = num;
            
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(0, Height / 4);
            label.Name = "label" + num;
            label.Size = new System.Drawing.Size(size - 21, Height/3*2);
            label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label.Text = nickname;
            label.TabIndex = num*2;
            label.Click += new System.EventHandler(this.handler_click);

            if (num == 1) 
                Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            Panel.Controls.Add(this.label);
            //panel.Controls.Add(this.panel2);
            Panel.Location = new System.Drawing.Point(0, num * Height);
            Panel.Name = "panel" + num;
            Panel.Size = new System.Drawing.Size(size - 21, Height);
            Panel.TabIndex = num*2 + 1;
            Panel.Click += new System.EventHandler(this.handler_click);
        }



        private void handler_click(object sender, EventArgs e)
        {
            
            this.label.Text = "click" + num;
        }
    }
}