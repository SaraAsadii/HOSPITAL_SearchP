namespace HOSPITAL_SearchP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button8 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Thistle;
            this.button8.Location = new System.Drawing.Point(655, 165);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(262, 238);
            this.button8.TabIndex = 9;
            this.button8.Text = "گزارش پذیرش های بیمارستان";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Thistle;
            this.button14.Location = new System.Drawing.Point(250, 165);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(262, 238);
            this.button14.TabIndex = 18;
            this.button14.Text = " خروج از برنامه";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button8);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button14;
    }
}

