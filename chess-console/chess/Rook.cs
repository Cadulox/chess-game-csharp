using board;

namespace chess {
    class Rook : Piece {

        public Rook(Board board, Color color) : base(board, color) {
        }

        public override string ToString() {
            return "R";
        }

        private bool canMove(Position position)
        {
            Piece p = board.piece(position);
            return p == null || p.color != color;
        }

        public override bool[,] possibleMovements()
        {
            bool[,] mat = new bool[board.rows, board.columns];

            Position pos = new Position(0, 0);

            // up
            pos.setValues(position.row - 1, position.column);
            while (board.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
                if (board.piece(pos) != null && board.piece(pos).color != color)
                {
                    break;
                }
                pos.row = pos.row - 1;
            }
            // down
            pos.setValues(position.row + 1, position.column);
            while (board.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
                if (board.piece(pos) != null && board.piece(pos).color != color)
                {
                    break;
                }
                pos.row = pos.row + 1;
            }
            // right
            pos.setValues(position.row, position.column + 1);
            while (board.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
                if (board.piece(pos) != null && board.piece(pos).color != color)
                {
                    break;
                }
                pos.column = pos.column + 1;
            }
            // left
            pos.setValues(position.row, position.column - 1);
            while (board.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
                if (board.piece(pos) != null && board.piece(pos).color != color)
                {
                    break;
                }
                pos.column = pos.column - 1;
            }
            return mat;
        }
    }
}