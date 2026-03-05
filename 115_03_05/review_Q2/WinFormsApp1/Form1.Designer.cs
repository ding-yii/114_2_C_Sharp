namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox grpOilAndLube;
        private System.Windows.Forms.CheckBox chkOilChange;
        private System.Windows.Forms.CheckBox chkLubeService;

        private System.Windows.Forms.GroupBox grpCleaning;
        private System.Windows.Forms.CheckBox chkRadiatorFlush;
        private System.Windows.Forms.CheckBox chkTransFlush;

        private System.Windows.Forms.GroupBox grpOtherServices;
        private System.Windows.Forms.CheckBox chkInspection;
        private System.Windows.Forms.CheckBox chkMufflerReplace;
        private System.Windows.Forms.CheckBox chkTireRotation;

        private System.Windows.Forms.GroupBox grpPartsAndLabor;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.TextBox txtPartsCost;
        private System.Windows.Forms.Label lblLaborHours;
        private System.Windows.Forms.TextBox txtLaborHours;

        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblServiceAndLabor;
        private System.Windows.Forms.TextBox txtServiceAndLabor;
        private System.Windows.Forms.Label lblPartsSummary;
        private System.Windows.Forms.TextBox txtPartsSummary;
        private System.Windows.Forms.Label lblPartsTax;
        private System.Windows.Forms.TextBox txtPartsTax;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.TextBox txtTotalCost;

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpOilAndLube = new GroupBox();
            chkOilChange = new CheckBox();
            chkLubeService = new CheckBox();
            grpCleaning = new GroupBox();
            chkRadiatorFlush = new CheckBox();
            chkTransFlush = new CheckBox();
            grpOtherServices = new GroupBox();
            chkInspection = new CheckBox();
            chkMufflerReplace = new CheckBox();
            chkTireRotation = new CheckBox();
            grpPartsAndLabor = new GroupBox();
            lblParts = new Label();
            txtPartsCost = new TextBox();
            lblLaborHours = new Label();
            txtLaborHours = new TextBox();
            grpSummary = new GroupBox();
            lblServiceAndLabor = new Label();
            txtServiceAndLabor = new TextBox();
            lblPartsSummary = new Label();
            txtPartsSummary = new TextBox();
            lblPartsTax = new Label();
            txtPartsTax = new TextBox();
            lblTotalCost = new Label();
            txtTotalCost = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            grpOilAndLube.SuspendLayout();
            grpCleaning.SuspendLayout();
            grpOtherServices.SuspendLayout();
            grpPartsAndLabor.SuspendLayout();
            grpSummary.SuspendLayout();
            SuspendLayout();
            // 
            // grpOilAndLube
            // 
            grpOilAndLube.Controls.Add(chkOilChange);
            grpOilAndLube.Controls.Add(chkLubeService);
            grpOilAndLube.Location = new Point(12, 12);
            grpOilAndLube.Name = "grpOilAndLube";
            grpOilAndLube.Size = new Size(190, 80);
            grpOilAndLube.TabIndex = 0;
            grpOilAndLube.TabStop = false;
            grpOilAndLube.Text = "機油和潤滑";
            // 
            // chkOilChange
            // 
            chkOilChange.AutoSize = true;
            chkOilChange.Location = new Point(10, 22);
            chkOilChange.Name = "chkOilChange";
            chkOilChange.Size = new Size(190, 27);
            chkOilChange.TabIndex = 0;
            chkOilChange.Text = "更換機油 (NT$780)";
            // 
            // chkLubeService
            // 
            chkLubeService.AutoSize = true;
            chkLubeService.Location = new Point(10, 46);
            chkLubeService.Name = "chkLubeService";
            chkLubeService.Size = new Size(190, 27);
            chkLubeService.TabIndex = 1;
            chkLubeService.Text = "潤滑保養 (NT$540)";
            // 
            // grpCleaning
            // 
            grpCleaning.Controls.Add(chkRadiatorFlush);
            grpCleaning.Controls.Add(chkTransFlush);
            grpCleaning.Location = new Point(212, 12);
            grpCleaning.Name = "grpCleaning";
            grpCleaning.Size = new Size(241, 80);
            grpCleaning.TabIndex = 1;
            grpCleaning.TabStop = false;
            grpCleaning.Text = "清洗服務";
            // 
            // chkRadiatorFlush
            // 
            chkRadiatorFlush.AutoSize = true;
            chkRadiatorFlush.Location = new Point(10, 22);
            chkRadiatorFlush.Name = "chkRadiatorFlush";
            chkRadiatorFlush.Size = new Size(190, 27);
            chkRadiatorFlush.TabIndex = 0;
            chkRadiatorFlush.Text = "水箱清洗 (NT$900)";
            // 
            // chkTransFlush
            // 
            chkTransFlush.AutoSize = true;
            chkTransFlush.Location = new Point(10, 46);
            chkTransFlush.Name = "chkTransFlush";
            chkTransFlush.Size = new Size(222, 27);
            chkTransFlush.TabIndex = 1;
            chkTransFlush.Text = "變速箱清洗 (NT$2,400)";
            // 
            // grpOtherServices
            // 
            grpOtherServices.Controls.Add(chkInspection);
            grpOtherServices.Controls.Add(chkMufflerReplace);
            grpOtherServices.Controls.Add(chkTireRotation);
            grpOtherServices.Location = new Point(12, 100);
            grpOtherServices.Name = "grpOtherServices";
            grpOtherServices.Size = new Size(223, 110);
            grpOtherServices.TabIndex = 2;
            grpOtherServices.TabStop = false;
            grpOtherServices.Text = "其他服務";
            // 
            // chkInspection
            // 
            chkInspection.AutoSize = true;
            chkInspection.Location = new Point(10, 22);
            chkInspection.Name = "chkInspection";
            chkInspection.Size = new Size(154, 27);
            chkInspection.TabIndex = 0;
            chkInspection.Text = "檢驗 (NT$450)";
            // 
            // chkMufflerReplace
            // 
            chkMufflerReplace.AutoSize = true;
            chkMufflerReplace.Location = new Point(10, 46);
            chkMufflerReplace.Name = "chkMufflerReplace";
            chkMufflerReplace.Size = new Size(222, 27);
            chkMufflerReplace.TabIndex = 1;
            chkMufflerReplace.Text = "更換消音器 (NT$3,000)";
            // 
            // chkTireRotation
            // 
            chkTireRotation.AutoSize = true;
            chkTireRotation.Location = new Point(10, 70);
            chkTireRotation.Name = "chkTireRotation";
            chkTireRotation.Size = new Size(190, 27);
            chkTireRotation.TabIndex = 2;
            chkTireRotation.Text = "輪胎換位 (NT$600)";
            // 
            // grpPartsAndLabor
            // 
            grpPartsAndLabor.Controls.Add(lblParts);
            grpPartsAndLabor.Controls.Add(txtPartsCost);
            grpPartsAndLabor.Controls.Add(lblLaborHours);
            grpPartsAndLabor.Controls.Add(txtLaborHours);
            grpPartsAndLabor.Location = new Point(241, 100);
            grpPartsAndLabor.Name = "grpPartsAndLabor";
            grpPartsAndLabor.Size = new Size(223, 114);
            grpPartsAndLabor.TabIndex = 3;
            grpPartsAndLabor.TabStop = false;
            grpPartsAndLabor.Text = "零件和工時";
            // 
            // lblParts
            // 
            lblParts.AutoSize = true;
            lblParts.Location = new Point(10, 28);
            lblParts.Name = "lblParts";
            lblParts.Size = new Size(102, 23);
            lblParts.TabIndex = 0;
            lblParts.Text = "零件 (NT$):";
            // 
            // txtPartsCost
            // 
            txtPartsCost.Location = new Point(107, 25);
            txtPartsCost.Name = "txtPartsCost";
            txtPartsCost.Size = new Size(110, 30);
            txtPartsCost.TabIndex = 1;
            // 
            // lblLaborHours
            // 
            lblLaborHours.AutoSize = true;
            lblLaborHours.Location = new Point(10, 60);
            lblLaborHours.Name = "lblLaborHours";
            lblLaborHours.Size = new Size(121, 23);
            lblLaborHours.TabIndex = 2;
            lblLaborHours.Text = "工時數 (小時):";
            // 
            // txtLaborHours
            // 
            txtLaborHours.Location = new Point(130, 60);
            txtLaborHours.Name = "txtLaborHours";
            txtLaborHours.Size = new Size(60, 30);
            txtLaborHours.TabIndex = 3;
            // 
            // grpSummary
            // 
            grpSummary.Controls.Add(lblServiceAndLabor);
            grpSummary.Controls.Add(txtServiceAndLabor);
            grpSummary.Controls.Add(lblPartsSummary);
            grpSummary.Controls.Add(txtPartsSummary);
            grpSummary.Controls.Add(lblPartsTax);
            grpSummary.Controls.Add(txtPartsTax);
            grpSummary.Controls.Add(lblTotalCost);
            grpSummary.Controls.Add(txtTotalCost);
            grpSummary.Location = new Point(12, 220);
            grpSummary.Name = "grpSummary";
            grpSummary.Size = new Size(423, 142);
            grpSummary.TabIndex = 4;
            grpSummary.TabStop = false;
            grpSummary.Text = "費用摘要";
            // 
            // lblServiceAndLabor
            // 
            lblServiceAndLabor.AutoSize = true;
            lblServiceAndLabor.Location = new Point(10, 26);
            lblServiceAndLabor.Name = "lblServiceAndLabor";
            lblServiceAndLabor.Size = new Size(100, 23);
            lblServiceAndLabor.TabIndex = 0;
            lblServiceAndLabor.Text = "服務與工資";
            // 
            // txtServiceAndLabor
            // 
            txtServiceAndLabor.Location = new Point(140, 22);
            txtServiceAndLabor.Name = "txtServiceAndLabor";
            txtServiceAndLabor.ReadOnly = true;
            txtServiceAndLabor.Size = new Size(120, 30);
            txtServiceAndLabor.TabIndex = 1;
            // 
            // lblPartsSummary
            // 
            lblPartsSummary.AutoSize = true;
            lblPartsSummary.Location = new Point(11, 61);
            lblPartsSummary.Name = "lblPartsSummary";
            lblPartsSummary.Size = new Size(46, 23);
            lblPartsSummary.TabIndex = 2;
            lblPartsSummary.Text = "零件";
            // 
            // txtPartsSummary
            // 
            txtPartsSummary.Location = new Point(140, 58);
            txtPartsSummary.Name = "txtPartsSummary";
            txtPartsSummary.ReadOnly = true;
            txtPartsSummary.Size = new Size(120, 30);
            txtPartsSummary.TabIndex = 3;
            // 
            // lblPartsTax
            // 
            lblPartsTax.AutoSize = true;
            lblPartsTax.Location = new Point(11, 104);
            lblPartsTax.Name = "lblPartsTax";
            lblPartsTax.Size = new Size(99, 23);
            lblPartsTax.TabIndex = 4;
            lblPartsTax.Text = "稅金 (零件)";
            // 
            // txtPartsTax
            // 
            txtPartsTax.Location = new Point(140, 97);
            txtPartsTax.Name = "txtPartsTax";
            txtPartsTax.ReadOnly = true;
            txtPartsTax.Size = new Size(120, 30);
            txtPartsTax.TabIndex = 5;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(270, 22);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(64, 23);
            lblTotalCost.TabIndex = 6;
            lblTotalCost.Text = "總費用";
            // 
            // txtTotalCost
            // 
            txtTotalCost.Location = new Point(270, 44);
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.ReadOnly = true;
            txtTotalCost.Size = new Size(110, 30);
            txtTotalCost.TabIndex = 7;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(55, 386);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(90, 30);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "計算總額";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(182, 386);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 30);
            btnClear.TabIndex = 6;
            btnClear.Text = "清除";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(282, 386);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 30);
            btnExit.TabIndex = 7;
            btnExit.Text = "離開";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 464);
            Controls.Add(grpOilAndLube);
            Controls.Add(grpCleaning);
            Controls.Add(grpOtherServices);
            Controls.Add(grpPartsAndLabor);
            Controls.Add(grpSummary);
            Controls.Add(btnCalculate);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Name = "Form1";
            Text = "汽車維修服務";
            grpOilAndLube.ResumeLayout(false);
            grpOilAndLube.PerformLayout();
            grpCleaning.ResumeLayout(false);
            grpCleaning.PerformLayout();
            grpOtherServices.ResumeLayout(false);
            grpOtherServices.PerformLayout();
            grpPartsAndLabor.ResumeLayout(false);
            grpPartsAndLabor.PerformLayout();
            grpSummary.ResumeLayout(false);
            grpSummary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
