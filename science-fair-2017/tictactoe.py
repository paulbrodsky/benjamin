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

    if player == 'X':
        player = 'O'
    else:
        player = 'X'
