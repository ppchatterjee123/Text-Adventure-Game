using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
public Text text;
	private enum States {Prison, Prison2,lantern2,Prison3,Prison4,woodenbox3,woodenbox2,woodenbox,stair3, Key1, Key2, lantern, floor2, Treasurebox,Hidden_Corridor, corridor_0, hammer,closet2, stair0, stair1, stair2, corridor_1, corridor_2, closet, courtyard, floor };
private States MyState;
	
	
	void Start () 
	{
	MyState = States.Prison;
	}
	
	void Update () 
	{
	print(MyState);
			 if( MyState == States.Prison)				{prison_1();}
		else if( MyState == States.Prison2)				{prison_2();}
		else if( MyState == States.Prison3)				{Prison3();}
		else if( MyState == States.lantern2)			{lantern2();}
		else if( MyState == States.hammer)			    {Outside();}
		else if( MyState == States.Key1)			    {KEYS1();}	
		else if( MyState == States.lantern)			    {Lantern1();}
		else if( MyState == States.corridor_0)		    {Corridor0();}
		else if( MyState == States.Treasurebox)		    {Treasure();}
		else if( MyState == States.woodenbox)		    {WoddenBox();}
		else if( MyState == States.woodenbox2)		    {WoddenBox2();}
		else if( MyState == States.corridor_1)			{corridor_1();}	
		else if( MyState == States.courtyard)			{courtyard();}
		else if( MyState == States.closet)				{closet();}
		else if( MyState == States.corridor_2)			{corridor_2();}
		else if( MyState == States.Hidden_Corridor)		{Hidden_Corridor();}
		else if( MyState == States.stair0)				{stair0();}
		else if( MyState == States.stair1)				{stair1();}	
		else if( MyState == States.stair2)				{stair2();}
		else if( MyState == States.stair3)				{stair3();}
		else if( MyState == States.floor)				{floor();}
		else if( MyState == States.closet2)				{closet2();}
		else if( MyState == States.woodenbox3)			{woodenbox3();}
	}
	
	#region State handler methods 
	void prison_1()  {
		text.text =	"A paranormal investigator tries to investigate a haunted prison cell. " +
				   	"As soon as he enters the cell, " +
				  	"the door disappears and he gets trapped in it. " +
				  	"With the help of the acute moonlight, he is able to find a hammer and a wooden box. \n\n" + 
				  	" Press P to open the wooden box.   Press H to pick up the hammer.   Press L to pick up lantern.";
			
			 if(Input.GetKeyDown (KeyCode.H))	{ MyState = States.hammer;}		
		else if(Input.GetKeyDown (KeyCode.P))	{ MyState = States.woodenbox;}	
		else if(Input.GetKeyDown (KeyCode.L))	{ MyState = States.lantern2;}	
	}
	
	void WoddenBox()
	{text.text =	" The wooden box is locked. Find a key or equipment to open the box. \n\n"+
					" Press R to go back to the cell.";
		   	 if(Input.GetKeyDown (KeyCode.R))	{ MyState = States.Prison;}
		
	}
	
	void lantern2(){
		text.text =	" You picked up the lantern. \n\n"+
					" Press P to open wooden box.    H to pick up the hammer.";
			 if(Input.GetKeyDown (KeyCode.H))	{ MyState = States.hammer;}		
		else if(Input.GetKeyDown (KeyCode.P))	{ MyState = States.woodenbox2;}	
	}
	
	
	void Outside()
	{text.text ="You Picked up the hammer. " +
				
				"Use the hammer to break open the Wooden box. \n\n " +
				
				"Press R to open the wooden box.   Press H to break open the Wooden box using hammer.";
			if(Input.GetKeyDown (KeyCode.H))	{ MyState = States.Treasurebox;}
	   else if(Input.GetKeyDown (KeyCode.R))	{ MyState = States.woodenbox3;}
		}
		
	void woodenbox3()
	{text.text =" The wooden box is locked. Use any equipment or key to open it. \n\n " +
			
			"Press R to go back and think";
	        if(Input.GetKeyDown (KeyCode.R))	{ MyState = States.hammer;}
	}
		
	void Treasure()
	{text.text ="You found a match box inside the woodenbox. You picked it up. \n\n" +
				" You search for more items in the prison cell. There is a Lantern inside. \n\n"+
				" Press P pick up the lantern.";
			if(Input.GetKeyDown (KeyCode.P))	{ MyState = States.lantern;}
		
	}
	
	void WoddenBox2()
	{text.text =" The wooden box is locked. Use any equipment or key to open it. \n\n"+
				"Press H to pick up the hammer.";
		    if(Input.GetKeyDown (KeyCode.H))	{ MyState = States.hammer;}
	}
	
	void prison_2()
	{
		text.text =	"You have the hammer with you. \n\n" +
					"Press L to break open the wooden box using hammer.";
		    if(Input.GetKeyDown (KeyCode.K))	{ MyState = States.Key1;}
	   else if(Input.GetKeyDown (KeyCode.L))    { MyState = States.lantern;}
	}	
	
	void Prison3()
	{text.text =	" You can take the stairs or pick up the lantern. \n\n" +
					" Press P to take the lantern.     Press R to take the stairs.";
			if(Input.GetKeyDown (KeyCode.P))	{ MyState = States.lantern;}
	   else if(Input.GetKeyDown (KeyCode.R)) 	{ MyState = States.stair3;}
	}
	
	void stair3()
	{text.text =	"You enter a room full of dust. You find nothing important.\n\n" +
					"Press R to to back to the prison cell. ";
		    if(Input.GetKeyDown (KeyCode.R)) 	{ MyState = States.lantern;}
	}
	
	void KEYS1()
	{text.text =	" Press R to use the key to open a secret door in the cell.";
				
			if(Input.GetKeyDown (KeyCode.R)) 	{ MyState = States.corridor_0;}
		
	}
	
	
	void Lantern1()
	{text.text =	"You used the matchbox to light up the lantern. With the available light, you found a key in the present cell and a secret stairway. \n\n"+
					"Press V to take the key.         Press R to take secret stairway." ; 
	
		   if(Input.GetKeyDown (KeyCode.V)) 	{ MyState = States.Key1;}
	  else if(Input.GetKeyDown (KeyCode.R))		{ MyState = States.stair3;}
		}
		
	void Corridor0()
	{text.text =	"You opened the door and found yourself in a corridor. \n\n "+
					"Press K to take the stairs.        Press L to go to floor.      Press J to open closet door.";
		   if(Input.GetKeyDown (KeyCode.K)) 	{ MyState = States.stair0;}
	  else if(Input.GetKeyDown (KeyCode.L))		{ MyState = States.floor;}
      else if(Input.GetKeyDown (KeyCode.J)) 	{ MyState = States.closet;}
	}
	
	void stair0()
	{text.text =	"You take the stairs. However, you found nothing here.\n\n"+
					" Press R to go back to the corridor.";
		   if(Input.GetKeyDown (KeyCode.R)) 	{ MyState = States.corridor_0;}
	}
	
	void closet()
	{text.text =		"You open the closet and find nothing. \n\n "+
						" Press R to go back to the corridor.";
		   if(Input.GetKeyDown (KeyCode.R)) 	{ MyState = States.corridor_0;}
	}
	
	void floor()
	{text.text =		"You are in the floor. \n\n "+
						"Press P to go to next corridor.    Press R to return to first corridor.";
		   if(Input.GetKeyDown (KeyCode.P))		{ MyState = States.corridor_1;}
	  else if(Input.GetKeyDown (KeyCode.R)) 	{ MyState = States.corridor_0;}
	}
	
	void corridor_1()
	{text.text =	"You are in corridor level two. \n\n"+
					"Press P to take stairs in the corridor.    Press R to open new closet in the corridor.";
		   if(Input.GetKeyDown (KeyCode.P))     { MyState = States.stair1;}
	  else if(Input.GetKeyDown (KeyCode.R))	    { MyState = States.closet2;}
	}
	
	void stair1()
	{text.text =	"You took the stairs and found nothing. You have to go back to corridor level two. \n\n"+
					"Press R to go back to corridor level two.";
		   if(Input.GetKeyDown (KeyCode.R)) 	{ MyState = States.corridor_1;}
		
	}
	
	void closet2()
	{text.text =	"You can see a magic invisible cloak inside the closet and a hidden entrance to another corridor. \n\n" +
					"Press J to enter hidden corridor.    Press P to wear the cloth.     Press R to return to corridor level two. ";
		
		   if(Input.GetKeyDown (KeyCode.P))     { MyState = States.corridor_2;}
	  else if(Input.GetKeyDown (KeyCode.J))     { MyState = States.Hidden_Corridor;}
	  else if(Input.GetKeyDown (KeyCode.R))     { MyState = States.corridor_1;}
	}
	
	void Hidden_Corridor()
	{text.text =	" You can see see stairs\n\n."+
					" Press R to take the stairs.      P to Return to corridor level two.";
		   if(Input.GetKeyDown (KeyCode.R)) 	{ MyState = States.stair2;}
	  else if(Input.GetKeyDown (KeyCode.P))     { MyState = States.corridor_1;}
	}
	
	void stair2()
	{text.text =	" You go up stairs and see a door. Unfortunately the door is locked. \n\n"+
					"Press P to go back to Corridor level two.";
		   if(Input.GetKeyDown (KeyCode.P))     { MyState = States.corridor_1;}
	}
	
	
	void corridor_2()
	{text.text =	"As soon as you wear the magic cloak, you are teleported to corridor three. Now you can see a courtyard in front of you. " +
					"However, you are disguised and invisible in the cloak and can freely escape though the courtyard wearing it.\n\n" +
					"Press P to escape the prison through courtyard.    Press R to return to corridor level two.";
	  	   if(Input.GetKeyDown (KeyCode.P)) 	{ MyState = States.courtyard;}
      else if(Input.GetKeyDown (KeyCode.R)) 	{ MyState = States.corridor_1;}
	}
	
	void courtyard()
	{text.text =	"You have succesfully escaped the haunted prison. \n\n"+
					"Press R to play again.";
		   if(Input.GetKeyDown (KeyCode.R)) 	{ MyState = States.Prison;}
	}
	#endregion
	
}



