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
            //HIER WIRD NOCH DIE VARIABLE VON FETHI BENOETIGT (statt 1)
            int diceTypeCounter = 1;
            //for the number of dices of one specific type
            TextBox diceAmountBox = new TextBox();
            //for the type of the dice
            ComboBox diceTypeBox = new ComboBox();
            //for the output
            ListBox resultBox = new ListBox();
            Random random = new Random();

            //iterate through the types
            for (int i = 0; i > diceTypeCounter; i++)
            {
                //find instances of the boxes and save them as variables
                if (this.Controls.ContainsKey("ComboBoxDiceSides" + i.ToString()))
                {
                    diceTypeBox = this.Controls["ComboBoxDiceSides" + i.ToString()] as ComboBox;
                }
                if (this.Controls.ContainsKey("TextBoxDiceAmount" + i.ToString()))
                {
                    diceAmountBox = this.Controls["TextBoxDiceAmount" + i.ToString()] as TextBox;
                }
                if (this.Controls.ContainsKey("ListboxResultOutput" + i.ToString()))
                {
                    resultBox = this.Controls["ListboxResultOutput" + i.ToString()] as ListBox;
                }

                //fill result box with random values, depending on diceType and diceAmount
                for (int j = 1; j < Convert.ToInt32(diceAmountBox.Text); j++)
                {
                    resultBox.Items[0] = random.Next(1, (Convert.ToInt32(diceTypeBox.Text) + 1));
                }
            }
 
        }
    }
}