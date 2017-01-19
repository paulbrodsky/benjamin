squares = ['1', '2', '3', '4', '5', '6', '7', '8', '9']

print 'Instructions: these are the rules'

player = 'X'

def printBoard():
    print squares[0] + '|' + squares[1] + '|' + squares[2]
    print squares[3] + '|' + squares[4] + '|' + squares[5]
    print squares[6] + '|' + squares[7] + '|' + squares[8]

while True:
    printBoard()
   
    number = raw_input("what's your move, " + player + "?")
    
    number = int(number)
    #oh. See if you can see this then
    # i see it, im talking about the terminal below
    #when you were entering git commands below, look there
    #what do you mean
    # this is enough to go on for you. make sure to validate > 0 alsoor less than 1 however you choose 
    # have fun
    if number > 11 - 1:
        print "hey stop that and type the right number"
        continue
        
   

    if player == 'X':
        player = 'O'
    else:
        player = 'X'
