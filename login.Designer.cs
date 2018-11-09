namespace pharmaDB
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.oracleConnection1 = new Oracle.DataAccess.Client.OracleConnection();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.casLoginbutton = new System.Windows.Forms.Button();
            this.manLoginbutton = new System.Windows.Forms.Button();
            this.pharmaLoginbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "pharmaDB";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 200F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(48, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(692, 378);
            this.label3.TabIndex = 2;
            this.label3.Text = "      ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // casLoginbutton
            // 
            this.casLoginbutton.Font = new System.Drawing.Font("Raleway Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casLoginbutton.Location = new System.Drawing.Point(373, 446);
            this.casLoginbutton.Name = "casLoginbutton";
            this.casLoginbutton.Size = new System.Drawing.Size(216, 48);
            this.casLoginbutton.TabIndex = 3;
            this.casLoginbutton.Text = "Cashier";
            this.casLoginbutton.UseVisualStyleBackColor = true;
            this.casLoginbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // manLoginbutton
            // 
            this.manLoginbutton.Font = new System.Drawing.Font("Raleway Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manLoginbutton.Location = new System.Drawing.Point(373, 507);
            this.manLoginbutton.Name = "manLoginbutton";
            this.manLoginbutton.Size = new System.Drawing.Size(216, 48);
            this.manLoginbutton.TabIndex = 4;
            this.manLoginbutton.Text = "Manager";
            this.manLoginbutton.UseVisualStyleBackColor = true;
            this.manLoginbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // pharmaLoginbutton
            // 
            this.pharmaLoginbutton.Font = new System.Drawing.Font("Raleway Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pharmaLoginbutton.Location = new System.Drawing.Point(373, 567);
            this.pharmaLoginbutton.Name = "pharmaLoginbutton";
            this.pharmaLoginbutton.Size = new System.Drawing.Size(216, 48);
            this.pharmaLoginbutton.TabIndex = 5;
            this.pharmaLoginbutton.Text = "Pharmacist";
            this.pharmaLoginbutton.UseVisualStyleBackColor = true;
            this.pharmaLoginbutton.Click += new System.EventHandler(this.pharmaLoginbutton_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 650);
            this.Controls.Add(this.pharmaLoginbutton);
            this.Controls.Add(this.manLoginbutton);
            this.Controls.Add(this.casLoginbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "login";
            this.Text = "pharmaDB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Oracle.DataAccess.Client.OracleConnection oracleConnection1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button casLoginbutton;
        private System.Windows.Forms.Button manLoginbutton;
        private System.Windows.Forms.Button pharmaLoginbutton;
    }
}

