class TicTacToe:
    
    invalidMove = -1

    player1 = 'X'
    player2 = 'O'

    solutions = [
      [[1, 2], [3, 6], [4, 8]],
      [[0, 2], [4, 7]],
      [[0, 1], [5, 8], [4, 6]],
      [[4, 5], [0, 6]],
      [[3, 5], [1, 7], [0, 8], [2, 6]],
      [[2, 8], [3, 4]],
      [[0, 3], [7, 8], [4, 2]],
      [[1, 4], [6, 8]],
    [[2, 5], [6, 7], [0, 4]],
    ]

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
        for square in range(0, 9):
          for sol in self.solutions[square]:
            if self.isWinningMove(player, square, sol[0], sol[1]):
              return square
        return self.invalidMove

    def isStalemate(self):
        for square in range(0, 9):
            if self.isSquareEmpty(square):
                return False
        return True

    def getComputerMove(self, difficulty):
        moves = [
          [1, 7, 3, 5, 4, 0, 2, 6, 8],
          [self.findWinningMove(self.player2), self.findWinningMove(self.player1), 4, 1, 0, 5, 2, 6, 8, 1, 7, 3, 5],
          [self.findWinningMove(self.player2), self.findWinningMove(self.player1), 4, 0, 2, 6, 8, 1, 7, 3, 5],
        ]

        for m in moves[difficulty]:
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
        print ''        
        print self.squares[0] + '|' + self.squares[1] + '|' + self.squares[2]
        print self.squares[3] + '|' + self.squares[4] + '|' + self.squares[5]
        print self.squares[6] + '|' + self.squares[7] + '|' + self.squares[8]
        print ''        

    def play(self):
        print "Let's play Tic Tac Toe!\n"
        
        isPlayer1Human = raw_input('Is player 1 human(1) or a computer(2)?') == '1'
        isPlayer2Human = raw_input('Is player 2 human(1) or a computer(2)?') == '1'
        difficulty = 2

        if not isPlayer1Human or not isPlayer2Human:
          difficulty = int(raw_input('Choose a difficulty: Easy(0) Normal(1) Hard(2)'))

        currentPlayer = self.player1

        while True:
            self.printBoard()
            
            playerMove = self.invalidMove

            if currentPlayer == self.player1 and isPlayer1Human == True:
                playerMove = self.getPlayerMove(currentPlayer)
            elif currentPlayer == self.player2 and isPlayer2Human == True:
                playerMove = self.getPlayerMove(currentPlayer)
            else:
                playerMove = self.getComputerMove(difficulty)

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

    game = TicTacToe()
    game.play()

    if raw_input("Click return to play again") != '':
        break
