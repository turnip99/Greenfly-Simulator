namespace Greenfly_Simulator
{
    partial class StartUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUp));
            this.lblYoung = new System.Windows.Forms.Label();
            this.lblAdults = new System.Windows.Forms.Label();
            this.lblOld = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.UDYoung = new System.Windows.Forms.NumericUpDown();
            this.UDAdult = new System.Windows.Forms.NumericUpDown();
            this.UDOld = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.UDYoung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDAdult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDOld)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYoung
            // 
            this.lblYoung.AutoSize = true;
            this.lblYoung.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYoung.Location = new System.Drawing.Point(12, 15);
            this.lblYoung.Name = "lblYoung";
            this.lblYoung.Size = new System.Drawing.Size(214, 25);
            this.lblYoung.TabIndex = 0;
            this.lblYoung.Text = "Number of Juveniles:";
            // 
            // lblAdults
            // 
            this.lblAdults.AutoSize = true;
            this.lblAdults.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdults.Location = new System.Drawing.Point(12, 65);
            this.lblAdults.Name = "lblAdults";
            this.lblAdults.Size = new System.Drawing.Size(183, 25);
            this.lblAdults.TabIndex = 1;
            this.lblAdults.Text = "Number of Adults:";
            // 
            // lblOld
            // 
            this.lblOld.AutoSize = true;
            this.lblOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOld.Location = new System.Drawing.Point(12, 115);
            this.lblOld.Name = "lblOld";
            this.lblOld.Size = new System.Drawing.Size(194, 25);
            this.lblOld.TabIndex = 2;
            this.lblOld.Text = "Number of Seniles:";
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(56, 155);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(227, 52);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "Begin Simulation";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // UDYoung
            // 
            this.UDYoung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UDYoung.Location = new System.Drawing.Point(227, 15);
            this.UDYoung.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.UDYoung.Name = "UDYoung";
            this.UDYoung.Size = new System.Drawing.Size(120, 26);
            this.UDYoung.TabIndex = 7;
            this.UDYoung.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // UDAdult
            // 
            this.UDAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UDAdult.Location = new System.Drawing.Point(227, 65);
            this.UDAdult.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.UDAdult.Name = "UDAdult";
            this.UDAdult.Size = new System.Drawing.Size(120, 26);
            this.UDAdult.TabIndex = 8;
            this.UDAdult.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // UDOld
            // 
            this.UDOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UDOld.Location = new System.Drawing.Point(227, 115);
            this.UDOld.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.UDOld.Name = "UDOld";
            this.UDOld.Size = new System.Drawing.Size(120, 26);
            this.UDOld.TabIndex = 9;
            this.UDOld.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // StartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 218);
            this.Controls.Add(this.UDOld);
            this.Controls.Add(this.UDAdult);
            this.Controls.Add(this.UDYoung);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblOld);
            this.Controls.Add(this.lblAdults);
            this.Controls.Add(this.lblYoung);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartUp";
            this.Text = "StartUp";
            ((System.ComponentModel.ISupportInitialize)(this.UDYoung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDAdult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDOld)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYoung;
        private System.Windows.Forms.Label lblAdults;
        private System.Windows.Forms.Label lblOld;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.NumericUpDown UDYoung;
        private System.Windows.Forms.NumericUpDown UDAdult;
        private System.Windows.Forms.NumericUpDown UDOld;
    }
}