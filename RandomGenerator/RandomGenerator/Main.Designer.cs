namespace RandomGenerator
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ComboBoxDiceSides0 = new System.Windows.Forms.ComboBox();
            this.TextboxDiceAmount0 = new System.Windows.Forms.TextBox();
            this.ListboxResultOutput0 = new System.Windows.Forms.ListBox();
            this.ButtonAddDiceType = new System.Windows.Forms.Button();
            this.ButtonResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBoxDiceSides0
            // 
            this.ComboBoxDiceSides0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDiceSides0.FormattingEnabled = true;
            this.ComboBoxDiceSides0.Items.AddRange(new object[] {
            "4",
            "6",
            "12",
            "20"});
            this.ComboBoxDiceSides0.Location = new System.Drawing.Point(12, 12);
            this.ComboBoxDiceSides0.Name = "ComboBoxDiceSides0";
            this.ComboBoxDiceSides0.Size = new System.Drawing.Size(121, 28);
            this.ComboBoxDiceSides0.TabIndex = 0;
            this.ComboBoxDiceSides0.Text = "Dice Side";
            // 
            // TextboxDiceAmount0
            // 
            this.TextboxDiceAmount0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxDiceAmount0.Location = new System.Drawing.Point(139, 12);
            this.TextboxDiceAmount0.Name = "TextboxDiceAmount0";
            this.TextboxDiceAmount0.Size = new System.Drawing.Size(117, 26);
            this.TextboxDiceAmount0.TabIndex = 1;
            // 
            // ListboxResultOutput0
            // 
            this.ListboxResultOutput0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListboxResultOutput0.FormattingEnabled = true;
            this.ListboxResultOutput0.HorizontalScrollbar = true;
            this.ListboxResultOutput0.ItemHeight = 20;
            this.ListboxResultOutput0.Location = new System.Drawing.Point(262, 12);
            this.ListboxResultOutput0.Name = "ListboxResultOutput0";
            this.ListboxResultOutput0.Size = new System.Drawing.Size(416, 24);
            this.ListboxResultOutput0.TabIndex = 2;
            // 
            // ButtonAddDiceType
            // 
            this.ButtonAddDiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddDiceType.Location = new System.Drawing.Point(13, 47);
            this.ButtonAddDiceType.Name = "ButtonAddDiceType";
            this.ButtonAddDiceType.Size = new System.Drawing.Size(120, 27);
            this.ButtonAddDiceType.TabIndex = 3;
            this.ButtonAddDiceType.Text = "Add dice type";
            this.ButtonAddDiceType.UseVisualStyleBackColor = true;
            // 
            // ButtonResult
            // 
            this.ButtonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonResult.Location = new System.Drawing.Point(140, 47);
            this.ButtonResult.Name = "ButtonResult";
            this.ButtonResult.Size = new System.Drawing.Size(116, 27);
            this.ButtonResult.TabIndex = 4;
            this.ButtonResult.Text = "Result";
            this.ButtonResult.UseVisualStyleBackColor = true;
            this.ButtonResult.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 501);
            this.Controls.Add(this.ButtonResult);
            this.Controls.Add(this.ButtonAddDiceType);
            this.Controls.Add(this.ListboxResultOutput0);
            this.Controls.Add(this.TextboxDiceAmount0);
            this.Controls.Add(this.ComboBoxDiceSides0);
            this.Name = "FormMain";
            this.Text = "Random Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxDiceSides0;
        private System.Windows.Forms.TextBox TextboxDiceAmount0;
        private System.Windows.Forms.ListBox ListboxResultOutput0;
        private System.Windows.Forms.Button ButtonAddDiceType;
        private System.Windows.Forms.Button ButtonResult;
    }
}

