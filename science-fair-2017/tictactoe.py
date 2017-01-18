squares = ['1', '2', '3', '4', '5', '6', '7', '8', '9']

print 'Instructions: these are the rules'

player = 'X'

def printBoard():
    print squares[0] + '|' + squares[1] + '|' + squares[2]
    print squares[3] + '|' + squares[4] + '|' + squares[5]
    print squares[6] + '|' + squares[7] + '|' + squares[8]

while True:
    printBoard()
   
    number = input("what's your move, " + player + "?")
    number = number - 1

    squares[number] = player

    if player == 'X':
        player = 'O'
    else:
        player = 'X'
