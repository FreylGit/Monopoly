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
            SuspendLayout();
            // 
            // LBPallet
            // 
            LBPallet.FormattingEnabled = true;
            LBPallet.ItemHeight = 20;
            LBPallet.Location = new Point(12, 93);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoadTestDate);
            Controls.Add(LBPallet);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox LBPallet;
        private Button btnLoadTestDate;
    }
}