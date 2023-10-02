using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logics;

namespace Reversed_Tic_Tac_Toe
{
    public partial class GameSettingsForm : Form
    {
        public GameSettingsForm()
        {
            InitializeComponent();
        }
        private void GameSettingsForm_Load(object sender, EventArgs e)
        {

        }
        private void ButtonStart_Clicked(object sender, EventArgs e)
        {
            string player2Text = Player2TextBox.Text;
            if (!Player2CheckBox.Checked)
            {
                removeBracketsFromString(ref player2Text);
            }
            UserInterface ui = new UserInterface((int)RowsUpDown.Value, !Player2CheckBox.Checked, Player1TextBox.Text, player2Text);
        }
        private void removeBracketsFromString(ref string io_String)
        {
            StringBuilder sb = new StringBuilder(io_String);
            sb.Remove(0,1);
            sb.Remove(io_String.Length - 2, 1);
            io_String = sb.ToString();
        }
        private void Player1TextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Plaer1Label_Click(object sender, EventArgs e)
        {

        }

        private void Player2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Player2TextBox.Enabled = !Player2TextBox.Enabled;
            if(Player2TextBox.Enabled)
            {
                Player2TextBox.Text = "";
            }
            else
            {
                Player2TextBox.Text = "[Computer]";
            }
        }

        private void PlayersLabel_Click(object sender, EventArgs e)
        {

        }

        private void BaordSizeLabel_Click(object sender, EventArgs e)
        {

        }

        private void RowsUpDown_ValueChanged(object sender, EventArgs e)
        {
            ColsUpDown.Value = RowsUpDown.Value;
        }

        private void ColsUpDown_ValueChanged(object sender, EventArgs e)
        {
            RowsUpDown.Value = ColsUpDown.Value;
        }

        private void ColsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
