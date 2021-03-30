namespace HicksLaw
{
    partial class Measuring
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
            this.textBox_prompt = new System.Windows.Forms.TextBox();
            this.button_interrupt = new System.Windows.Forms.Button();
            this.button_exitMeasuring = new System.Windows.Forms.Button();
            this.button_beginMeasuring = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_prompt
            // 
            this.textBox_prompt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_prompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_prompt.Location = new System.Drawing.Point(12, 12);
            this.textBox_prompt.Name = "textBox_prompt";
            this.textBox_prompt.Size = new System.Drawing.Size(421, 68);
            this.textBox_prompt.TabIndex = 1;
            this.textBox_prompt.Text = "99";
            this.textBox_prompt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_interrupt
            // 
            this.button_interrupt.Location = new System.Drawing.Point(12, 184);
            this.button_interrupt.Name = "button_interrupt";
            this.button_interrupt.Size = new System.Drawing.Size(60, 23);
            this.button_interrupt.TabIndex = 2;
            this.button_interrupt.Text = "Interrupt";
            this.button_interrupt.UseVisualStyleBackColor = true;
            this.button_interrupt.Click += new System.EventHandler(this.Button_interrupt_Click);
            // 
            // button_exitMeasuring
            // 
            this.button_exitMeasuring.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exitMeasuring.Location = new System.Drawing.Point(373, 184);
            this.button_exitMeasuring.Name = "button_exitMeasuring";
            this.button_exitMeasuring.Size = new System.Drawing.Size(60, 23);
            this.button_exitMeasuring.TabIndex = 3;
            this.button_exitMeasuring.Text = "Exit";
            this.button_exitMeasuring.UseVisualStyleBackColor = true;
            this.button_exitMeasuring.Click += new System.EventHandler(this.Button_exitMeasuring_Click);
            // 
            // button_beginMeasuring
            // 
            this.button_beginMeasuring.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_beginMeasuring.Location = new System.Drawing.Point(12, 155);
            this.button_beginMeasuring.Name = "button_beginMeasuring";
            this.button_beginMeasuring.Size = new System.Drawing.Size(421, 23);
            this.button_beginMeasuring.TabIndex = 4;
            this.button_beginMeasuring.Text = "Begin";
            this.button_beginMeasuring.UseVisualStyleBackColor = true;
            this.button_beginMeasuring.Click += new System.EventHandler(this.Button_beginMeasuring_Click);
            // 
            // Measuring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 219);
            this.Controls.Add(this.button_beginMeasuring);
            this.Controls.Add(this.button_exitMeasuring);
            this.Controls.Add(this.button_interrupt);
            this.Controls.Add(this.textBox_prompt);
            this.Name = "Measuring";
            this.Text = "Measuring";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_prompt;
        private System.Windows.Forms.Button button_interrupt;
        private System.Windows.Forms.Button button_exitMeasuring;
        private System.Windows.Forms.Button button_beginMeasuring;
    }
}