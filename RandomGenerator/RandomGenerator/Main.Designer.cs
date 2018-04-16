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
            this.Output = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Decide = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.OptionsListBox = new System.Windows.Forms.ListBox();
            this.DecisionResultLabel = new System.Windows.Forms.Label();
            this.CoinflipResultLabel = new System.Windows.Forms.Label();
            this.EnterOptionTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ComboBoxDiceSides0
            // 
            this.ComboBoxDiceSides0.BackColor = System.Drawing.Color.PeachPuff;
            this.ComboBoxDiceSides0.FlatStyle = System.Windows.Forms.FlatStyle.System;
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
            this.ComboBoxDiceSides0.Text = "Dice side";
            // 
            // TextboxDiceAmount0
            // 
            this.TextboxDiceAmount0.BackColor = System.Drawing.Color.PeachPuff;
            this.TextboxDiceAmount0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxDiceAmount0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxDiceAmount0.Location = new System.Drawing.Point(139, 12);
            this.TextboxDiceAmount0.Name = "TextboxDiceAmount0";
            this.TextboxDiceAmount0.Size = new System.Drawing.Size(117, 25);
            this.TextboxDiceAmount0.TabIndex = 1;
            // 
            // ListboxResultOutput0
            // 
            this.ListboxResultOutput0.BackColor = System.Drawing.Color.Maroon;
            this.ListboxResultOutput0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListboxResultOutput0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListboxResultOutput0.ForeColor = System.Drawing.Color.Gold;
            this.ListboxResultOutput0.FormattingEnabled = true;
            this.ListboxResultOutput0.HorizontalScrollbar = true;
            this.ListboxResultOutput0.ItemHeight = 25;
            this.ListboxResultOutput0.Location = new System.Drawing.Point(262, 12);
            this.ListboxResultOutput0.Name = "ListboxResultOutput0";
            this.ListboxResultOutput0.Size = new System.Drawing.Size(416, 25);
            this.ListboxResultOutput0.TabIndex = 2;
            // 
            // ButtonAddDiceType
            // 
            this.ButtonAddDiceType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonAddDiceType.FlatAppearance.BorderSize = 0;
            this.ButtonAddDiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddDiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddDiceType.ForeColor = System.Drawing.Color.PeachPuff;
            this.ButtonAddDiceType.Image = global::RandomGenerator.Properties.Resources._8357a3f1824f652;
            this.ButtonAddDiceType.Location = new System.Drawing.Point(13, 47);
            this.ButtonAddDiceType.Name = "ButtonAddDiceType";
            this.ButtonAddDiceType.Size = new System.Drawing.Size(120, 27);
            this.ButtonAddDiceType.TabIndex = 3;
            this.ButtonAddDiceType.Text = "Add dice type";
            this.ButtonAddDiceType.UseVisualStyleBackColor = false;
            // 
            // ButtonResult
            // 
            this.ButtonResult.BackColor = System.Drawing.Color.Transparent;
            this.ButtonResult.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonResult.FlatAppearance.BorderSize = 0;
            this.ButtonResult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.ButtonResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonResult.ForeColor = System.Drawing.Color.PeachPuff;
            this.ButtonResult.Image = global::RandomGenerator.Properties.Resources._8357a3f1824f652;
            this.ButtonResult.Location = new System.Drawing.Point(140, 47);
            this.ButtonResult.Name = "ButtonResult";
            this.ButtonResult.Size = new System.Drawing.Size(116, 27);
            this.ButtonResult.TabIndex = 4;
            this.ButtonResult.Text = "Result";
            this.ButtonResult.UseVisualStyleBackColor = false;
            this.ButtonResult.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.BackColor = System.Drawing.Color.Transparent;
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(376, 79);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(90, 31);
            this.Output.TabIndex = 5;
            this.Output.Text = "output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Decision helper";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add option";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Decide
            // 
            this.Decide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decide.Location = new System.Drawing.Point(318, 415);
            this.Decide.Name = "Decide";
            this.Decide.Size = new System.Drawing.Size(103, 29);
            this.Decide.TabIndex = 8;
            this.Decide.Text = "Decide";
            this.Decide.UseVisualStyleBackColor = true;
            this.Decide.Click += new System.EventHandler(this.Decide_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(160, 462);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 28);
            this.button3.TabIndex = 9;
            this.button3.Text = "Clear options";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(318, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "Simple coinflip";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OptionsListBox
            // 
            this.OptionsListBox.BackColor = System.Drawing.Color.PeachPuff;
            this.OptionsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OptionsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsListBox.FormattingEnabled = true;
            this.OptionsListBox.ItemHeight = 16;
            this.OptionsListBox.Location = new System.Drawing.Point(160, 420);
            this.OptionsListBox.Name = "OptionsListBox";
            this.OptionsListBox.Size = new System.Drawing.Size(120, 32);
            this.OptionsListBox.TabIndex = 11;
            this.OptionsListBox.UseWaitCursor = true;
            // 
            // DecisionResultLabel
            // 
            this.DecisionResultLabel.AutoSize = true;
            this.DecisionResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.DecisionResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecisionResultLabel.Location = new System.Drawing.Point(454, 415);
            this.DecisionResultLabel.Name = "DecisionResultLabel";
            this.DecisionResultLabel.Size = new System.Drawing.Size(24, 26);
            this.DecisionResultLabel.TabIndex = 12;
            this.DecisionResultLabel.Text = "0";
            // 
            // CoinflipResultLabel
            // 
            this.CoinflipResultLabel.AutoSize = true;
            this.CoinflipResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.CoinflipResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoinflipResultLabel.Location = new System.Drawing.Point(454, 458);
            this.CoinflipResultLabel.Name = "CoinflipResultLabel";
            this.CoinflipResultLabel.Size = new System.Drawing.Size(24, 26);
            this.CoinflipResultLabel.TabIndex = 13;
            this.CoinflipResultLabel.Text = "0";
            // 
            // EnterOptionTextbox
            // 
            this.EnterOptionTextbox.BackColor = System.Drawing.Color.PeachPuff;
            this.EnterOptionTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterOptionTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterOptionTextbox.Location = new System.Drawing.Point(21, 421);
            this.EnterOptionTextbox.Name = "EnterOptionTextbox";
            this.EnterOptionTextbox.Size = new System.Drawing.Size(100, 16);
            this.EnterOptionTextbox.TabIndex = 14;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RandomGenerator.Properties.Resources.mystic_background_by_lirdrak_d712xh4;
            this.ClientSize = new System.Drawing.Size(690, 501);
            this.Controls.Add(this.EnterOptionTextbox);
            this.Controls.Add(this.CoinflipResultLabel);
            this.Controls.Add(this.DecisionResultLabel);
            this.Controls.Add(this.OptionsListBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Decide);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Output);
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
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Decide;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox OptionsListBox;
        private System.Windows.Forms.Label DecisionResultLabel;
        private System.Windows.Forms.Label CoinflipResultLabel;
        private System.Windows.Forms.TextBox EnterOptionTextbox;
    }
}

