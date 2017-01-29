word = 'apple'

hits = []
misses = []

while True: 
    letter = raw_input("What letter would you like to guess?")
    if letter in word:
        print "you got it right"
        hits.extend(letter)
        print hits
    else:
        print "you got it wrong"
        misses.extend(letter)
        print misses







