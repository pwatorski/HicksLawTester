namespace HicksLaw
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_begin = new System.Windows.Forms.Button();
            this.numUD_buttons = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numUD_tries = new System.Windows.Forms.NumericUpDown();
            this.rTB_results = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_buttons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_tries)).BeginInit();
            this.SuspendLayout();
            // 
            // button_begin
            // 
            this.button_begin.Location = new System.Drawing.Point(12, 91);
            this.button_begin.Name = "button_begin";
            this.button_begin.Size = new System.Drawing.Size(75, 23);
            this.button_begin.TabIndex = 0;
            this.button_begin.Text = "Begin";
            this.button_begin.UseVisualStyleBackColor = true;
            this.button_begin.Click += new System.EventHandler(this.Button_begin_Click);
            // 
            // numUD_buttons
            // 
            this.numUD_buttons.Location = new System.Drawing.Point(13, 25);
            this.numUD_buttons.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUD_buttons.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUD_buttons.Name = "numUD_buttons";
            this.numUD_buttons.Size = new System.Drawing.Size(75, 20);
            this.numUD_buttons.TabIndex = 1;
            this.numUD_buttons.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Max buttons:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tests per count:";
            // 
            // numUD_tries
            // 
            this.numUD_tries.Location = new System.Drawing.Point(13, 65);
            this.numUD_tries.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUD_tries.Name = "numUD_tries";
            this.numUD_tries.Size = new System.Drawing.Size(75, 20);
            this.numUD_tries.TabIndex = 3;
            this.numUD_tries.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // rTB_results
            // 
            this.rTB_results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTB_results.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rTB_results.Location = new System.Drawing.Point(95, 12);
            this.rTB_results.Name = "rTB_results";
            this.rTB_results.ReadOnly = true;
            this.rTB_results.Size = new System.Drawing.Size(401, 260);
            this.rTB_results.TabIndex = 5;
            this.rTB_results.Text = "Results will show up here after finishing tests";
            this.rTB_results.WordWrap = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 282);
            this.Controls.Add(this.rTB_results);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numUD_tries);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUD_buttons);
            this.Controls.Add(this.button_begin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Hick\'s law tester";
            ((System.ComponentModel.ISupportInitialize)(this.numUD_buttons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_tries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_begin;
        private System.Windows.Forms.NumericUpDown numUD_buttons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUD_tries;
        private System.Windows.Forms.RichTextBox rTB_results;
    }
}

