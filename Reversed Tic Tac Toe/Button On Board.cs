using Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Logics.eSpotOnBoard;

namespace Reversed_Tic_Tac_Toe
{
    public class ButtonOnBoard : Button
    {
        private const string k_Player1Symbol = "X";
        private const string k_Player2Symbol = "O";
        private const string k_EmptySpot = "";
        private int m_Row;
        private int m_Column;
        private eSpotOnBoard m_ButtonSpot;
        public ButtonOnBoard(int i_Row, int i_Column)
        {
            m_Row = i_Row;
            m_Column = i_Column;
            m_ButtonSpot = empty;
        }
        public int Row
        {
            get 
            {
                return m_Row;
            }
        }
        public int Column
        {
            get
            {
                return m_Column;
            }
        }
        public eSpotOnBoard ButtonSpot
        {
            get
            {
                return m_ButtonSpot;
            }
            set
            {
                m_ButtonSpot = value;
            }
        }
        internal string GetSymbolOfSpot()
        {
            string symbol = null;
            if(m_ButtonSpot == player1)
            {
                symbol = k_Player1Symbol;
            }
            else if(m_ButtonSpot == player2)
            {
                symbol = k_Player2Symbol;
            }
            else
            {
                symbol = k_EmptySpot;
            }
            return symbol;
        }
    }
}
