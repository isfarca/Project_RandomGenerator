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

        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonAddDiceType_Click(object sender, EventArgs e)
        {
            // Declare variables
            ComboBox newComboBox;
            TextBox newTextBox;
            ListBox newListBox;

            // Add new ComboBox.
            newComboBox = new ComboBox
            {
                Name = ComboBoxDiceSides.Name + Convert.ToString(addDiceTypeCount),
                Font = new Font(ComboBoxDiceSides.Font.Name, ComboBoxDiceSides.Font.Size),
                Location = new Point(ComboBoxDiceSides.Location.X, ComboBoxDiceSides.Location.Y * multiplicatorLocationY)
            };

            // Add new TextBox.
            newTextBox = new TextBox
            {
                Name = TextboxDiceAmount.Name + Convert.ToString(addDiceTypeCount),
                Font = new Font(TextboxDiceAmount.Font.Name, TextboxDiceAmount.Font.Size),
                Location = new Point(TextboxDiceAmount.Location.X, TextboxDiceAmount.Location.Y * multiplicatorLocationY)
            };

            // Add new ListBox.
            newListBox = new ListBox
            {
                Name = ListboxResultOutput.Name + Convert.ToString(addDiceTypeCount),
                Font = new Font(ListboxResultOutput.Font.Name, ListboxResultOutput.Font.Size),
                Location = new Point(ListboxResultOutput.Location.X, ListboxResultOutput.Location.Y * multiplicatorLocationY)
            };
        }
    }
}
