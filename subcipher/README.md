Substitution Cipher

I would like you to build a program that is able to encrypt and decrypt a file using a [Substitution Cypher](https://en.wikipedia.org/wiki/Substitution_cipher).

To encrypt a file, the program will have an `encrypt` command that takes two parameters: the name of a file that contains a substitution map and the name of a file that contains the message to be encrypted. The command will output the resulting encrypted message to a new file.

To decrypt a file, the program will have an `descrypt` command that takes two parameters: the name of a file that contains a substitution map and the name of a file that contains the message to be decrypted. The command will output the resulting decrypted message to a new file.

The structure of the substitution map should contain a list of values, each line being a single character mapping with a semicolon delimiter.

For example, using the following mapping, any capital A in your message will be replaced with a lower case z.

```
A:z
B:y
C:x
D:v
E:u
1:Z
2:Y
```

Example:
```
subcipher c:/map.txt c:/message.txt c:/encrypted.txt
```

creates a new file called `c:/encrypted.txt`