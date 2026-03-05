namespace review_Q3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // UI controls
        private System.Windows.Forms.GroupBox groupBoxNumbers;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.TextBox txtNum4;
        private System.Windows.Forms.TextBox txtNum5;

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.ListBox listBoxLottery;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Label labelResultTitle;

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
            groupBoxNumbers = new GroupBox();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtNum3 = new TextBox();
            txtNum4 = new TextBox();
            txtNum5 = new TextBox();
            btnGenerate = new Button();
            btnOpen = new Button();
            btnExit = new Button();
            listBoxLottery = new ListBox();
            groupBoxResult = new GroupBox();
            labelResultTitle = new Label();
            groupBoxNumbers.SuspendLayout();
            groupBoxResult.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxNumbers
            // 
            groupBoxNumbers.Controls.Add(txtNum1);
            groupBoxNumbers.Controls.Add(txtNum4);
            groupBoxNumbers.Controls.Add(txtNum2);
            groupBoxNumbers.Controls.Add(txtNum3);
            groupBoxNumbers.Controls.Add(txtNum5);
            groupBoxNumbers.Location = new Point(12, 12);
            groupBoxNumbers.Name = "groupBoxNumbers";
            groupBoxNumbers.Size = new Size(760, 120);
            groupBoxNumbers.TabIndex = 0;
            groupBoxNumbers.TabStop = false;
            groupBoxNumbers.Text = "樂透號碼產生器";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(155, 47);
            txtNum1.Name = "txtNum1";
            txtNum1.ReadOnly = true;
            txtNum1.Size = new Size(110, 48);
            txtNum1.TabIndex = 0;
            txtNum1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(298, 47);
            txtNum2.Name = "txtNum2";
            txtNum2.ReadOnly = true;
            txtNum2.Size = new Size(110, 48);
            txtNum2.TabIndex = 1;
            txtNum2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNum3
            // 
            txtNum3.Location = new Point(428, 47);
            txtNum3.Name = "txtNum3";
            txtNum3.ReadOnly = true;
            txtNum3.Size = new Size(110, 48);
            txtNum3.TabIndex = 2;
            txtNum3.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNum4
            // 
            txtNum4.Location = new Point(570, 47);
            txtNum4.Name = "txtNum4";
            txtNum4.ReadOnly = true;
            txtNum4.Size = new Size(110, 48);
            txtNum4.TabIndex = 3;
            txtNum4.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNum5
            // 
            txtNum5.Location = new Point(28, 47);
            txtNum5.Name = "txtNum5";
            txtNum5.ReadOnly = true;
            txtNum5.Size = new Size(110, 48);
            txtNum5.TabIndex = 4;
            txtNum5.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(24, 138);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(187, 60);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "產生號碼";
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(289, 138);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(187, 60);
            btnOpen.TabIndex = 2;
            btnOpen.Text = "開獎號碼";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(532, 138);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(160, 60);
            btnExit.TabIndex = 3;
            btnExit.Text = "離開";
            // 
            // listBoxLottery
            // 
            listBoxLottery.ItemHeight = 40;
            listBoxLottery.Location = new Point(24, 248);
            listBoxLottery.Name = "listBoxLottery";
            listBoxLottery.Size = new Size(360, 204);
            listBoxLottery.TabIndex = 4;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(labelResultTitle);
            groupBoxResult.Location = new Point(390, 242);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(382, 210);
            groupBoxResult.TabIndex = 5;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "中獎比對結果";
            groupBoxResult.Enter += groupBoxResult_Enter;
            // 
            // labelResultTitle
            // 
            labelResultTitle.Location = new Point(6, 69);
            labelResultTitle.Name = "labelResultTitle";
            labelResultTitle.Size = new Size(360, 40);
            labelResultTitle.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(21F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 464);
            Controls.Add(groupBoxNumbers);
            Controls.Add(btnOpen);
            Controls.Add(btnGenerate);
            Controls.Add(btnExit);
            Controls.Add(listBoxLottery);
            Controls.Add(groupBoxResult);
            Font = new Font("Microsoft Sans Serif", 18F);
            MinimumSize = new Size(820, 520);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "樂透號碼產生器";
            groupBoxNumbers.ResumeLayout(false);
            groupBoxNumbers.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
