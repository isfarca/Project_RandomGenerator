﻿namespace RandomGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ComboBoxDiceSides = new System.Windows.Forms.ComboBox();
            this.TextboxDiceAmount = new System.Windows.Forms.TextBox();
            this.ListboxResultOutput = new System.Windows.Forms.ListBox();
            this.ButtonAddDiceType = new System.Windows.Forms.Button();
            this.ButtonResult = new System.Windows.Forms.Button();
            this.ButtonRemoveDiceType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBoxDiceSides
            // 
            this.ComboBoxDiceSides.BackColor = System.Drawing.Color.PeachPuff;
            this.ComboBoxDiceSides.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboBoxDiceSides.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDiceSides.FormattingEnabled = true;
            this.ComboBoxDiceSides.Items.AddRange(new object[] {
            "4",
            "6",
            "12",
            "20"});
            this.ComboBoxDiceSides.Location = new System.Drawing.Point(12, 12);
            this.ComboBoxDiceSides.MaximumSize = new System.Drawing.Size(143, 0);
            this.ComboBoxDiceSides.MinimumSize = new System.Drawing.Size(143, 0);
            this.ComboBoxDiceSides.Name = "ComboBoxDiceSides";
            this.ComboBoxDiceSides.Size = new System.Drawing.Size(143, 28);
            this.ComboBoxDiceSides.TabIndex = 0;
            this.ComboBoxDiceSides.Text = "Dice side";
            // 
            // TextboxDiceAmount
            // 
            this.TextboxDiceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxDiceAmount.Location = new System.Drawing.Point(161, 12);
            this.TextboxDiceAmount.Name = "TextboxDiceAmount";
            this.TextboxDiceAmount.Size = new System.Drawing.Size(143, 26);
            this.TextboxDiceAmount.TabIndex = 1;
            // 
            // ListboxResultOutput
            // 
            this.ListboxResultOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListboxResultOutput.FormattingEnabled = true;
            this.ListboxResultOutput.HorizontalScrollbar = true;
            this.ListboxResultOutput.ItemHeight = 20;
            this.ListboxResultOutput.Location = new System.Drawing.Point(310, 12);
            this.ListboxResultOutput.Name = "ListboxResultOutput";
            this.ListboxResultOutput.Size = new System.Drawing.Size(368, 24);
            this.ListboxResultOutput.TabIndex = 2;
            // 
            // ButtonAddDiceType
            // 
            this.ButtonAddDiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddDiceType.Location = new System.Drawing.Point(12, 46);
            this.ButtonAddDiceType.Name = "ButtonAddDiceType";
            this.ButtonAddDiceType.Size = new System.Drawing.Size(143, 27);
            this.ButtonAddDiceType.TabIndex = 3;
            this.ButtonAddDiceType.Text = "Add dice type";
            this.ButtonAddDiceType.UseVisualStyleBackColor = true;
            this.ButtonAddDiceType.Click += new System.EventHandler(this.ButtonAddDiceType_Click);
            // 
            // ButtonResult
            // 
            this.ButtonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonResult.Location = new System.Drawing.Point(562, 46);
            this.ButtonResult.Name = "ButtonResult";
            this.ButtonResult.Size = new System.Drawing.Size(116, 27);
            this.ButtonResult.TabIndex = 4;
            this.ButtonResult.Text = "Result";
            this.ButtonResult.UseVisualStyleBackColor = true;
            this.ButtonResult.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // ButtonRemoveDiceType
            // 
            this.ButtonRemoveDiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRemoveDiceType.Location = new System.Drawing.Point(161, 46);
            this.ButtonRemoveDiceType.Name = "ButtonRemoveDiceType";
            this.ButtonRemoveDiceType.Size = new System.Drawing.Size(143, 27);
            this.ButtonRemoveDiceType.TabIndex = 5;
            this.ButtonRemoveDiceType.Text = "Remove dice type";
            this.ButtonRemoveDiceType.UseVisualStyleBackColor = true;
            this.ButtonRemoveDiceType.Click += new System.EventHandler(this.ButtonRemoveDiceType_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(690, 501);
            this.Controls.Add(this.ButtonRemoveDiceType);
            this.Controls.Add(this.ButtonResult);
            this.Controls.Add(this.ButtonAddDiceType);
            this.Controls.Add(this.ListboxResultOutput);
            this.Controls.Add(this.TextboxDiceAmount);
            this.Controls.Add(this.ComboBoxDiceSides);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxDiceSides;
        private System.Windows.Forms.TextBox TextboxDiceAmount;
        private System.Windows.Forms.ListBox ListboxResultOutput;
        private System.Windows.Forms.Button ButtonAddDiceType;
        private System.Windows.Forms.Button ButtonResult;
        private System.Windows.Forms.Button ButtonRemoveDiceType;
    }
}

