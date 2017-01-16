class Game:
    def __init__(self):
        self.tile1 = Tile()
        self.tile2 = Tile()
        self.tile3 = Tile()
        self.tile4 = Tile()
        self.tile5 = Tile()
        self.tile6 = Tile()
        self.tile7 = Tile()
        self.tile8 = Tile()
        self.tile9 = Tile()
        self.player1 = Player('X')
        self.player2 = Player('O')
        

class Tile:
    def __init__(self):
        self.value = 'blank'  
     
class Player:
    def __init__(self, value):
        self.value = value


game = Game()
print game.player1.value
print game.player2.value

print 'end'
