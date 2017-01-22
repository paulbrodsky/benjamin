def areSquaresMarked(player, f, s, t):
    return squares[f] == player and squares[s] == player and squares[t] == player

def playerHasMovedOnce(player, squares):
    return filter(lambda s: s == player, squares).length == 1

def asdf(square):
    r

def playerHasCenter(player, squares):
    return squares[4] == player

def isPlayerGoingToWin(player, squares):
    pass

        return findWinningMove('X')
    pass

def getRandomMove(squares):
    for x in range(0, 9):
        if not squares[x] == 'X' and not squares[x] == 'Y':
            return x
    return -1

def getComputerMove(squares):
    if playerHasMovedOnce('X', squares):
        if playerHasCenter('X', squares):
            return 7
        else:
            return 5
    elif isPlayerGoingToWin('O', squares):
        return findWinningMove('O', squares)
        
    elif isPlayerGoingToWin('X', squares):
        return findWinningMove('X', squares)
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
    return areSquaresMarked(player, 0, 1, 2) \
    or areSquaresMarked(player, 3, 4, 5) \
    or areSquaresMarked(player, 6, 7, 8) \
    or areSquaresMarked(player, 0, 4, 8) \
    or areSquaresMarked(player, 2, 4, 6) \
    or areSquaresMarked(player, 0, 3, 6) \
    or areSquaresMarked(player, 1, 4, 7) \
    or areSquaresMarked(player, 2, 5, 8)

def isGameTied(squares):
    for x in range(0, 9):
        if squares[x] != 'X' and squares[x] != 'O':
            return False
    return True

def printBoard(squares):
    print squares[0] + '|' + squares[1] + '|' + squares[2]
    print squares[3] + '|' + squares[4] + '|' + squares[5]
    print squares[6] + '|' + squares[7] + '|' + squares[8]

squares = ['1', '2', '3', '4', '5', '6', '7', '8', '9']

print 'Instructions: these are the rules'

player = 'X'

while True:
    printBoard(squares)
    
    number = -1
    
    if player == 'X':
        number = getPlayerMove(player)
    else: 
        number = getComputerMove()
    
    if number == -1:
        continue
    
    number = number - 1
    
    squares[number] = player

    if isWinner(player, squares):
        printBoard(squares)
        print 'you won'
        break
    
    if isGameTied(squares):
        printBoard(squares)
        print 'Game is tied'
        break
    
    if player == 'X':
       player = 'O'
    else:
       player = 'X'
    
    
  
        