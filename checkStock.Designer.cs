namespace pharmaDB
{
    partial class checkStock
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
            this.drugnameBox = new System.Windows.Forms.TextBox();
            this.drugnameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.drugIDBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchNamebutton = new System.Windows.Forms.Button();
            this.searchIdButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drugnameBox
            // 
            this.drugnameBox.Font = new System.Drawing.Font("Raleway ExtraLight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drugnameBox.Location = new System.Drawing.Point(433, 179);
            this.drugnameBox.Name = "drugnameBox";
            this.drugnameBox.Size = new System.Drawing.Size(327, 37);
            this.drugnameBox.TabIndex = 45;
            this.drugnameBox.TextChanged += new System.EventHandler(this.drugnameBox_TextChanged);
            // 
            // drugnameLabel
            // 
            this.drugnameLabel.AutoSize = true;
            this.drugnameLabel.Font = new System.Drawing.Font("Raleway ExtraLight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drugnameLabel.Location = new System.Drawing.Point(190, 187);
            this.drugnameLabel.Name = "drugnameLabel";
            this.drugnameLabel.Size = new System.Drawing.Size(144, 29);
            this.drugnameLabel.TabIndex = 44;
            this.drugnameLabel.Text = "Drug Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 52);
            this.label1.TabIndex = 46;
            this.label1.Text = "Check Stock Quantity";
            // 
            // drugIDBox
            // 
            this.drugIDBox.Font = new System.Drawing.Font("Raleway ExtraLight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drugIDBox.Location = new System.Drawing.Point(433, 355);
            this.drugIDBox.Name = "drugIDBox";
            this.drugIDBox.Size = new System.Drawing.Size(327, 37);
            this.drugIDBox.TabIndex = 48;
            this.drugIDBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raleway ExtraLight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 47;
            this.label2.Text = "Drug ID";
            // 
            // searchNamebutton
            // 
            this.searchNamebutton.Font = new System.Drawing.Font("Raleway", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchNamebutton.Location = new System.Drawing.Point(369, 250);
            this.searchNamebutton.Name = "searchNamebutton";
            this.searchNamebutton.Size = new System.Drawing.Size(220, 70);
            this.searchNamebutton.TabIndex = 49;
            this.searchNamebutton.Text = "Search";
            this.searchNamebutton.UseVisualStyleBackColor = true;
            this.searchNamebutton.Click += new System.EventHandler(this.searchNamebutton_Click);
            // 
            // searchIdButton
            // 
            this.searchIdButton.Font = new System.Drawing.Font("Raleway", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchIdButton.Location = new System.Drawing.Point(369, 436);
            this.searchIdButton.Name = "searchIdButton";
            this.searchIdButton.Size = new System.Drawing.Size(220, 70);
            this.searchIdButton.TabIndex = 50;
            this.searchIdButton.Text = "Search";
            this.searchIdButton.UseVisualStyleBackColor = true;
            this.searchIdButton.Click += new System.EventHandler(this.searchIdButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Raleway", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(23, 43);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(220, 70);
            this.logoutButton.TabIndex = 73;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click_1);
            // 
            // checkStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 650);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.searchIdButton);
            this.Controls.Add(this.searchNamebutton);
            this.Controls.Add(this.drugIDBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drugnameBox);
            this.Controls.Add(this.drugnameLabel);
            this.Name = "checkStock";
            this.Text = "checkStockcs";
            this.Load += new System.EventHandler(this.checkStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox drugnameBox;
        private System.Windows.Forms.Label drugnameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox drugIDBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchNamebutton;
        private System.Windows.Forms.Button searchIdButton;
        private System.Windows.Forms.Button logoutButton;
    }
}