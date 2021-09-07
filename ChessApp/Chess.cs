
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ChessApp
{


    public partial class Chess : Application
    {

        static public string King = "K";
        static public string Queen = "Q";
        static public string Rook = "R";
        static public string Bishop = "B";
        static public string Knight = "N";
        static public string Pawn = "p";

        static public string WhiteKing = "&#x2654;";
        static public string WhiteQueen = "&#x2655;";
        static public string WhiteRook = "&#x2656;";
        static public string WhiteBishop = "&#x2657;";
        static public string WhiteKnight = "&#x2658;";
        static public string WhitePawn = "&#x2659;";

        static public string BlackKing = "&#x265A;";
        static public string BlackQueen = "&#x265B;";
        static public string BlackRook = "&#x265C;";
        static public string BlackBishop = "&#x265D;";
        static public string BlackKnight = "&#x265E;";
        static public string BlackPawn = "&#x265F;";

        public string Id;

        public string[] Moves;

        private string[,] Board;

        public Chess(string id)
        {

            Id = id;

            Moves = new string[200];

            Board = new string[8, 8];


        }

        public string[,] GetBoard()
        {
            return Board;
        }

        public bool CheckMove(string piece, int startRow, int startColumn, int endRow, int endColumn)
        {



            return true;
        }

        public bool Move(string piece, int startRow, int startColumn, int endRow, int endColumn)
        {

            bool canMove = CheckMove(piece, startRow, startColumn, endRow, endColumn);

            if ((Board[startRow, startColumn] == piece) && (canMove))
            {



            }

            return false;

        }


    }
}
