
def isWinner(hits, word):
    for letter in word:
        if letter not in hits:
            return False
    return True
    
    
    

words = ["apple", "bannana", "mango"]

for word in words:
    
    hits = []
    misses = []

    while True: 

        print "Starting new game"

        letter = raw_input("What letter would you like to guess?")
        
        if letter in hits or letter in misses:
            print "You already guessed that!"
            continue

        if letter in word:
            print "you got it right"
            hits.extend(letter)
            print hits
        else:
            print "you got it wrong"
            misses.extend(letter)
            print misses

        if isWinner(hits, word):
            print "You won!"
            break






