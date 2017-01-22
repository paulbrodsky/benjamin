def areSquaresMarked(player, squares, f, s, t):
    return squares[f] == player and squares[s] == player and squares[t] == player
    
def areAnyTwoSquaresMarked(player, squares, f, s, t):
    row = [squares[f], squares[s], squares[t]]
    filteredItems = list(filter(lambda s: s == player, row))
    return len(filteredItems) == 2
    
def playerHasMovedOnce(player, squares):
    filteredItems = list(filter(lambda s: s == player, squares))
    return len(filteredItems) == 1

def playerHasCenter(player, squares):
    return squares[4] == player

def isPlayerGoingToWin(player, squares):
    return areAnyTwoSquaresMarked(player, squares, 0, 1, 2) \
    or areAnyTwoSquaresMarked(player, squares, 3, 4, 5) \
    or areAnyTwoSquaresMarked(player, squares, 6, 7, 8) \
    or areAnyTwoSquaresMarked(player, squares, 0, 4, 8) \
    or areAnyTwoSquaresMarked(player, squares, 2, 4, 6) \
    or areAnyTwoSquaresMarked(player, squares, 0, 3, 6) \
    or areAnyTwoSquaresMarked(player, squares, 1, 4, 7) \
    or areAnyTwoSquaresMarked(player, squares, 2, 5, 8)

def findWinningMove(player, squares):
    if not squares[0] == player1 and not squares[0] == player2 and squares[1] == player and squares[2] == player:
        return 0
    if not squares[0] == player1 and not squares[0] == player2 and squares[3] == player and squares[6] == player:
        return 0
    if not squares[0] == player1 and not squares[0] == player2 and squares[4] == player and squares[8] == player:
        return 0

    if not squares[1] == player1 and not squares[1] == player2 and squares[0] == player and squares[2] == player:
        return 1
    if not squares[1] == player1 and not squares[1] == player2 and squares[4] == player and squares[7] == player:
        return 1

    if not squares[2] == player1 and not squares[2] == player2 and squares[0] == player and squares[1] == player:
        return 2
    if not squares[2] == player1 and not squares[2] == player2 and squares[5] == player and squares[8] == player:
        return 2
    if not squares[2] == player1 and not squares[2] == player2 and squares[4] == player and squares[6] == player:
        return 2

    if not squares[3] == player1 and not squares[3] == player2 and squares[0] == player and squares[6] == player:
        return 3
    if not squares[3] == player1 and not squares[3] == player2 and squares[4] == player and squares[5] == player:
        return 3

    if not squares[4] == player1 and not squares[4] == player2 and squares[3] == player and squares[5] == player:
        return 4
    if not squares[4] == player1 and not squares[4] == player2 and squares[1] == player and squares[7] == player:
        return 4
    if not squares[4] == player1 and not squares[4] == player2 and squares[0] == player and squares[8] == player:
        return 4
    if not squares[4] == player1 and not squares[4] == player2 and squares[2] == player and squares[6] == player:
        return 4
    
    if not squares[5] == player1 and not squares[5] == player2 and squares[3] == player and squares[4] == player:
        return 5
    if not squares[5] == player1 and not squares[5] == player2 and squares[2] == player and squares[8] == player:
        return 5

    if not squares[6] == player1 and not squares[6] == player2 and squares[7] == player and squares[8] == player:
        return 6
    if not squares[6] == player1 and not squares[6] == player2 and squares[2] == player and squares[4] == player:
        return 6
    if not squares[6] == player1 and not squares[6] == player2 and squares[0] == player and squares[3] == player:
        return 6

    if not squares[7] == player1 and not squares[7] == player2 and squares[6] == player and squares[8] == player:
        return 7
    if not squares[7] == player1 and not squares[7] == player2 and squares[4] == player and squares[1] == player:
        return 7
    
    if not squares[8] == player1 and not squares[8] == player2 and squares[7] == player and squares[6] == player:
        return 8
    if not squares[8] == player1 and not squares[8] == player2 and squares[5] == player and squares[2] == player:
        return 8
    if not squares[8] == player1 and not squares[8] == player2 and squares[4] == player and squares[0] == player:
        return 8

    return -1

def getRandomMove(squares):
    for x in range(0, 9):
        if not squares[x] == player1 and not squares[x] == 'Y':
            return x
    return -1

def getComputerMove(squares):
    if playerHasMovedOnce(player1, squares):
        if playerHasCenter(player1, squares):
            return 7
        else:
            return 5
    elif isPlayerGoingToWin(player2, squares):
        return findWinningMove(player2, squares) + 1
        
    elif isPlayerGoingToWin(player1, squares):
        return findWinningMove(player1, squares) + 1
    else: 
        return getRandomMove(squares)
    
def getPlayerMove(player):
    number = raw_input("what's your move, " + player + "?")
    number = int(number)
  
    if number < 1 or number > 9:
        print "hey stop that and type the right number"
        return -1
        
    return number

def isWinner(player, squares):
    return areSquaresMarked(player, squares, 0, 1, 2) \
    or areSquaresMarked(player, squares, 3, 4, 5) \
    or areSquaresMarked(player, squares, 6, 7, 8) \
    or areSquaresMarked(player, squares, 0, 4, 8) \
    or areSquaresMarked(player, squares, 2, 4, 6) \
    or areSquaresMarked(player, squares, 0, 3, 6) \
    or areSquaresMarked(player, squares, 1, 4, 7) \
    or areSquaresMarked(player, squares, 2, 5, 8)

def isGameTied(squares):
    for x in range(0, 9):
        if squares[x] != player1 and squares[x] != player2:
            return False
    return True

def printBoard(squares):
    print squares[0] + '|' + squares[1] + '|' + squares[2]
    print squares[3] + '|' + squares[4] + '|' + squares[5]
    print squares[6] + '|' + squares[7] + '|' + squares[8]

squares = ['1', '2', '3', '4', '5', '6', '7', '8', '9']

print 'Instructions: these are the rules'

player1 = 'X'
player2 = 'O'

currentPlayer = player1

while True:
    printBoard(squares)
    
    number = -1
    
    if currentPlayer == player1:
        number = getPlayerMove(currentPlayer)
    else: 
        number = getComputerMove(squares)
        print 'Computer has chosen ' + str(number)
    
    if number == -1:
        continue
    
    number = number - 1
    
    squares[number] = currentPlayer

    if isWinner(currentPlayer, squares):
        printBoard(squares)
        print 'you won'
        break
    
    if isGameTied(squares):
        printBoard(squares)
        print 'Game is tied'
        break
    
    if currentPlayer == player1:
       currentPlayer = player2
    else:
       currentPlayer = player1
    
    
  
        