namespace OpenGl_1
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
            this.OpenGlControl = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.buttonDondur = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenGlControl
            // 
            this.OpenGlControl.AccumBits = ((byte)(0));
            this.OpenGlControl.AutoCheckErrors = false;
            this.OpenGlControl.AutoFinish = false;
            this.OpenGlControl.AutoMakeCurrent = true;
            this.OpenGlControl.AutoSwapBuffers = true;
            this.OpenGlControl.BackColor = System.Drawing.Color.Black;
            this.OpenGlControl.ColorBits = ((byte)(32));
            this.OpenGlControl.DepthBits = ((byte)(16));
            this.OpenGlControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.OpenGlControl.Location = new System.Drawing.Point(0, 0);
            this.OpenGlControl.Name = "OpenGlControl";
            this.OpenGlControl.Size = new System.Drawing.Size(705, 616);
            this.OpenGlControl.StencilBits = ((byte)(0));
            this.OpenGlControl.TabIndex = 0;
            this.OpenGlControl.Paint += new System.Windows.Forms.PaintEventHandler(this.MyPaint);
            this.OpenGlControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            // 
            // buttonDondur
            // 
            this.buttonDondur.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonDondur.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDondur.Location = new System.Drawing.Point(744, 70);
            this.buttonDondur.Name = "buttonDondur";
            this.buttonDondur.Size = new System.Drawing.Size(180, 66);
            this.buttonDondur.TabIndex = 1;
            this.buttonDondur.Text = "TURN";
            this.buttonDondur.UseVisualStyleBackColor = false;
            this.buttonDondur.Click += new System.EventHandler(this.buttonDondur_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(744, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 141);
            this.button1.TabIndex = 2;
            this.button1.Text = "TURN FOR 11 SECS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Italic);
            this.button2.Location = new System.Drawing.Point(744, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 91);
            this.button2.TabIndex = 3;
            this.button2.Text = "MAKE THE PYRAMID CRAZY";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Italic);
            this.button3.Location = new System.Drawing.Point(744, 450);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 78);
            this.button3.TabIndex = 4;
            this.button3.Text = "RESET";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(951, 616);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDondur);
            this.Controls.Add(this.OpenGlControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl OpenGlControl;
        private System.Windows.Forms.Button buttonDondur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

