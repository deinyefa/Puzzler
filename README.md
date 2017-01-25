# About
As part of my coursework in the VR nanodegree at Udacity, I designed, tested and iterated a mobile VR game called Puzzler. In this game, the player is to enter a dreary room and test their memorization skills by trying to replicate patterns shown to them. The player can leave the room and beat the game after correctly replicating the patterns.

# Unique Considerations
An important design consideration was to create it such that the player can intuitively know what to do to win. Another consideration was to design the room to be life-sized so the player doesn’t feel too small or too large. Lastly, the designing process tried to consider simulator sickness and minimize it by limiting movement in the overall experience and keeping the important elements in front of the camera.hh

# Puzzler
The project was successful because of the continuous iterative process used through out its development to consistently improve game play. For user-testing, I included people who do not have much experience with VR and those who are familiar with it.

![Demo](https://cloud.githubusercontent.com/assets/18746993/22241317/ddd5c282-e1ec-11e6-973b-f1a55703ad95.gif)

Game Play in Unity

![Mid-game](https://cloud.githubusercontent.com/assets/18746993/22240951/4d754b1e-e1eb-11e6-92da-0a9bd42ec502.png)
Mid-game

# Design Process
Statement of Purpose: Puzzler is a mobile VR game targeted towards new VR users that challenges them to solve a familiar puzzle in a new way.
Persona

Meet Eve
For this project, I created a persona named Eve. Eve is a 21-year-old university student who knows little about VR. Eve is a free spirit who is always interested in trying new things. Eve always says “Life’s too short.”, and so she lives in the moment.
Sketches
Here are some of the sketches I created to helped me lay the groundwork for the design of this project.


# User Testing
Testing the scene and atmosphere

To test the scene and atmosphere, I asked a user who is familiar with VR and placed him inside the room. I had only designed the room at this point so the user was testing the scale, mood and any other interesting features. The user used the size of the door and the ceiling height to gauge his height and confirmed that it felt like his actual height. He noted that the atmosphere of the room was “horror-ish”, but could be a bit darker and was interested in what would be beyond the door. My response was to correct the lightening.

Testing the UI elements

The second test that was conducted was to see if the Start and Restart UIs were comfortably sized, whether they are self-explanatory and if they work well. At this point, they only toggled the other when clicked. The feedback I got was that they were comfortably sized and the user did not have to strain to see the words. Also, the user knew what to do without any instructions and could confirm that the buttons worked.

Testing motion into the dungeon

The third test was conducted to see if the user felt comfortable during the movement into the room. The user noted that when moving into the room, he did not feel like he was going to hit his head or shoulders but also said it felt he was moving from standing on air to solid ground. When asked if he experienced any nausea or headaches he responded with a “no”. Considering these responses, I added a mountain terrain to the scene.

Testing final game mechanics

The forth and final test was conducted to test the game mechanics. When asked about the game the user said from the outside, it felt like there was a lot of buildup but the actual game was not as complex as he would have liked. Again, he noted that he did not feel any simulator sickness when playing. When asked for any other comments, he said that the sound made when there was an error was too harsh. I responded by reducing the volume in the Unity editor and making the puzzle more complex.

# Break down of the final piece
The final design of the game is included as screenshots taken with a Nexus 5 below. At the start of the game, the user is faced with the Start UI and moved into the dungeon when the Google VR reticle is pointed at the start button and the trigger pressed. When in the room, random orbs light up in a random pattern and the player must click on the orbs that lit up in the correct pattern in order to exit the room. When the player leaves the room, he/she is met with the Restart UI and start again.

![Intro](https://cloud.githubusercontent.com/assets/18746993/22293130/688d6c28-e2dc-11e6-8f28-2c086de2ccbe.png)
Intro

![In the moment](https://cloud.githubusercontent.com/assets/18746993/22293220/cce581b0-e2dc-11e6-88c9-a23242243ac7.png)
In the moment

Outro

# Conclusion
Overall, Puzzler is a short duration VR experience designed to showcase how simple and seamless virtual reality can be. It demonstrates the power of lighting, audio and visual cues and how combined, they can make or break any VR experience.

# Next Steps
For future development, Puzzler could be made more complex with additional rooms and levels of difficulty and perhaps even a story line.
