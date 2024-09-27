using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    public class ChessBoard
    {
        // Fields
        private string _userBlackTileChar; 
        private string _userWhiteTileChar; 

        // Constructor
        public ChessBoard(string aUserBlackTileChar, string aUserWhiteTileChar)
        {
            _userBlackTileChar = aUserBlackTileChar;
            _userWhiteTileChar = aUserWhiteTileChar;
        }

        // getter & setters with validation. User are only allow to enter a singel character 
        public string BlackTiles
        {
            get { return _userBlackTileChar; }
            set
            {
                if (value.Length == 1)
                {
                    _userBlackTileChar = value;
                }
                else
                {
                    throw new ArgumentException("Du får enbart skriva in 1 tecken");
                }

            }

        }
        // getter & setters with validation. User are only allow to enter a singel character 
        public string WhiteTiles
        {
            get { return _userWhiteTileChar; }
            set
            {
                if (value.Length == 1)
                {
                    _userWhiteTileChar = value;
                }
                else
                {
                    throw new ArgumentException("Du får enbart skriva in 1 tecken");
                }
            }
        }
    }
}