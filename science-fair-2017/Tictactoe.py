#todo: validation
#todo: winner
#todo: SIGN UUUP

sqaures = ['1', '2', '3', '4', '5', '6', '7', '8', '9']

print 'Instructions: these are the rules'

player = 'X'

def printBoard():
    print sqaures[0] + '|' + sqaures[1] + '|' + sqaures[2]
    print sqaures[3] + '|' + sqaures[4] + '|' + sqaures[5]
    print sqaures[6] + '|' + sqaures[7] + '|' + sqaures[8]
    

while True:
    printBoard()
   
    number = input("what's your move, " + player + "?")
    number = number - 1

    sqaures[number] = player

    if player == 'X':
        player = 'O'
    else:
        player = 'X'
