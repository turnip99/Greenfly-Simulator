namespace Greenfly_Simulator
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblAdults = new System.Windows.Forms.Label();
            this.lblJuveniles = new System.Windows.Forms.Label();
            this.lblSeniles = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblGeneration = new System.Windows.Forms.Label();
            this.lblSenilesS = new System.Windows.Forms.Label();
            this.lblJuvenilesS = new System.Windows.Forms.Label();
            this.lblAdultsS = new System.Windows.Forms.Label();
            this.lblSurvival = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSeniles = new System.Windows.Forms.TextBox();
            this.txtAdults = new System.Windows.Forms.TextBox();
            this.txtJuveniles = new System.Windows.Forms.TextBox();
            this.txtGeneration = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.timerGenerations = new System.Windows.Forms.Timer(this.components);
            this.btnLadybird = new System.Windows.Forms.Button();
            this.lblBirth = new System.Windows.Forms.Label();
            this.UDSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblPercent1 = new System.Windows.Forms.Label();
            this.UDBirth = new System.Windows.Forms.NumericUpDown();
            this.lblPercent2 = new System.Windows.Forms.Label();
            this.UDYoung = new System.Windows.Forms.NumericUpDown();
            this.lblPercent3 = new System.Windows.Forms.Label();
            this.UDAdult = new System.Windows.Forms.NumericUpDown();
            this.lblPercent4 = new System.Windows.Forms.Label();
            this.UDOld = new System.Windows.Forms.NumericUpDown();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.UDDisease = new System.Windows.Forms.NumericUpDown();
            this.lblDisease = new System.Windows.Forms.Label();
            this.txtDiseaseStatus = new System.Windows.Forms.TextBox();
            this.lblDiseaseStatus = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UDSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDBirth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDYoung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDAdult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDDisease)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblAdults
            // 
            this.lblAdults.AutoSize = true;
            this.lblAdults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdults.Location = new System.Drawing.Point(1623, 211);
            this.lblAdults.Name = "lblAdults";
            this.lblAdults.Size = new System.Drawing.Size(65, 20);
            this.lblAdults.TabIndex = 3;
            this.lblAdults.Text = "Adults:";
            // 
            // lblJuveniles
            // 
            this.lblJuveniles.AutoSize = true;
            this.lblJuveniles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuveniles.Location = new System.Drawing.Point(1623, 177);
            this.lblJuveniles.Name = "lblJuveniles";
            this.lblJuveniles.Size = new System.Drawing.Size(88, 20);
            this.lblJuveniles.TabIndex = 2;
            this.lblJuveniles.Text = "Juveniles:";
            // 
            // lblSeniles
            // 
            this.lblSeniles.AutoSize = true;
            this.lblSeniles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeniles.Location = new System.Drawing.Point(1623, 245);
            this.lblSeniles.Name = "lblSeniles";
            this.lblSeniles.Size = new System.Drawing.Size(73, 20);
            this.lblSeniles.TabIndex = 4;
            this.lblSeniles.Text = "Seniles:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(1623, 359);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(66, 20);
            this.lblSpeed.TabIndex = 5;
            this.lblSpeed.Text = "Speed:";
            // 
            // lblGeneration
            // 
            this.lblGeneration.AutoSize = true;
            this.lblGeneration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneration.Location = new System.Drawing.Point(1623, 143);
            this.lblGeneration.Name = "lblGeneration";
            this.lblGeneration.Size = new System.Drawing.Size(104, 20);
            this.lblGeneration.TabIndex = 1;
            this.lblGeneration.Text = "Generation:";
            // 
            // lblSenilesS
            // 
            this.lblSenilesS.AutoSize = true;
            this.lblSenilesS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenilesS.Location = new System.Drawing.Point(1623, 578);
            this.lblSenilesS.Name = "lblSenilesS";
            this.lblSenilesS.Size = new System.Drawing.Size(73, 20);
            this.lblSenilesS.TabIndex = 10;
            this.lblSenilesS.Text = "Seniles:";
            // 
            // lblJuvenilesS
            // 
            this.lblJuvenilesS.AutoSize = true;
            this.lblJuvenilesS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuvenilesS.Location = new System.Drawing.Point(1623, 510);
            this.lblJuvenilesS.Name = "lblJuvenilesS";
            this.lblJuvenilesS.Size = new System.Drawing.Size(88, 20);
            this.lblJuvenilesS.TabIndex = 8;
            this.lblJuvenilesS.Text = "Juveniles:";
            // 
            // lblAdultsS
            // 
            this.lblAdultsS.AutoSize = true;
            this.lblAdultsS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdultsS.Location = new System.Drawing.Point(1623, 544);
            this.lblAdultsS.Name = "lblAdultsS";
            this.lblAdultsS.Size = new System.Drawing.Size(65, 20);
            this.lblAdultsS.TabIndex = 9;
            this.lblAdultsS.Text = "Adults:";
            // 
            // lblSurvival
            // 
            this.lblSurvival.AutoSize = true;
            this.lblSurvival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurvival.Location = new System.Drawing.Point(1623, 476);
            this.lblSurvival.Name = "lblSurvival";
            this.lblSurvival.Size = new System.Drawing.Size(129, 20);
            this.lblSurvival.TabIndex = 7;
            this.lblSurvival.Text = "Survival Rates:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1627, 699);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(174, 61);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add New Fly";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSeniles
            // 
            this.txtSeniles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeniles.Location = new System.Drawing.Point(1747, 245);
            this.txtSeniles.Name = "txtSeniles";
            this.txtSeniles.ReadOnly = true;
            this.txtSeniles.Size = new System.Drawing.Size(100, 20);
            this.txtSeniles.TabIndex = 18;
            // 
            // txtAdults
            // 
            this.txtAdults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdults.Location = new System.Drawing.Point(1747, 211);
            this.txtAdults.Name = "txtAdults";
            this.txtAdults.ReadOnly = true;
            this.txtAdults.Size = new System.Drawing.Size(100, 20);
            this.txtAdults.TabIndex = 17;
            // 
            // txtJuveniles
            // 
            this.txtJuveniles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJuveniles.Location = new System.Drawing.Point(1747, 177);
            this.txtJuveniles.Name = "txtJuveniles";
            this.txtJuveniles.ReadOnly = true;
            this.txtJuveniles.Size = new System.Drawing.Size(100, 20);
            this.txtJuveniles.TabIndex = 16;
            // 
            // txtGeneration
            // 
            this.txtGeneration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneration.Location = new System.Drawing.Point(1747, 143);
            this.txtGeneration.Name = "txtGeneration";
            this.txtGeneration.ReadOnly = true;
            this.txtGeneration.Size = new System.Drawing.Size(100, 20);
            this.txtGeneration.TabIndex = 15;
            this.txtGeneration.Text = "0";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1627, 620);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(174, 61);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // timerGenerations
            // 
            this.timerGenerations.Enabled = true;
            this.timerGenerations.Interval = 1000;
            this.timerGenerations.Tick += new System.EventHandler(this.timerGenerations_Tick);
            // 
            // btnLadybird
            // 
            this.btnLadybird.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLadybird.Location = new System.Drawing.Point(1627, 778);
            this.btnLadybird.Name = "btnLadybird";
            this.btnLadybird.Size = new System.Drawing.Size(174, 61);
            this.btnLadybird.TabIndex = 26;
            this.btnLadybird.Text = "Add Ladybird";
            this.btnLadybird.UseVisualStyleBackColor = true;
            this.btnLadybird.Click += new System.EventHandler(this.btnLadybird_Click);
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirth.Location = new System.Drawing.Point(1623, 393);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(96, 20);
            this.lblBirth.TabIndex = 6;
            this.lblBirth.Text = "Birth Rate:";
            // 
            // UDSpeed
            // 
            this.UDSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UDSpeed.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UDSpeed.Location = new System.Drawing.Point(1747, 356);
            this.UDSpeed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UDSpeed.Name = "UDSpeed";
            this.UDSpeed.Size = new System.Drawing.Size(100, 24);
            this.UDSpeed.TabIndex = 19;
            this.UDSpeed.Tag = "";
            this.UDSpeed.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblPercent1
            // 
            this.lblPercent1.AutoSize = true;
            this.lblPercent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent1.Location = new System.Drawing.Point(1848, 358);
            this.lblPercent1.Name = "lblPercent1";
            this.lblPercent1.Size = new System.Drawing.Size(22, 18);
            this.lblPercent1.TabIndex = 11;
            this.lblPercent1.Text = "%";
            // 
            // UDBirth
            // 
            this.UDBirth.DecimalPlaces = 1;
            this.UDBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UDBirth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.UDBirth.Location = new System.Drawing.Point(1747, 390);
            this.UDBirth.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.UDBirth.Name = "UDBirth";
            this.UDBirth.Size = new System.Drawing.Size(100, 24);
            this.UDBirth.TabIndex = 20;
            this.UDBirth.Tag = "";
            this.UDBirth.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // lblPercent2
            // 
            this.lblPercent2.AutoSize = true;
            this.lblPercent2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent2.Location = new System.Drawing.Point(1848, 509);
            this.lblPercent2.Name = "lblPercent2";
            this.lblPercent2.Size = new System.Drawing.Size(22, 18);
            this.lblPercent2.TabIndex = 12;
            this.lblPercent2.Text = "%";
            // 
            // UDYoung
            // 
            this.UDYoung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UDYoung.Location = new System.Drawing.Point(1747, 507);
            this.UDYoung.Name = "UDYoung";
            this.UDYoung.Size = new System.Drawing.Size(100, 24);
            this.UDYoung.TabIndex = 21;
            this.UDYoung.Tag = "";
            this.UDYoung.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblPercent3
            // 
            this.lblPercent3.AutoSize = true;
            this.lblPercent3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent3.Location = new System.Drawing.Point(1848, 543);
            this.lblPercent3.Name = "lblPercent3";
            this.lblPercent3.Size = new System.Drawing.Size(22, 18);
            this.lblPercent3.TabIndex = 13;
            this.lblPercent3.Text = "%";
            // 
            // UDAdult
            // 
            this.UDAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UDAdult.Location = new System.Drawing.Point(1747, 541);
            this.UDAdult.Name = "UDAdult";
            this.UDAdult.Size = new System.Drawing.Size(100, 24);
            this.UDAdult.TabIndex = 22;
            this.UDAdult.Tag = "";
            this.UDAdult.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblPercent4
            // 
            this.lblPercent4.AutoSize = true;
            this.lblPercent4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent4.Location = new System.Drawing.Point(1848, 577);
            this.lblPercent4.Name = "lblPercent4";
            this.lblPercent4.Size = new System.Drawing.Size(22, 18);
            this.lblPercent4.TabIndex = 14;
            this.lblPercent4.Text = "%";
            // 
            // UDOld
            // 
            this.UDOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UDOld.Location = new System.Drawing.Point(1747, 575);
            this.UDOld.Name = "UDOld";
            this.UDOld.Size = new System.Drawing.Size(100, 24);
            this.UDOld.TabIndex = 23;
            this.UDOld.Tag = "";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(1747, 279);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 28;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1623, 279);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 20);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "Total:";
            // 
            // UDDisease
            // 
            this.UDDisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UDDisease.Location = new System.Drawing.Point(1748, 424);
            this.UDDisease.Maximum = new decimal(new int[] {
            144,
            0,
            0,
            0});
            this.UDDisease.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UDDisease.Name = "UDDisease";
            this.UDDisease.Size = new System.Drawing.Size(100, 24);
            this.UDDisease.TabIndex = 30;
            this.UDDisease.Tag = "";
            this.UDDisease.Value = new decimal(new int[] {
            110,
            0,
            0,
            0});
            // 
            // lblDisease
            // 
            this.lblDisease.AutoSize = true;
            this.lblDisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisease.Location = new System.Drawing.Point(1623, 427);
            this.lblDisease.Name = "lblDisease";
            this.lblDisease.Size = new System.Drawing.Size(125, 20);
            this.lblDisease.TabIndex = 29;
            this.lblDisease.Text = "Disease Point:";
            // 
            // txtDiseaseStatus
            // 
            this.txtDiseaseStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiseaseStatus.Location = new System.Drawing.Point(1747, 313);
            this.txtDiseaseStatus.Name = "txtDiseaseStatus";
            this.txtDiseaseStatus.ReadOnly = true;
            this.txtDiseaseStatus.Size = new System.Drawing.Size(100, 20);
            this.txtDiseaseStatus.TabIndex = 32;
            // 
            // lblDiseaseStatus
            // 
            this.lblDiseaseStatus.AutoSize = true;
            this.lblDiseaseStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiseaseStatus.Location = new System.Drawing.Point(1623, 313);
            this.lblDiseaseStatus.Name = "lblDiseaseStatus";
            this.lblDiseaseStatus.Size = new System.Drawing.Size(79, 20);
            this.lblDiseaseStatus.TabIndex = 31;
            this.lblDiseaseStatus.Text = "Disease:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1747, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 38);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(1747, 71);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(97, 38);
            this.btnLoad.TabIndex = 34;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1871, 873);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDiseaseStatus);
            this.Controls.Add(this.lblDiseaseStatus);
            this.Controls.Add(this.UDDisease);
            this.Controls.Add(this.lblDisease);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPercent4);
            this.Controls.Add(this.UDOld);
            this.Controls.Add(this.lblPercent3);
            this.Controls.Add(this.UDAdult);
            this.Controls.Add(this.lblPercent2);
            this.Controls.Add(this.UDYoung);
            this.Controls.Add(this.UDBirth);
            this.Controls.Add(this.lblPercent1);
            this.Controls.Add(this.UDSpeed);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.btnLadybird);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtGeneration);
            this.Controls.Add(this.txtSeniles);
            this.Controls.Add(this.txtAdults);
            this.Controls.Add(this.txtJuveniles);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSurvival);
            this.Controls.Add(this.lblSenilesS);
            this.Controls.Add(this.lblJuvenilesS);
            this.Controls.Add(this.lblAdultsS);
            this.Controls.Add(this.lblGeneration);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblSeniles);
            this.Controls.Add(this.lblJuveniles);
            this.Controls.Add(this.lblAdults);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Greenfly Simulator";
            this.TransparencyKey = System.Drawing.Color.DodgerBlue;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.UDSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDBirth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDYoung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDAdult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDDisease)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblAdults;
        private System.Windows.Forms.Label lblJuveniles;
        private System.Windows.Forms.Label lblSeniles;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblGeneration;
        private System.Windows.Forms.Label lblSenilesS;
        private System.Windows.Forms.Label lblJuvenilesS;
        private System.Windows.Forms.Label lblAdultsS;
        private System.Windows.Forms.Label lblSurvival;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSeniles;
        private System.Windows.Forms.TextBox txtAdults;
        private System.Windows.Forms.TextBox txtJuveniles;
        private System.Windows.Forms.TextBox txtGeneration;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Timer timerGenerations;
        private System.Windows.Forms.Button btnLadybird;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.NumericUpDown UDSpeed;
        private System.Windows.Forms.Label lblPercent1;
        private System.Windows.Forms.NumericUpDown UDBirth;
        private System.Windows.Forms.Label lblPercent2;
        private System.Windows.Forms.NumericUpDown UDYoung;
        private System.Windows.Forms.Label lblPercent3;
        private System.Windows.Forms.NumericUpDown UDAdult;
        private System.Windows.Forms.Label lblPercent4;
        private System.Windows.Forms.NumericUpDown UDOld;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.NumericUpDown UDDisease;
        private System.Windows.Forms.Label lblDisease;
        private System.Windows.Forms.TextBox txtDiseaseStatus;
        private System.Windows.Forms.Label lblDiseaseStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
    }
}

