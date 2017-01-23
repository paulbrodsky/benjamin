#global variables

squares = ['1', '2', '3', '4', '5', '6', '7', '8', '9']
invalidMove = -1

player1 = 'X'
player2 = 'O'

#functions

def isSquareEmpty(square):
    return not squares[square] == player1 \
    and not squares[square] == player2

def isWinningMove(player, square, otherSquare1, otherSquare2):
    return isSquareEmpty(square) \
    and squares[otherSquare1] == player \
    and squares[otherSquare2] == player

def findWinningMove(player):
    if isWinningMove(player, 0, 1, 2) \
    or isWinningMove(player, 0, 3, 6) \
    or isWinningMove(player, 0, 4, 8):
        return 0
    elif isWinningMove(player, 1, 0, 2) \
    or isWinningMove(player, 1, 4, 7):
        return 1
    elif isWinningMove(player, 2, 0, 1) \
    or isWinningMove(player, 2, 5, 8) \
    or isWinningMove(player, 2, 4, 6):
        return 2
    elif isWinningMove(player, 3, 4, 5) \
    or isWinningMove(player, 3, 0, 6):
        return 3
    elif isWinningMove(player, 4, 3, 5) \
    or isWinningMove(player, 4, 1, 7) \
    or isWinningMove(player, 4, 0, 8) \
    or isWinningMove(player, 4, 2, 6):
        return 4
    elif isWinningMove(player, 5, 2, 8) \
    or isWinningMove(player, 5, 3, 4):
        return 5
    elif isWinningMove(player, 6, 0, 3) \
    or isWinningMove(player, 6, 7, 8) \
    or isWinningMove(player, 6, 4, 2):
        return 6
    elif isWinningMove(player, 7, 1, 4) \
    or isWinningMove(player, 7, 6, 8):
        return 7
    elif isWinningMove(player, 8, 2, 5) \
    or isWinningMove(player, 8, 6, 7) \
    or isWinningMove(player, 8, 0, 4):
        return 8
    return invalidMove

def isStalemate():
    for square in range(0, 9):
        if isSquareEmpty(square):
            return False
    return True

def getComputerMove():
    moves = [findWinningMove(player2), findWinningMove(player1), 4, 0, 2, 6, 8, 1, 7, 3, 5]
    for m in moves:
        if m != invalidMove and isSquareEmpty(m):
            return m
    return invalidMove
    
def getPlayerMove(player):
    square = raw_input("what's your move, " + player + "?")
    #todo this will throw an error if the user enters a non numeric value
    square = int(square)
    return square - 1

def isValidMove(square):
    return square in range(0, 9) and isSquareEmpty(square)

def printBoard():
    print squares[0] + '|' + squares[1] + '|' + squares[2]
    print squares[3] + '|' + squares[4] + '|' + squares[5]
    print squares[6] + '|' + squares[7] + '|' + squares[8]

#game starts here

print 'Instructions: these are the rules'

isPlayer1Human = raw_input('Is player 1 human(1) or a computer(2)?') == '1'
isPlayer2Human = raw_input('Is player 2 human(1) or a computer(2)?') == '1'

currentPlayer = player1

while True:
    printBoard()
    
    playerMove = invalidMove

    if currentPlayer == player1 and isPlayer1Human == True:
        playerMove = getPlayerMove(currentPlayer)
    elif currentPlayer == player2 and isPlayer2Human == True:
        playerMove = getPlayerMove(currentPlayer)
    else:
        playerMove = getComputerMove()

    if not isValidMove(playerMove):
        print 'Not a valid move, please try again'
        continue

    print currentPlayer + ' has chosen ' + str(playerMove + 1)

    winningMove = findWinningMove(currentPlayer)
    
    squares[playerMove] = currentPlayer

    if playerMove == winningMove:
        printBoard()
        print currentPlayer + ' has won!'
        break
    
    if isStalemate():
        printBoard()
        print 'Stalemate'
        break
    
    if currentPlayer == player1:
       currentPlayer = player2
    else:
       currentPlayer = player1
