#!/usr/bin/env Python

letterMap = "abcdefghijklmnopqrstuvwxyz"
length = len(letterMap)
offset = 5

def encrypLetter(letter):
  offsetIndex = letterMap.index(letter) + offset

  if offsetIndex > length - offset - 1:
    offsetIndex = 0

  return letterMap[offsetIndex]

def decrypLetter(letter):
  return letter + str("abcdefghijklmnopqrstuvwxyz !".index(letter))

def encryptMessage(message):
  result = ""
  for letter in message:
     result = result + encrypLetter(letter)
  return result

# print encryptMessage("hi hannah")
# print encryptMessage("yo dummy!")

print encrypLetter("a")
print encrypLetter("z")
