namespace Approximate_PI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_terms = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.lbl_terms = new System.Windows.Forms.Label();
            this.lbl_results = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(59, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter # of terms:";
            // 
            // txt_terms
            // 
            this.txt_terms.Location = new System.Drawing.Point(229, 54);
            this.txt_terms.Name = "txt_terms";
            this.txt_terms.Size = new System.Drawing.Size(100, 22);
            this.txt_terms.TabIndex = 1;
            // 
            // btn_calc
            // 
            this.btn_calc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_calc.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_calc.Location = new System.Drawing.Point(59, 100);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(101, 46);
            this.btn_calc.TabIndex = 2;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = false;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // lbl_terms
            // 
            this.lbl_terms.AutoSize = true;
            this.lbl_terms.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_terms.Location = new System.Drawing.Point(59, 189);
            this.lbl_terms.Name = "lbl_terms";
            this.lbl_terms.Size = new System.Drawing.Size(0, 19);
            this.lbl_terms.TabIndex = 3;
            // 
            // lbl_results
            // 
            this.lbl_results.AutoSize = true;
            this.lbl_results.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_results.Location = new System.Drawing.Point(59, 256);
            this.lbl_results.Name = "lbl_results";
            this.lbl_results.Size = new System.Drawing.Size(0, 19);
            this.lbl_results.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(381, 308);
            this.Controls.Add(this.lbl_results);
            this.Controls.Add(this.lbl_terms);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.txt_terms);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Approximate PI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_terms;
        private Button btn_calc;
        private Label lbl_terms;
        private Label lbl_results;
    }
}