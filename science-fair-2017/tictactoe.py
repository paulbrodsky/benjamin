class TicTacToe:

    invalidMove = -1
    player1 = 'X'
    player2 = 'O'

    def __init__(self):
        self.squares = ['1', '2', '3', '4', '5', '6', '7', '8', '9']

    def isSquareEmpty(self, square):
        return not self.squares[square] == self.player1 \
        and not self.squares[square] == self.player2

    def isWinningMove(self, player, square, otherSquare1, otherSquare2):
        return self.isSquareEmpty(square) \
        and self.squares[otherSquare1] == player \
        and self.squares[otherSquare2] == player

    def findWinningMove(self, player):
        if self.isWinningMove(player, 0, 1, 2) \
        or self.isWinningMove(player, 0, 3, 6) \
        or self.isWinningMove(player, 0, 4, 8):
            return 0
        elif self.isWinningMove(player, 1, 0, 2) \
        or self.isWinningMove(player, 1, 4, 7):
            return 1
        elif self.isWinningMove(player, 2, 0, 1) \
        or self.isWinningMove(player, 2, 5, 8) \
        or self.isWinningMove(player, 2, 4, 6):
            return 2
        elif self.isWinningMove(player, 3, 4, 5) \
        or self.isWinningMove(player, 3, 0, 6):
            return 3
        elif self.isWinningMove(player, 4, 3, 5) \
        or self.isWinningMove(player, 4, 1, 7) \
        or self.isWinningMove(player, 4, 0, 8) \
        or self.isWinningMove(player, 4, 2, 6):
            return 4
        elif self.isWinningMove(player, 5, 2, 8) \
        or self.isWinningMove(player, 5, 3, 4):
            return 5
        elif self.isWinningMove(player, 6, 0, 3) \
        or self.isWinningMove(player, 6, 7, 8) \
        or self.isWinningMove(player, 6, 4, 2):
            return 6
        elif self.isWinningMove(player, 7, 1, 4) \
        or self.isWinningMove(player, 7, 6, 8):
            return 7
        elif self.isWinningMove(player, 8, 2, 5) \
        or self.isWinningMove(player, 8, 6, 7) \
        or self.isWinningMove(player, 8, 0, 4):
            return 8
        return self.invalidMove

    def isStalemate(self):
        for square in range(0, 9):
            if self.isSquareEmpty(square):
                return False
        return True

    def getComputerMove(self):
        moves = [self.findWinningMove(self.player2), self.findWinningMove(self.player1), 4, 0, 2, 6, 8, 1, 7, 3, 5]
        for m in moves:
            if m != self.invalidMove and self.isSquareEmpty(m):
                return m
        return self.invalidMove
        
    def getPlayerMove(self, player):
        square = raw_input("what's your move, " + player + "?")
        #todo this will throw an error if the user enters a non numeric value
        square = int(square)
        return square - 1

    def isValidMove(self, square):
        return square in range(0, 9) and self.isSquareEmpty(square)

    def printBoard(self):
        print self.squares[0] + '|' + self.squares[1] + '|' + self.squares[2]
        print self.squares[3] + '|' + self.squares[4] + '|' + self.squares[5]
        print self.squares[6] + '|' + self.squares[7] + '|' + self.squares[8]

    def play(self):
        isPlayer1Human = raw_input('Is player 1 human(1) or a computer(2)?') == '1'
        isPlayer2Human = raw_input('Is player 2 human(1) or a computer(2)?') == '1'
        currentPlayer = self.player1

        while True:
            self.printBoard()
            
            playerMove = self.invalidMove

            if currentPlayer == self.player1 and isPlayer1Human == True:
                playerMove = self.getPlayerMove(currentPlayer)
            elif currentPlayer == self.player2 and isPlayer2Human == True:
                playerMove = self.getPlayerMove(currentPlayer)
            else:
                playerMove = self.getComputerMove()

            if not self.isValidMove(playerMove):
                print 'Not a valid move, please try again'
                continue

            print currentPlayer + ' has chosen ' + str(playerMove + 1)

            winningMove = self.findWinningMove(currentPlayer)
            
            self.squares[playerMove] = currentPlayer

            if playerMove == winningMove:
                self.printBoard()
                print currentPlayer + ' has won!'
                break
            
            if self.isStalemate():
                self.printBoard()
                print 'Stalemate'
                break
            
            if currentPlayer == self.player1:
                currentPlayer = self.player2
            else:
                currentPlayer = self.player1

while True:

    print "Let's play Tic Tac Toe!"

    game = TicTacToe()
    game.play()

    if raw_input("Do you want to play again? (yes/no)") != 'yes':
        break
