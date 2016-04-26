class Node:
	def __init__(self, x, y): #when initialized it  requires 2 parameters which is an x and y
		self.parent = None	#no parent or is null
		self.color = (255,255,255) #color is set here
		self.adjacents = []
		self.width = 20
		self.height = 20
		self.margin = 5
		self.left = (self.margin + self.width) *  x + self.margin
		self.top = (self.margin + self.height) *  y + self.margin
		self.walkable = True
		self.X = x
		self.Y = y
		self.pos = (x, y)
		self.f = None
		self.g = None
		self.h = None
	
	def draw(self, screen, color):
		margin = self.margin
		color = (0, 0, 255) if (self.walkable) else (255,0,0)
		gfx.draw.rect(screen, color, (self.left , self.top, self.width, self.height))
		
	def setWalk(self, walkable):
		self.walkable = walkable
		 
	def getF(self):
		return self.h + self.g
	def setH(self, val):
		self.h = val
	def setG(self, val): #this is manhattan Distance
		self.g = val