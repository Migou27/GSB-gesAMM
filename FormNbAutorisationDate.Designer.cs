namespace PROJETgesAMM
{
    partial class FormNbAutorisationDate
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.tbNbAmm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date (YYYY-MM-DD) :";
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(229, 208);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(181, 27);
            this.tbDate.TabIndex = 1;
            this.tbDate.TextChanged += new System.EventHandler(this.tbDate_TextChanged);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(229, 264);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(94, 29);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // tbNbAmm
            // 
            this.tbNbAmm.Enabled = false;
            this.tbNbAmm.Location = new System.Drawing.Point(570, 208);
            this.tbNbAmm.Name = "tbNbAmm";
            this.tbNbAmm.Size = new System.Drawing.Size(101, 27);
            this.tbNbAmm.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nb Amm :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormNbAutorisationDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 497);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNbAmm);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.label1);
            this.Name = "FormNbAutorisationDate";
            this.Text = "FormNbAutorisationDate";
            this.Load += new System.EventHandler(this.FormNbAutorisationDate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbDate;
        private Button btnValider;
        private TextBox tbNbAmm;
        private Label label2;
    }
}