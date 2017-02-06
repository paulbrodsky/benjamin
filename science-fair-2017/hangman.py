print """
  _    _                                                     
 | |  | |                                                    
 | |__| |   __ _   _ __     __ _   _ __ ___     __ _   _ __  
 |  __  |  / _` | | '_ \   / _` | | '_ ` _ \   / _` | | '_ \ 
 | |  | | | (_| | | | | | | (_| | | | | | | | | (_| | | | | |
 |_|  |_|  \__,_| |_| |_|  \__, | |_| |_| |_|  \__,_| |_| |_|
                            __/ |                            
                           |___/                            
"""


maxMisses = 6

def isWinner(hits, word):
    for letter in word:
        if letter not in hits:
            return False
    return True

def printBoard(hits, word):
    board = ""
    numberMisses = len(misses)

    if numberMisses == 0:
        board += """
-------------
|           |
|           
|                  
|          
|
-------------
"""
    elif numberMisses == 1:
         board += """
-------------
|           |
|           O
|                   
|          
|
-------------
"""
    elif numberMisses == 2:
         board += """
-------------
|           |
|           O
|           |        
|          
|
-------------
"""
    elif numberMisses == 3:
         board += """
-------------
|           |
|           O
|          /|         
|          
|
-------------
"""
    elif numberMisses == 4:
         board += """
-------------
|           |
|           O
|          /|\\         
|          
|
-------------
"""
    elif numberMisses == 5:
         board += """
-------------
|           |
|           O
|          /|\\         
|          / 
|
-------------
"""
    elif numberMisses == 6:
         board += """
-------------
|           |
|           O
|          /|\\         
|          / \\
|
-------------
"""

    for letter in word:
        if letter in hits:
            board += " " + letter
        else:
            board += " _"
    print board

words = ["apple", "bannana", "mango", "cucumber", "plum", "cherry", "pineapple"]

for word in words:
    print "Starting new game, you have 6 tries.\r\n"
    
    hits = []
    misses = []

    while True:

        printBoard(hits, word)

        letter = raw_input("What letter would you like to guess?\r\n")
        
        if letter in hits or letter in misses:
            print "You already guessed that!\r\n"
            continue

        if letter in word:
            hits.extend(letter)
            print "You got it right!\r\n"
        else:
            misses.extend(letter)
            print "You got it wrong, you have " + str(len(misses)) + " misses.\r\n"
        
        if len(misses) >= maxMisses:
            print "You Lost\r\n"
            print printBoard(hits, word)
            break

        if isWinner(hits, word):
            print "You won!\r\n"
            printBoard(hits, word)    
            break

    if raw_input("Press enter to play again") != "":
        break