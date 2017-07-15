namespace _3D2CAMWorks
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
            this.button_CAM_Calc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_CAM_Calc
            // 
            this.button_CAM_Calc.Location = new System.Drawing.Point(12, 199);
            this.button_CAM_Calc.Name = "button_CAM_Calc";
            this.button_CAM_Calc.Size = new System.Drawing.Size(260, 50);
            this.button_CAM_Calc.TabIndex = 0;
            this.button_CAM_Calc.Text = "CAM計算";
            this.button_CAM_Calc.UseVisualStyleBackColor = true;
            this.button_CAM_Calc.Click += new System.EventHandler(this.button_CAM_Calc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_CAM_Calc);
            this.Name = "Form1";
            this.Text = "3D2CAMWorks";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_CAM_Calc;
    }
}

