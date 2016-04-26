import pygame as gfx #this is the library that we call called pygame--- as gfx is something i dont know 
class Node:
	def __init__(self, x, y): #when initialized it  requires 2 parameters which is an x and y
		self.parent = None	#no parent or is null
		self.color = (255,255,255) #color is set here
		
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

class Astar:
	def __init__(self, SearchSpace, Start, Goal):
		self.OPEN = []
		self.CLOSED = []
		self.PARENT = [] #path
		self.start = Start
		self.goal = Goal
		
	
	def Run(self):
		OPEN.append(Start) #Add Start to the OPEN list
		
		while not self.OPEN: #while list not
			current = self.LowestF(self.OPEN)
		
	'''
	def ManDis(self, NodeA, NodeB)
		#return a scalar values
		num1 = NodeA.X - NodeB.X
		num2 = NodeA.Y - NodeB.Y
		MH = num1 + num2
		NodeB.setH(MH)
					
	def OLCL(self)
			current = OPEN[0]
			OPEN.remove(current)
			CLOSED.append(current)
	
	def GDis(self, Node A, NodeB)
		NodeA.X   
	'''	
			
	def LowestF(self, Nodes):
		lowestF = -1
		nodeWithLowestF = None
		for node in Nodes:
			if(node.f > lowestF):
				lowestF = node.f
				nodeWithLowestF = node
		return nodeWithLowestF
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




