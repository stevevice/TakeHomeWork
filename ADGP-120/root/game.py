"""
 Example program to show using an array to back a grid on-screen.

 Sample Python/Pygame Programs
 Simpson College Computer Science
 http://programarcadegames.com/
 http://simpson.edu/computer-science/

 Explanation video: http://youtu.be/mdTeqiWyFnc
"""
import pygame
from astar import *



def main():


	#create the search space to look through
	searchSpace = [] #the search space is an empty array or begins this way
	for x in range(7): #for every x that is less/equal to 10
		for y in range(5): #for every y that is less/equal to 10
			n = Node(x, y) # instantiate a node at the position of both x and y
			#x goes right
			#y goes down
			walkable = False if (x >= 3 and x <= 3 and y >= 1 and y <= 3) else True # He sets these areas as a different color as defined 
			#if player walkable is false/////subject to change because of how its written
			#mx means message x and so on...
			print("x =:{mx} y=: {my} | pos =: {position}".format(mx = x, my = y, position = n.pos)) #prints out the position
			
			n.setWalk(walkable) #this sets walkable to either true or false
			searchSpace.append(n) #appends or adds to the end of this array
			

	# Initialize pygame
	pygame.init()

	# Set the HEIGHT and WIDTH of the screen
	WINDOW_SIZE = [180, 130]
	screen = pygame.display.set_mode(WINDOW_SIZE)

	# Set title of screen
	pygame.display.set_caption("Astar PathFinding Algorithm")

	# Loop until the user clicks the close button.
	done = False

	# Used to manage how fast the screen updates
	clock = pygame.time.Clock()
	
	#Start and End Nodes
	Start = Node (1,2)
	Goal = Node (5,2)

	# -------- Main Program Loop -----------
	while not done: #this while loop ends when done is marked true
		for event in pygame.event.get():  # User did something
			if event.type == pygame.QUIT:  # If user clicked close
				done = True	 # Flag that we are done so we exit this loop

		#Implementing Astar Algorithm
		#*Thought* seeing as the way the Astar class is defined inside of its class i need to call it with the following parameters(Searchspace, start, end)
		#I just need to have a start so i will just test it for now with the example thats given in the online material
		Alg = Astar(searchSpace, Start, Goal)
		
		
		
		'''
		for i in searchSpace:
			Alg.OPEN.append(searchSpace[i]) if (i.walkable == true) else Alg.CLOSE.append(searchSpace[i])
		
		#Alg.Run()
		'''
		
		# Set the screen background
		screen.fill((0,0,0))

		for i in searchSpace:
			i.draw(screen, (255,255,255))

		# Limit to 60 frames per second
		clock.tick(60)

		# Go ahead and update the screen with what we've drawn.
		pygame.display.flip()

	# Be IDLE friendly. If you forget this line, the program will 'hang'
	# on exit.
	pygame.quit()

main()

