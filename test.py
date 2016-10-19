#!/usr/bin/env Python

letterMap = "abcdefghijklmnopqrstuvwxyz !"
letterMap = letterMap + letterMap
offset = 5

def encrypLetter(letter):
  offsetIndex = letterMap.index(letter) + offset
  return letterMap[offsetIndex]

def decrypLetter(letter):
  offsetIndex = letterMap.index(letter) - offset
  return letterMap[offsetIndex]

def encryptMessage(message):
  result = ""
  for letter in message:
     result = result + encrypLetter(letter)
  return result

def decryptMessage(message):
  result = ""
  for letter in message:
     result = result + decrypLetter(letter)
  return result

message = "hi ben!"
encryptedMessage = encryptMessage(message)
decryptedMessage = decryptMessage(encryptedMessage)

print message
print encryptedMessage
print decryptedMessage
