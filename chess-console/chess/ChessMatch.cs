﻿using board;

namespace chess
{
    class ChessMatch
    {
        public Board board { get; private set; }
        private int turn;
        private Color currentPlayer;
        public bool finished { get; private set; }

        public ChessMatch()
        {
            board = new Board(8, 8);
            turn = 1;
            currentPlayer = Color.White;
            finished = false;
            addPieces();
        }

        public void executeMovement(Position origin, Position destiny)
        {
            Piece p = board.removePiece(origin);
            p.incrementMovementAmount();
            Piece capturedPiece = board.removePiece(destiny);
            board.putPiece(p, destiny);
        }

        private void addPieces()
        {
            board.putPiece(new Rook(board, Color.White), new ChessPosition('c', 1).toPosition());
            board.putPiece(new Rook(board, Color.White), new ChessPosition('c', 2).toPosition());
            board.putPiece(new Rook(board, Color.White), new ChessPosition('d', 2).toPosition());
            board.putPiece(new Rook(board, Color.White), new ChessPosition('e', 2).toPosition());
            board.putPiece(new Rook(board, Color.White), new ChessPosition('e', 1).toPosition());
            board.putPiece(new King(board, Color.White), new ChessPosition('d', 1).toPosition());

            board.putPiece(new Rook(board, Color.Black), new ChessPosition('c', 7).toPosition());
            board.putPiece(new Rook(board, Color.Black), new ChessPosition('c', 8).toPosition());
            board.putPiece(new Rook(board, Color.Black), new ChessPosition('d', 7).toPosition());
            board.putPiece(new Rook(board, Color.Black), new ChessPosition('e', 7).toPosition());
            board.putPiece(new Rook(board, Color.Black), new ChessPosition('e', 8).toPosition());
            board.putPiece(new King(board, Color.Black), new ChessPosition('d', 8).toPosition());

        }
    }
}
