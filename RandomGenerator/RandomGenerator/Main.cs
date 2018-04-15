using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomGenerator
{
    public partial class FormMain : Form
    {
        // Value types
        private int addDiceTypeCount = 0;
        private int multiplicatorLocationY = 4;
        private int offset = 3;
        private ComboBox comboBox;
        private TextBox textBox;
        private ListBox listBox;

        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonAddDiceType_Click(object sender, EventArgs e)
        {
            ButtonNewLocations(offset);

            // Set the Settings for new widgets.
            comboBox = new ComboBox
            {
                Name = ComboBoxDiceSides.Name + Convert.ToString(addDiceTypeCount),
                Font = new Font(ComboBoxDiceSides.Font.Name, ComboBoxDiceSides.Font.Size),
                Text = ComboBoxDiceSides.Text,
                Size = ComboBoxDiceSides.Size,
                Location = new Point(ComboBoxDiceSides.Location.X, ComboBoxDiceSides.Location.Y * multiplicatorLocationY)
            };

            textBox = new TextBox
            {
                Name = TextboxDiceAmount.Name + Convert.ToString(addDiceTypeCount),
                Font = new Font(TextboxDiceAmount.Font.Name, TextboxDiceAmount.Font.Size),
                Size = TextboxDiceAmount.Size,
                Location = new Point(TextboxDiceAmount.Location.X, TextboxDiceAmount.Location.Y * multiplicatorLocationY)
            };

            listBox = new ListBox
            {
                Name = ListboxResultOutput.Name + Convert.ToString(addDiceTypeCount),
                Font = new Font(ListboxResultOutput.Font.Name, ListboxResultOutput.Font.Size),
                Size = ListboxResultOutput.Size,
                Location = new Point(ListboxResultOutput.Location.X, ListboxResultOutput.Location.Y * multiplicatorLocationY)
            };

            // Add items for the 'newComboBox'.
            for (int i = 0; i < ComboBoxDiceSides.Items.Count; i++)
                comboBox.Items.Add(ComboBoxDiceSides.Items[i]);

            // Add widgets.
            Controls.Add(comboBox);
            Controls.Add(textBox);
            Controls.Add(listBox);

            // Set new moving position for widgets.
            addDiceTypeCount++;
            multiplicatorLocationY += offset;

            CenterWindow();
        }

        private void ButtonRemoveDiceType_Click(object sender, EventArgs e)
        {
            // Declare variables
            int comboboxes = 0;
            int textboxes = 0;
            int listboxes = 0;

            foreach (var item in Controls)
            {
                if (item.GetType() == typeof(ComboBox))
                    comboboxes++;
                else if (item.GetType() == typeof(TextBox))
                    textboxes++;
                else if (item.GetType() == typeof(ListBox))
                    listboxes++;
            }

            comboBox.Name = ComboBoxDiceSides.Name + (comboboxes - 1);
            textBox.Name = TextboxDiceAmount.Name + (textboxes - 1);
            listBox.Name = ListboxResultOutput.Name + (listboxes - 1);

            Controls.Remove(comboBox);
            Controls.Remove(textBox);
            Controls.Remove(listBox);

            addDiceTypeCount--;
            multiplicatorLocationY -= offset;

            ButtonNewLocations(0);

            CenterWindow();
        }

        private void ButtonNewLocations(int offset)
        {
            ButtonAddDiceType.Location = new Point(ButtonAddDiceType.Location.X, ComboBoxDiceSides.Location.Y * (multiplicatorLocationY + offset));
            ButtonRemoveDiceType.Location = new Point(ButtonRemoveDiceType.Location.X, ComboBoxDiceSides.Location.Y * (multiplicatorLocationY + offset));
            ButtonResult.Location = new Point(ButtonResult.Location.X, ComboBoxDiceSides.Location.Y * (multiplicatorLocationY + offset));
        }

        private void CenterWindow()
        {
            Top = (Screen.PrimaryScreen.Bounds.Height - Height) / 2;
            Left = (Screen.PrimaryScreen.Bounds.Width - Width) / 2;
        }
    }
}
