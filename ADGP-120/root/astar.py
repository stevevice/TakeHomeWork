import pygame as gfx #this is the library that we call called pygame--- as gfx is something i dont know 

Black	=(0,0,0)
White	=(255,255,255)
Red		=(255,0,0)
Lime	=(0,255,0)
Blue	=(0,0,255)
Yellow	=(255,255,0)
Cyan 	=(0,255,255)
Magenta =(255,0,255)
Silver	=(192,192,192)
Gray	=(128,128,128)
Maroon	=(128,0,0)
Olive	=(128,128,0)
Green	=(0,128,0)
Purple	=(128,0,128)
Teal	=(0,128,128)
Navy	=(0,0,128)
Sky 	= (128, 128, 255)

class Node:
	def __init__(self, x, y): #when initialized it  requires 2 parameters which is an x and y
		self.parent = None	#no parent or is null
		self.color = White #color is set here
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
		color = Blue if (self.walkable)	else Red
		gfx.draw.rect(screen, color, (self.left , self.top, self.width, self.height))
		
	def setWalk(self, walkable):
		self.walkable = walkable 
	def getF(self):
		if(self.g == None):
			self.g = 0
		return self.h + self.g
	def setH(self, val): #this is manhattan Distance
		self.h = val
	def setG(self, val): 
		self.g = val

class Astar:
	def __init__(self, SearchSpace, Start, Goal):
		self.OPEN = []
		self.CLOSED = []
		self.PARENT = [] #path
		self.start = Start
		self.start.color = Yellow
		self.goal = Goal
		self.goal.color = Purple
		self.current = Start
		self.finished = False
					
		#while not self.OPEN: #while list not
			#current = self.LowestF(self.OPEN)
	
	
	def SwitchNode(self, NodeA, NodeB):
		Current = NodeA
		if self.current == Current :
			for i in Current.adjacents:
				if NodeB == i :
					for j in self.CLOSED:
						if j != NodeB:							
							self.current =  NodeB
	
	def SetParent(self, NodeA, NodeB):
		parent = NodeA
		node = NodeB
		node.parent = parent
		self.PARENT.append(parent)
	
	def GetAdjacents(self, Node):
		bottom = (y + 1)
		top = (y - 1)
		right = (x + 1)
		left = (x - 1)
		topRight = (right, top)
		topLeft = (left, top)
		botLeft = (left, bottom)
		botRight = (right, bottom)
		adj = [bottom, top, right, left, topRight, topLeft, botLeft, botRight] 
		for i in adj:
			if (i in SearchSpace):
				if (SearchSpace[i].walkable):
					Node.adjacents.append(SearchSpace[i])
					SetParent(Node, SearchSpace[i])
					self.OPEN.append(SearchSpace[i])
	
	def OLCL(self):
			self.current = OPEN[0]
			self.OPEN.remove(current)
			self.CLOSED.append(current)
	
	'''
	def HScore(self, NodeA, NodeB)
		
		
			
	
	
	def GScore(self, NodeA, NodeB)
		for i in SearchSpace:
			if NodeA == SearchSpace[i]:
				if NodeB
		
	'''	
			
	def LowestF(self, Nodes):
		lowestF = None
		for n in Nodes:
			if(node.f >= lowestF):
				lowestF = node.f
			elif(n.getF()):
				nodeWithLowestF = node
		return nodeWithLowestF
		
		
	def Run(self):
		self.OPEN.append(self.start) #Add Start to the OPEN list
		GetAdjacents(self.current)
		for i in self.current.adjacents:
			SearchSpace[i].parent = self.current
		OLCL()
'''
	//I think that this should go in the Run
	TODO.Add(start)


	while (!TODO.IsEmpty())	// While there are squares to check
	{
		current = TODO.LowestF() // Get the lowest F
		TODO.Remove(current) 
		DONE.Add(current)

		foreach (adjacent square)
		{
			if (square.walkable && !DONE.Contains(square))
			{
				if (!TODO.Contains(square))
				{

					if (square.IsDestination())
					{
						RetracePath();
						return true; // Success
					}

					else
					{
						TODO.Add(square);
					
						square.Parent = current;
						// calcuate G and H
					}
				}

				else
				{
					int costToMoveToSquare = current.G + costToMove;

					if (costToMoveToSquare < square.G)
					{
						square.Parent = current;
						square.G = costToMoveToSquare;
						TODO.Sort();
					}
				}
			}
		}
	}

	return false; // Failure
	'''




