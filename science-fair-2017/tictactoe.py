#these are the functions

def areSquaresMarked(player, f, s, t):
    return squares[f] == player and squares[s] == player and squares[t] == player

def isWinner(player, squares):
    return areSquaresMarked(player, 0, 1, 2) \
    or areSquaresMarked(player, 3, 4, 5) \
    or areSquaresMarked(player, 6, 7, 8) \
    or areSquaresMarked(player, 0, 4, 8) \
    or areSquaresMarked(player, 2, 4, 6) \
    or areSquaresMarked(player, 0, 3, 6) \
    or areSquaresMarked(player, 1, 4, 7) \
    or areSquaresMarked(player, 2, 5, 8)

def printBoard(squares):
    print squares[0] + '|' + squares[1] + '|' + squares[2]
    print squares[3] + '|' + squares[4] + '|' + squares[5]
    print squares[6] + '|' + squares[7] + '|' + squares[8]
    
# this is the game
squares = ['1', '2', '3', '4', '5', '6', '7', '8', '9']
    
print 'Instructions: these are the rules'

player = 'X'

while True:
    printBoard(squares)
    
    number = raw_input("what's your move, " + player + "?")
    
    # if the value of the number string is not numeric 
    # (if it is empty or contains a letter)
    # the following line will throw an error
    # take a look at this to see how to handle errors (exceptions)
    # https://docs.python.org/2.7/tutorial/errors.html#handling-exceptions

    number = int(number)
  
    #what if the value is lesjs than 1?
    if number > 9:
        print "hey stop that and type the right number"
        continue
    
    # also, you need to guard against using an already chosen square
    # if squares[number] == 'X' or squares[number] == 'O'
        
    number = number - 1
    squares[number] = player
    
    if isWinner(player, squares):
        printBoard(squares)
        print 'you won'
        break
    
    if player == 'X':
        player = 'O'
    else:
        player = 'X'
  
        