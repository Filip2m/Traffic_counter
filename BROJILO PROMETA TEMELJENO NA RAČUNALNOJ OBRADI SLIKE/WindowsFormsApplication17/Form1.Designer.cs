namespace WindowsFormsApplication17
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
            this.ibVideo = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.KontrolniVideo = new Emgu.CV.UI.ImageBox();
            this.Reset_counter = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ispisxy = new System.Windows.Forms.Label();
            this.Uputa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ibVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KontrolniVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // ibVideo
            // 
            this.ibVideo.Location = new System.Drawing.Point(13, 13);
            this.ibVideo.Name = "ibVideo";
            this.ibVideo.Size = new System.Drawing.Size(640, 360);
            this.ibVideo.TabIndex = 2;
            this.ibVideo.TabStop = false;
            this.ibVideo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ibVideo_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(710, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(710, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(710, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(657, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prolazaka_Lijevo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(758, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(7, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "\r\n";
            // 
            // KontrolniVideo
            // 
            this.KontrolniVideo.Location = new System.Drawing.Point(659, 187);
            this.KontrolniVideo.Name = "KontrolniVideo";
            this.KontrolniVideo.Size = new System.Drawing.Size(640, 360);
            this.KontrolniVideo.TabIndex = 2;
            this.KontrolniVideo.TabStop = false;
            this.KontrolniVideo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ibVideo_MouseClick);
            // 
            // Reset_counter
            // 
            this.Reset_counter.Location = new System.Drawing.Point(831, 29);
            this.Reset_counter.Name = "Reset_counter";
            this.Reset_counter.Size = new System.Drawing.Size(121, 23);
            this.Reset_counter.TabIndex = 8;
            this.Reset_counter.Text = "Reset Counter";
            this.Reset_counter.UseVisualStyleBackColor = true;
            this.Reset_counter.Click += new System.EventHandler(this.Reset_counter_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(657, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Prolazaka_Desno:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(758, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 10;
            // 
            // ispisxy
            // 
            this.ispisxy.AutoSize = true;
            this.ispisxy.Location = new System.Drawing.Point(28, 410);
            this.ispisxy.Name = "ispisxy";
            this.ispisxy.Size = new System.Drawing.Size(56, 13);
            this.ispisxy.TabIndex = 11;
            this.ispisxy.Text = "X,Y,brojac";
            // 
            // Uputa
            // 
            this.Uputa.AutoSize = true;
            this.Uputa.Location = new System.Drawing.Point(10, 575);
            this.Uputa.Name = "Uputa";
            this.Uputa.Size = new System.Drawing.Size(747, 13);
            this.Uputa.TabIndex = 12;
            this.Uputa.Text = "Za postavljanje kordinata, prvo se uzima traka gdje promet nadolazi sa lijeva na " +
    "desno (3 tocke), zatim traka gdje promet nadolazi sa desna na lijevo (3 tocke)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.Uputa);
            this.Controls.Add(this.ispisxy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Reset_counter);
            this.Controls.Add(this.KontrolniVideo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ibVideo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ibVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KontrolniVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox ibVideo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Emgu.CV.UI.ImageBox KontrolniVideo;
        private System.Windows.Forms.Button Reset_counter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ispisxy;
        private System.Windows.Forms.Label Uputa;
    }
}

