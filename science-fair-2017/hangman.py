word = 'apple'
letter = raw_input("What letter would you like to guess?")
wordLetters = []



if letter in word:
    print "you got it right"
else:
     print "you got it wrong"

wordLetters.insert(0, letter)
print wordLetters