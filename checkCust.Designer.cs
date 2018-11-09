namespace pharmaDB
{
    partial class checkCust
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
            this.checkCustbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkCustbutton
            // 
            this.checkCustbutton.Font = new System.Drawing.Font("Raleway", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCustbutton.Location = new System.Drawing.Point(310, 56);
            this.checkCustbutton.Name = "checkCustbutton";
            this.checkCustbutton.Size = new System.Drawing.Size(340, 70);
            this.checkCustbutton.TabIndex = 50;
            this.checkCustbutton.Text = "Show All Customer Details";
            this.checkCustbutton.UseVisualStyleBackColor = true;
            this.checkCustbutton.Click += new System.EventHandler(this.checkCustbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(821, 414);
            this.dataGridView1.TabIndex = 51;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Raleway", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(39, 56);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(220, 70);
            this.backButton.TabIndex = 73;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // checkCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 650);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkCustbutton);
            this.Name = "checkCust";
            this.Text = "checkCust";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button checkCustbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backButton;
    }
}