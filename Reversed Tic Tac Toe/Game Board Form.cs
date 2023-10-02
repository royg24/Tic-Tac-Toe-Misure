using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Logics;
using static Logics.eGameSituations;
using static Logics.eSpotOnBoard;

namespace Reversed_Tic_Tac_Toe
{
    public class GameBoardForm : Form
    {
        private const int k_FormWidth = 500;
        private const int k_FormHeight = 500;
        private const int k_Margin = 30;
        private ButtonOnBoard[,] m_Board;
        private TableLayoutPanel m_Table;
        private Label m_Player1ScoreLabel;
        private Label m_Player2ScoreLabel;
        private string m_Player1Name;
        private string m_Player2Name;
        private readonly Color r_Player1Color = Color.DarkGreen;
        private readonly Color r_Player2Color = Color.Red;
        private readonly Font r_LabelsFont = new Font("Times New Roman", 10);
        private UserInterface m_UserInterface;
        public string Player1Name
        {
            get
            {
                return m_Player1Name;
            }
            set
            {
                m_Player1Name = value;
            }
        }
        public string Player2Name
        {
            get
            {
                return m_Player2Name;
            }
            set
            {
                m_Player2Name = value;
            }
        }
        public ButtonOnBoard[,] Board
        {
            get
            {
                return m_Board;
            }
        }
        public Label Player1ScoreLabel
        {
            get
            {
                return m_Player1ScoreLabel;
            }
        }
        public Label Player2ScoreLabel
        {
            get
            {
                return m_Player2ScoreLabel;
            }
        }
        public GameBoardForm(int i_BoardSize, string i_Player1Name, string i_Player2Name, UserInterface i_UserInterface)
        {
            m_Player1Name = i_Player1Name;
            m_Player2Name = i_Player2Name;
            m_UserInterface = i_UserInterface;
            initializeComponent(i_BoardSize);
        }
        private void createAllButtons(float i_SpotSize)
        {
            int spotSizeInt = (int)i_SpotSize;
            for (int i = 0; i < m_Board.GetLength(1); i++)
            {
                for (int j = 0; j < m_Board.GetLength(1); j++)
                {
                    createButtonOnBoard(i, j, spotSizeInt);
                }
            }
        }
        internal void InitAllButtons()
        {
            for (int i = 0; i < m_Board.GetLength(1); i++)
            {
                for (int j = 0; j < m_Board.GetLength(1); j++)
                {
                    initButtonOnBoard(m_Board[i, j]);
                }
            }
        }
        private void createButtonOnBoard(int i_Row, int i_Col, int i_SpotSize)
        {
            m_Board[i_Col, i_Row] = new ButtonOnBoard(i_Col + 1, i_Row + 1);
            m_Board[i_Col, i_Row].Width = i_SpotSize;
            m_Board[i_Col, i_Row].Height = i_SpotSize;
            initButtonOnBoard(m_Board[i_Col, i_Row]);
            m_Board[i_Col, i_Row].Anchor = (AnchorStyles.Left & AnchorStyles.Right & AnchorStyles.Top & AnchorStyles.Bottom);
            m_Board[i_Col, i_Row].Click += new EventHandler(buttonOnBoard_Click);
            m_Table.Controls.Add(m_Board[i_Col, i_Row], i_Col, i_Row);
            m_Board[i_Col, i_Row].Dock = DockStyle.Fill;
        }
        private void initButtonOnBoard(ButtonOnBoard i_Button)
        {
            i_Button.Enabled = true;
            i_Button.ButtonSpot = empty;
            i_Button.Text = i_Button.GetSymbolOfSpot();
            i_Button.BackColor = Color.White;
            i_Button.Cursor = Cursors.Hand;
        }
        private void initLabel(out Label o_Label, Point i_Location, Color i_ForeColor)
        {
            o_Label = new Label();
            o_Label.AutoSize = true;
            o_Label.Location = i_Location;
            o_Label.Cursor = Cursors.IBeam;
            o_Label.Anchor = AnchorStyles.Bottom;
            o_Label.ForeColor = i_ForeColor;
            SetLabelText(o_Label, 0);
            this.Controls.Add(o_Label);
        }
        internal void SetLabelText(Label i_Label, int i_Score)
        {
            string text = string.Format("{0}: {1}",getPlayerName(i_Label) ,i_Score);
            i_Label.Text = text;
        }
        private string getPlayerName(Label i_Label)
        {
            string name = null;
            if(i_Label == m_Player1ScoreLabel)
            {
                name = m_Player1Name;
            }
            else
            {
                name = m_Player2Name;
            }
            return name;
        }
        private float createTable(int i_BoardSize)
        {
            m_Table = new TableLayoutPanel();
            float spotSize = (float)k_FormWidth / (float)i_BoardSize;
            m_Table.Enabled = true;
            m_Table.Visible = true;
            m_Table.Size = new Size(k_FormWidth, k_FormHeight);
            m_Table.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom);
            m_Table.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            m_Table.ColumnCount = i_BoardSize;
            m_Table.RowCount = i_BoardSize;
            for(int i = 0; i < i_BoardSize; i++)
            {
                m_Table.RowStyles.Add(new RowStyle(SizeType.Percent, spotSize));
                m_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, spotSize));
            }
            this.Controls.Add(m_Table);
            return spotSize;
        }
        private void initializeComponent(int i_BoardSize)
        {
            this.SuspendLayout();
            this.Name = "GameBoardForm";
            this.ResumeLayout(false);
            this.ClientSize = new Size(k_FormWidth,k_FormHeight + k_Margin);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "TicTacToeMisere";
            float spotSize = createTable(i_BoardSize);
            m_Board = new ButtonOnBoard[i_BoardSize, i_BoardSize];
            createAllButtons(spotSize);
            Point label1Location = new Point(k_FormWidth * 5 / 16, m_Table.Height);
            initLabel(out m_Player1ScoreLabel, label1Location, r_Player1Color);
            Point label2Location = new Point(label1Location.X + m_Player1ScoreLabel.Width + k_FormWidth/16, m_Table.Height);
            initLabel(out m_Player2ScoreLabel, label2Location, r_Player2Color);
            m_Player1ScoreLabel.Font = new Font(r_LabelsFont, FontStyle.Bold);
            m_Player2ScoreLabel.Font = new Font(r_LabelsFont, FontStyle.Regular);
        }
        private void buttonOnBoard_Click(object sender, EventArgs e)
        {
            ButtonOnBoard buttonClicked = sender as ButtonOnBoard;
            if(buttonClicked != null)
            {
                m_UserInterface.PlayGameTurn(buttonClicked);
            }
        }
        internal void UpdateButtonOnBoard(ButtonOnBoard i_Button, eSpotOnBoard i_CurrentPlayer)
        {
            i_Button.Text = i_Button.GetSymbolOfSpot();
            i_Button.Enabled = false;
            i_Button.Cursor = Cursors.Default;
            i_Button.Font = new Font("Aerial", i_Button.Height /2);
            i_Button.BackColor = returnPlayerColor(i_CurrentPlayer);
        }
        private Color returnPlayerColor(eSpotOnBoard i_Player)
        {
            Color? resultColor = null;
            if(i_Player == player1)
            {
                resultColor = r_Player1Color;
            }
            else if(i_Player == player2)
            {
                resultColor = r_Player2Color;
            }
            return (Color)resultColor;
        }
        internal string GetPlayerName(eGameSituations i_Player)
        {
            string name = null;
            if(i_Player == player1Won)
            {
                name = Player1Name;
            }
            else if(i_Player == player2Won)
            {
                name = Player2Name;
            }
            return name;
        }
        internal void GetLabelOfPlayers(eSpotOnBoard i_Player, out Label o_CurrentPlayerLabel, out Label o_OtherPlayerLabel)
        {
            o_CurrentPlayerLabel = null;
            o_OtherPlayerLabel = null;
            if(i_Player == player1)
            {
                o_CurrentPlayerLabel = m_Player1ScoreLabel;
                o_OtherPlayerLabel = m_Player2ScoreLabel;
            }
            else if(i_Player == player2)
            {
                o_CurrentPlayerLabel = m_Player2ScoreLabel;
                o_OtherPlayerLabel = m_Player1ScoreLabel;
            }
        }
    }
}
