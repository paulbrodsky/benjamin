
maxMisses = 6

def isWinner(hits, word):
    for letter in word:
        if letter not in hits:
            return False
    return True

def printBoard(hits, word):
    board = ""
    board  += """
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

words = ["apple", "bannana", "mango"]

for word in words:
    print "Starting new game, you have 6 tries."
    
    
    hits = []
    misses = []

    while True:

        printBoard(hits, word)

        letter = raw_input("What letter would you like to guess?")
        
        if letter in hits or letter in misses:
            print "You already guessed that!"
            continue

        if letter in word:
            hits.extend(letter)
            print "you got it right"
        else:
            misses.extend(letter)
            print "you got it wrong, you have " + str(len(misses)) + " misses."
        
        if len(misses) >= maxMisses:
            print "hey you lost bruh"
            break

        if isWinner(hits, word):
            print "You won!"
            printBoard(hits, word)
            break






