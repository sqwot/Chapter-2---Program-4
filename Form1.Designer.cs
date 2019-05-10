namespace Chapter_2___Program_4 {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.changeTest = new System.Windows.Forms.Button();
            this.enableCheckBox = new System.Windows.Forms.CheckBox();
            this.labelToChange = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // changeTest
            // 
            this.changeTest.Location = new System.Drawing.Point(12, 12);
            this.changeTest.Name = "changeTest";
            this.changeTest.Size = new System.Drawing.Size(323, 23);
            this.changeTest.TabIndex = 0;
            this.changeTest.Text = "Change the label if cheched";
            this.changeTest.UseVisualStyleBackColor = true;
            this.changeTest.Click += new System.EventHandler(this.ChangeTest_Click);
            // 
            // enableCheckBox
            // 
            this.enableCheckBox.AutoSize = true;
            this.enableCheckBox.Checked = true;
            this.enableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableCheckBox.Location = new System.Drawing.Point(341, 16);
            this.enableCheckBox.Name = "enableCheckBox";
            this.enableCheckBox.Size = new System.Drawing.Size(131, 17);
            this.enableCheckBox.TabIndex = 1;
            this.enableCheckBox.Text = "Enable label changing";
            this.enableCheckBox.UseVisualStyleBackColor = true;
            // 
            // labelToChange
            // 
            this.labelToChange.Location = new System.Drawing.Point(12, 53);
            this.labelToChange.Name = "labelToChange";
            this.labelToChange.Size = new System.Drawing.Size(323, 23);
            this.labelToChange.TabIndex = 2;
            this.labelToChange.Text = "Press the button to change my text";
            this.labelToChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(341, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 49);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 91);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelToChange);
            this.Controls.Add(this.enableCheckBox);
            this.Controls.Add(this.changeTest);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "My Desktop App";
            this.MouseDown += Form1_MouseDown;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeTest;
        private System.Windows.Forms.CheckBox enableCheckBox;
        private System.Windows.Forms.Label labelToChange;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

