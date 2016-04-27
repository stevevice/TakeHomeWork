import pygame as gfx #this is the library that we call called pygame--- as gfx is something i dont know 
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

class Astar:
	def __init__(self, SearchSpace, Start, Goal):
		self.OPEN = []
		self.CLOSED = []
		self.PARENT = [] #path
		self.start = Start
		self.goal = Goal
		self.current = Start
					
		
	def Run(self):
		OPEN.append(self.start) #Add Start to the OPEN list
		for j in SearchSpace[j]
			ManDis(self.current, SearchSpace[j])
		GetAdjacents(self.current)
		for i in self.current.adjacents:
			SearchSpace[i].parent = self.current
		OLCL()
		
			
		
		#while not self.OPEN: #while list not
			#current = self.LowestF(self.OPEN)
		
	''' 
	def SwitchNode(self, NodeA, NodeB)
		Current = NodeA
		if self.current == Current :
			for i in Current.adjacents:
				if NodeB == i :
					for j in self.CLOSED:
						if j !=NodeB:							
							self.current =  NodeB
	
	def SetParent(self, NodeA, NodeB)
		parent = NodeA
		node = NodeB
		node.parent = parent
		PARENT.append(parent)
	
	def GetAdjacents(self, Node)
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
			if (i in SearchSpace)
				if (SearchSpace[i].walkable)
					Node.adjacents.append(SearchSpace[i])
					SetParent(Node, SearchSpace[i])
					self.OPEN.append(SearchSpace[i])
	
	def ManDis(self, NodeA, NodeB)
		#return a scalar values
		num1 = NodeA.X - NodeB.X
		num2 = NodeA.Y - NodeB.Y
		MH = num1 + num2
		NodeB.setH(MH)
					
	def OLCL(self)
			self.current = OPEN[0]
			self.OPEN.remove(current)
			self.CLOSED.append(current)
	
	def GDis(self, Node A, NodeB)
		for i in SearchSpace:
			if NodeA == SearchSpace[i]:
				if NodeB
		
		
	'''	
			
	def LowestF(self, Node):
		lowestF = -1
		nodeWithLowestF = None
		for node in Node:
			if(node.f < lowestF):
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




