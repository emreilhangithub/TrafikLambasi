
namespace TrafikLambası
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RedPic = new System.Windows.Forms.PictureBox();
            this.GreenPic = new System.Windows.Forms.PictureBox();
            this.YellowPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowPic)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.RedPic);
            this.groupBox1.Controls.Add(this.GreenPic);
            this.groupBox1.Controls.Add(this.YellowPic);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(922, 515);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trafik Lambası";
            // 
            // RedPic
            // 
            this.RedPic.Image = ((System.Drawing.Image)(resources.GetObject("RedPic.Image")));
            this.RedPic.Location = new System.Drawing.Point(381, 36);
            this.RedPic.Name = "RedPic";
            this.RedPic.Size = new System.Drawing.Size(166, 328);
            this.RedPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedPic.TabIndex = 6;
            this.RedPic.TabStop = false;
            // 
            // GreenPic
            // 
            this.GreenPic.Image = ((System.Drawing.Image)(resources.GetObject("GreenPic.Image")));
            this.GreenPic.Location = new System.Drawing.Point(382, 36);
            this.GreenPic.Name = "GreenPic";
            this.GreenPic.Size = new System.Drawing.Size(166, 328);
            this.GreenPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GreenPic.TabIndex = 5;
            this.GreenPic.TabStop = false;
            this.GreenPic.Visible = false;
            // 
            // YellowPic
            // 
            this.YellowPic.Image = ((System.Drawing.Image)(resources.GetObject("YellowPic.Image")));
            this.YellowPic.Location = new System.Drawing.Point(382, 36);
            this.YellowPic.Name = "YellowPic";
            this.YellowPic.Size = new System.Drawing.Size(166, 328);
            this.YellowPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.YellowPic.TabIndex = 1;
            this.YellowPic.TabStop = false;
            this.YellowPic.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Süre";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(92, 410);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(287, 63);
            this.button4.TabIndex = 3;
            this.button4.Text = "Başlat";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(428, 410);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(287, 63);
            this.button5.TabIndex = 7;
            this.button5.Text = "Bitir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1156, 630);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox YellowPic;
        private System.Windows.Forms.PictureBox RedPic;
        private System.Windows.Forms.PictureBox GreenPic;
        private System.Windows.Forms.Button button5;
    }
}

