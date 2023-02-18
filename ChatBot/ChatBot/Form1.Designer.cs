namespace ChatBot
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbot2 = new System.Windows.Forms.TextBox();
            this.txtres = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.lblbot = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.PictureBox();
            this.btnok = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnnew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 75);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(105, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "ChatBot";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.btnnew);
            this.panel2.Controls.Add(this.txtbot2);
            this.panel2.Controls.Add(this.txtres);
            this.panel2.Controls.Add(this.txtuser);
            this.panel2.Controls.Add(this.btnok);
            this.panel2.Controls.Add(this.lblbot);
            this.panel2.Location = new System.Drawing.Point(-1, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 557);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtbot2
            // 
            this.txtbot2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtbot2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbot2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbot2.Location = new System.Drawing.Point(54, 283);
            this.txtbot2.Multiline = true;
            this.txtbot2.Name = "txtbot2";
            this.txtbot2.ReadOnly = true;
            this.txtbot2.Size = new System.Drawing.Size(189, 119);
            this.txtbot2.TabIndex = 9;
            // 
            // txtres
            // 
            this.txtres.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtres.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtres.Location = new System.Drawing.Point(250, 82);
            this.txtres.Multiline = true;
            this.txtres.Name = "txtres";
            this.txtres.ReadOnly = true;
            this.txtres.Size = new System.Drawing.Size(189, 119);
            this.txtres.TabIndex = 8;
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(23, 492);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(378, 33);
            this.txtuser.TabIndex = 6;
            // 
            // lblbot
            // 
            this.lblbot.AutoSize = true;
            this.lblbot.BackColor = System.Drawing.Color.DimGray;
            this.lblbot.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbot.Location = new System.Drawing.Point(65, 49);
            this.lblbot.Name = "lblbot";
            this.lblbot.Size = new System.Drawing.Size(28, 22);
            this.lblbot.TabIndex = 1;
            this.lblbot.Text = "...";
            // 
            // btnnew
            // 
            this.btnnew.Image = global::ChatBot.Properties.Resources._1486485588_add_create_new_math_sign_cross_plus_81186;
            this.btnnew.Location = new System.Drawing.Point(423, 485);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(53, 47);
            this.btnnew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnnew.TabIndex = 10;
            this.btnnew.TabStop = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnok
            // 
            this.btnok.Image = global::ChatBot.Properties.Resources.iconfinder_send_4341325_1205241;
            this.btnok.Location = new System.Drawing.Point(423, 484);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(53, 47);
            this.btnok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnok.TabIndex = 5;
            this.btnok.TabStop = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChatBot.Properties.Resources.robot_icon_icons_com_60269;
            this.pictureBox1.Location = new System.Drawing.Point(46, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 623);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnnew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnok;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtres;
        private System.Windows.Forms.TextBox txtbot2;
        private System.Windows.Forms.Label lblbot;
        private System.Windows.Forms.PictureBox btnnew;
    }
}

