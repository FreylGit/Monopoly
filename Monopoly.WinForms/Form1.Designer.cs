namespace Monopoly.WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            LBPallet = new ListBox();
            btnLoadTestDate = new Button();
            btnGroupByExpiryDate = new Button();
            btnSortByExpirationDate = new Button();
            btnSortedGroupsByWeight = new Button();
            btnPalletMaxExpiryDateSortWigth = new Button();
            SuspendLayout();
            // 
            // LBPallet
            // 
            LBPallet.FormattingEnabled = true;
            LBPallet.ItemHeight = 20;
            LBPallet.Location = new Point(12, 134);
            LBPallet.Name = "LBPallet";
            LBPallet.Size = new Size(776, 304);
            LBPallet.TabIndex = 0;
            // 
            // btnLoadTestDate
            // 
            btnLoadTestDate.Location = new Point(21, 23);
            btnLoadTestDate.Name = "btnLoadTestDate";
            btnLoadTestDate.Size = new Size(221, 49);
            btnLoadTestDate.TabIndex = 1;
            btnLoadTestDate.Text = "Загрузить тестовые данные";
            btnLoadTestDate.UseVisualStyleBackColor = true;
            btnLoadTestDate.Click += btnLoadTestDate_Click;
            // 
            // btnGroupByExpiryDate
            // 
            btnGroupByExpiryDate.Location = new Point(258, 23);
            btnGroupByExpiryDate.Name = "btnGroupByExpiryDate";
            btnGroupByExpiryDate.Size = new Size(218, 49);
            btnGroupByExpiryDate.TabIndex = 2;
            btnGroupByExpiryDate.Text = "Сгруппировать все паллеты по сроку годности";
            btnGroupByExpiryDate.UseVisualStyleBackColor = true;
            btnGroupByExpiryDate.Click += btnGroupByExpiryDate_Click;
            // 
            // btnSortByExpirationDate
            // 
            btnSortByExpirationDate.Location = new Point(491, 23);
            btnSortByExpirationDate.Name = "btnSortByExpirationDate";
            btnSortByExpirationDate.Size = new Size(229, 49);
            btnSortByExpirationDate.TabIndex = 3;
            btnSortByExpirationDate.Text = "отсортировать по возрастанию срока годности";
            btnSortByExpirationDate.UseVisualStyleBackColor = true;
            btnSortByExpirationDate.Click += btnSortByExpirationDate_Click;
            // 
            // btnSortedGroupsByWeight
            // 
            btnSortedGroupsByWeight.Location = new Point(21, 78);
            btnSortedGroupsByWeight.Name = "btnSortedGroupsByWeight";
            btnSortedGroupsByWeight.Size = new Size(221, 50);
            btnSortedGroupsByWeight.TabIndex = 4;
            btnSortedGroupsByWeight.Text = "Отсортировать паллеты по весу";
            btnSortedGroupsByWeight.UseVisualStyleBackColor = true;
            btnSortedGroupsByWeight.Click += btnSortedGroupsByWeight_Click;
            // 
            // btnPalletMaxExpiryDateSortWigth
            // 
            btnPalletMaxExpiryDateSortWigth.Location = new Point(258, 78);
            btnPalletMaxExpiryDateSortWigth.Name = "btnPalletMaxExpiryDateSortWigth";
            btnPalletMaxExpiryDateSortWigth.Size = new Size(134, 50);
            btnPalletMaxExpiryDateSortWigth.TabIndex = 5;
            btnPalletMaxExpiryDateSortWigth.Text = "3 паллеты";
            btnPalletMaxExpiryDateSortWigth.UseVisualStyleBackColor = true;
            btnPalletMaxExpiryDateSortWigth.Click += btnPalletMaxExpiryDateSortWigth_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPalletMaxExpiryDateSortWigth);
            Controls.Add(btnSortedGroupsByWeight);
            Controls.Add(btnSortByExpirationDate);
            Controls.Add(btnGroupByExpiryDate);
            Controls.Add(btnLoadTestDate);
            Controls.Add(LBPallet);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox LBPallet;
        private Button btnLoadTestDate;
        private Button btnGroupByExpiryDate;
        private Button btnSortByExpirationDate;
        private Button btnSortedGroupsByWeight;
        private Button btnPalletMaxExpiryDateSortWigth;
    }
}