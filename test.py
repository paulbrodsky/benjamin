#!/usr/bin/env Python

def encrypLetter(letter):
  return letter + str("abcdefghijklmnopqrstuvwxyz !".index(letter))

def encryptMessage(message):
  result = ""
  for letter in message:
    result = result + encrypLetter(letter)
  return result

print encryptMessage("hi hannah")
print encryptMessage("yo dummy!")


