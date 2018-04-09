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

        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            //for the number of different diceTypes
            int diceTypeCounter = 0;
            //for the number of dices of one specific type
            int dicesOfTypeXCounter = 0;

            //iterate through the types
            for (int i = 0; i > diceTypeCounter; i++)
            {
                //find instances of the boxes and save them as variables
                if (this.Controls.ContainsKey("ComboBoxDiceSides" + i.ToString()))
                {
                    ComboBox diceTypeBox = this.Controls["ComboBoxDiceSides" + i.ToString()] as ComboBox;
                }
                if (this.Controls.ContainsKey("TextBoxDiceAmount" + i.ToString()))
                {
                    TextBox diceAmountBox = this.Controls["TextBoxDiceAmount" + i.ToString()] as TextBox;
                }
                if (this.Controls.ContainsKey("ListboxResultOutput" + i.ToString()))
                {
                    ListBox ResultBox = this.Controls["ListboxResultOutput" + i.ToString()] as ListBox;
                }

                //combo-box[i].wert auslesen
                //text-box[i].wert auslesen
                //listbox[i] aufrufen und in Schleife mit der Länge von text-box[i].wert einen Wert zwischen 1 und combo-box[i].wert eintragen
            }

            ListboxResultOutput.Items[0] = 
        }
    }
}