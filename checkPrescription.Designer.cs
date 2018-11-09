namespace pharmaDB
{
    partial class checkPrescription
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
            this.custIDBox = new System.Windows.Forms.TextBox();
            this.custIDLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // custIDBox
            // 
            this.custIDBox.Font = new System.Drawing.Font("Raleway ExtraLight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custIDBox.Location = new System.Drawing.Point(455, 209);
            this.custIDBox.Name = "custIDBox";
            this.custIDBox.Size = new System.Drawing.Size(327, 37);
            this.custIDBox.TabIndex = 47;
            // 
            // custIDLabel
            // 
            this.custIDLabel.AutoSize = true;
            this.custIDLabel.Font = new System.Drawing.Font("Raleway ExtraLight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custIDLabel.Location = new System.Drawing.Point(183, 217);
            this.custIDLabel.Name = "custIDLabel";
            this.custIDLabel.Size = new System.Drawing.Size(154, 29);
            this.custIDLabel.TabIndex = 46;
            this.custIDLabel.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 52);
            this.label1.TabIndex = 48;
            this.label1.Text = "Check Prescription History";
            // 
            // checkbutton
            // 
            this.checkbutton.Font = new System.Drawing.Font("Raleway", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbutton.Location = new System.Drawing.Point(368, 290);
            this.checkbutton.Name = "checkbutton";
            this.checkbutton.Size = new System.Drawing.Size(220, 70);
            this.checkbutton.TabIndex = 50;
            this.checkbutton.Text = "Check";
            this.checkbutton.UseVisualStyleBackColor = true;
            this.checkbutton.Click += new System.EventHandler(this.checkbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(124, 425);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(725, 143);
            this.dataGridView1.TabIndex = 51;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Raleway", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(38, 26);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(220, 70);
            this.backButton.TabIndex = 73;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // checkPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 650);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.custIDBox);
            this.Controls.Add(this.custIDLabel);
            this.Name = "checkPrescription";
            this.Text = "checkPrescription";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox custIDBox;
        private System.Windows.Forms.Label custIDLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checkbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backButton;
    }
}