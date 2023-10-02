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
using Logics;
using static Logics.eGameSituations;
using static Logics.eSpotOnBoard;

namespace Reversed_Tic_Tac_Toe
{
    public class UserInterface
    {
        private GameManager m_Manager;
        private AllGamesData m_Data;
        private GameBoardForm m_GameBoardForm;
        private eGameSituations m_GameSituation;
        private eSpotOnBoard m_CurrentPlayer;
        public GameManager Manager
        {
            get
            {
                return m_Manager;
            }
            set
            {
                m_Manager = value;
            }
        }
        public AllGamesData Data
        {
            get
            {
                return m_Data;
            }
            set
            {
                m_Data = value;
            }
        }
        public eSpotOnBoard CurrentPlayer
        {
            get
            {
                return m_CurrentPlayer;
            }
        }
        public eGameSituations GameSituation
        {
            get
            {
                return m_GameSituation;
            }
        }
        public UserInterface(int i_BoardSize, bool i_PlayerOrComputer, string i_Player1Name, string i_Player2Name)
        {
            m_Manager = new GameManager(i_BoardSize);
            m_Manager.CreatePlayer2(i_PlayerOrComputer);
            m_Data = new AllGamesData();
            m_GameBoardForm = new GameBoardForm(i_BoardSize, i_Player1Name, i_Player2Name, this);
            m_GameBoardForm.Shown += new EventHandler(gameBoardForm_Shown);
            m_GameBoardForm.ShowDialog();
        }
        private void gameBoardForm_Shown(object sender, EventArgs e)
        {
            initGameSettings();
        }
        private void initGameSettings()
        {
            m_GameSituation = notFinished;
            m_CurrentPlayer = player1;
            m_Manager.RestartGame();
        }
        internal void CheckIfComputerTurn()
        {
            if (m_CurrentPlayer == player2 && m_Manager.Player2.ComputerOrPerson)
            {
                PlayGameTurn(null);
            }
        }
        internal void PlayGameTurn(ButtonOnBoard i_ButtonClicked)
        {
            string row = null, col = null;
            if(i_ButtonClicked != null)
            {
                row = i_ButtonClicked.Row.ToString();
                col = i_ButtonClicked.Column.ToString();
                m_Manager.HumanTurn(m_CurrentPlayer, row, col);
            }
            else
            {
                m_Manager.ComputerTurn(out row, out col);
                i_ButtonClicked = m_GameBoardForm.Board[int.Parse(row) -1, int.Parse(col) - 1];
            }
            i_ButtonClicked.ButtonSpot = m_CurrentPlayer;
            m_GameBoardForm.UpdateButtonOnBoard(i_ButtonClicked, m_CurrentPlayer);
            m_Manager.CheckResultOfTurn(row, col, m_CurrentPlayer, ref m_GameSituation, m_Data);
            handleResult(i_ButtonClicked);
        }
        private void handleResult(ButtonOnBoard i_ButtonClicked)
        {
            if (m_GameSituation == notFinished)
            {
                m_Manager.ChangePlayer(ref m_CurrentPlayer);
                updatePlayersScoreLabels(m_CurrentPlayer);
                CheckIfComputerTurn();
            }
            else
            {
                DialogResult result = GameEnding();
                handlePlayerDecisionForAnotherGame(result);
            }
        }
        private void updatePlayersScoreLabels(eSpotOnBoard i_CurrentPlayer)
        {
            Label currentPlayerLabel;
            Label otherPlayerLabel;
            m_GameBoardForm.GetLabelOfPlayers(i_CurrentPlayer, out currentPlayerLabel, out otherPlayerLabel);
            currentPlayerLabel.Font = new Font(currentPlayerLabel.Font, FontStyle.Bold);
            otherPlayerLabel.Font = new Font(otherPlayerLabel.Font, FontStyle.Regular);
        }
        private void handlePlayerDecisionForAnotherGame(DialogResult i_DialogResult)
        {
            if(i_DialogResult == DialogResult.Yes)
            {
                m_GameSituation = notFinished;
                m_GameBoardForm.InitAllButtons();
                updateScores();
                updatePlayersScoreLabels(player1);
                initGameSettings();
            }
            else if(i_DialogResult == DialogResult.No)
            {
                m_GameBoardForm.Close();
            }
        }
        private void updateScores()
        {
            m_GameBoardForm.SetLabelText(m_GameBoardForm.Player1ScoreLabel, m_Data.NumberOfWinsToPlayer1);
            m_GameBoardForm.SetLabelText(m_GameBoardForm.Player2ScoreLabel, m_Data.NumberOfWinsToPlayer2);
        }
        internal DialogResult GameEnding()
        {
            string text = null;
            string resultText = null;
            string caption = null;
            if (m_GameSituation == player1Won || m_GameSituation == player2Won)
            {
                caption = "A Win!";
                resultText = string.Format("The Winner is {0}!",
                m_GameBoardForm.GetPlayerName((m_GameSituation)));
            }
            else
            {
                text = "It's a tie!";
                caption = "A tie!";
                resultText = "Tie";
            }
            text = string.Format(
        @"{0}!
Would you like to play another round?",
     resultText);
            return MessageBox.Show(text, caption, MessageBoxButtons.YesNo);
        }
    }
}
