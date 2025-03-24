# Feedback Report for Isaiah

## Reviewer: Adam Wilson
**Project Title:** The Lost Ninja

### Strengths
The concept of the game is well fleshed-out and understood.

### Areas for Improvement
Scope should be reduced to one level. All mechanics should be detailed. Sound should be considered as a fundamental element of game mechanics.

### Feasibility and Execution
- Scope Realistic: Disagree
- Clear Execution Plan: Neutral
- Challenges Identified: Neutral
- Technical Foundation: Neutral
- Creative Foundation: Agree

### Potential Impact & Innovation
- Contribution to Field: Neutral
- Originality: Neutral
- Future Development: Agree

### AI Integration
AI integration is unnecessary to achieve objectives.

### Final Comments
Isaiah, you have a strong general concept/theme and excitement about your project, which is great.  Take the time to get really detailed about every mechanic in your game, every interaction between elements, and find ways to replicate mechanics whenever possible. Give a solid chunk of time to developing (coding) each one of these.

### Overall Evaluation
Approve with Minor Revisions


---

## Reviewer: Allison Berkoy
**Project Title:** The Lost Ninja

### Strengths
General game structure clear (2d platformer, single player, defeat enemies), style references, mechanics demo,  lots of enthusiasm!!  

### Areas for Improvement
The scope and timeline do not currently seem to match up (meaning, the scope is currently very large, with not a lot of time for implementing this vision). I strongly suggest focusing on a single level. Break down the timeline of tasks and milestones further (for this semester, summer, fall semester). I recommend touching base with Hosni further as you decide what to focus on for your technical prototype (due towards the end of this semester). The prototype should demonstrate a core game mechanic in Unity.

### Feasibility and Execution
- Scope Realistic: Disagree
- Clear Execution Plan: Disagree
- Challenges Identified: Neutral
- Technical Foundation: Neutral
- Creative Foundation: Agree

### Potential Impact & Innovation
- Contribution to Field: Neutral
- Originality: Neutral
- Future Development: Agree

### AI Integration
I do not remember AI usage being cited anywhere in the presentation

### Final Comments
I love hearing how excited you are to make this project-- this energy will carry you far. I recommend scoping the project way down and detailing out your timeline much further. Integrate playtesting early on, and let it serve as a tool for continued development, rather than leaving it to the end for just catching bugs. Prof Hosni is an obvious resource for you as you develop your ideas further. Take advantage of his office hours! 

I am selecting below "needs significant revision" -- this is meant for scoping down and developing a new, detailed production plan. A detailed prototype plan for this semester is also needed.

For your next presentation, take our notes into consideration regarding how much text you are placing on each slide. Less text per slide. Use presenter notes if needing more support for yourself.

### Overall Evaluation
Needs Significant Revision


---

## Reviewer: Hosni Auji
**Project Title:** The Lost Ninja (2D Game)

### Strengths
I like the planning you've done and I appreciate how you're thinking about the project. I also think if you scope it down a bit (see below for ways to do that) you can create a strong single level which can serve as a 'vertical slice' of the overall experience. If you are unfamiliar with the term, a vertical slice is like a small but functional portion of a project that gives the user an idea of what the whole thing would be like (without needing to make the whole thing). A way to think of it is like imagining a picture of a red apple. A picture of an apple doesn't fully explain what an apple is, but a picture of a dissected apple (or a vertical slice of the apple) shows that an apple has a red exterior with a white-ish interior and a core that has seeds. A vertical slice of an apple better describes what an apple is like.
If we apply that logic to a game. A single level of the game with your core functionality implemented gives us an idea of what the game will be like. We can then extrapolate what the other levels would be like without you needing to create other levels.      

### Areas for Improvement
As mentioned above, I think you should scope down your game to be a single level, perhaps with a single enemy type. You can also have your jump and double jump functionality along with a single attack type and a level designed around your attack and jumping mechanics. I don't mind you implementing a ranged attack (shuriken) and a melee attack (sword) but I would recommend you just start with one. I suggested shuriken because I think it will be easier for you. A shuriken is basically just a projectile. So you would need to write code that would spawn a projectile which has its own code that moves it in a straight line (could be sideways, up or down depending on how the player aims). The projectile would also have a collider on it and you can write some code that says when the projectile collider hits an enemy collider, the enemy takes damage. On the other hand, a melee attack is slightly more complicated because you would need to spawn a collider in front of the player that moves and scales according to the sword swinging animation until the collider is disabled when the attack is done. It is not very hard to implement but is definitely a bit more complicated than the shuriken since it needs to work in sync with the sword animation.  Again, both are doable and if you manage to implement the shuriken early, you might have time to implement a melee attack but I think there is significant gameplay potential with just the shuriken to start with. I don't know if you've played an old Sega game called Shadow Dancer (here is a video link if you are unfamiliar with the game: https://www.youtube.com/watch?v=GpZBhEgHZ28&ab_channel=NintendoComplete) . Shadow Dancer does have both a shuriken attack and a melee attack (and a cool dog, but we don't need to worry about that) but the shuriken is definitely the main weapon and the one the player uses most often in that game. I think this is a good reference for you to check out. 
In addition it is important to think about enemy behaviors as well. Like for example, do the enemies attack you? Do they also have shurikens or do they just rush towards the player? Do enemies jump and/or try to avoid attacks? There is a lot to consider. My recommendation is to just have one enemy that has a fixed movement pattern and maybe they try to attack the player with projectiles or maybe they just impede the player's progress by existing in the same space the player needs to access to progress. 
I suppose the point I'm getting at with all this is that you have a lot to think about and implement even with this reduced scope we are suggesting and I would highly recommend (as a matter of fact I would even insist) that you start working on the prototype immediately. You don't need sprites or animations yet. Just make a prototype where the character is like a square or a vertical rectangle that the player can control and have that rectangle spawn like circle projectiles (shurikens) that the player can shoot towards other rectangles (enemies) and see how it goes. You can then add sprites and animations to these GameObjects after that and start building out the level gradually. Don't wait till the summer before you start this process because, in my opinion, it will be too late by then. You want to end up with the best 'vertical slice' possible and you'll need all the time you can get to make that happen.

### Feasibility and Execution
- Scope Realistic: Agree
- Clear Execution Plan: Neutral
- Challenges Identified: Neutral
- Technical Foundation: Neutral
- Creative Foundation: Agree

### Potential Impact & Innovation
- Contribution to Field: Agree
- Originality: Agree
- Future Development: Strongly Agree

### AI Integration
 

### Final Comments
As a student you have invaluable resources that are often taken for granted. You have access to faculty that are literally being paid to help you, but we can only help people that ask for help. If you are not sure how to do something or if you're stuck on something, you can reach out to us.  Youtube tutorials are no doubt helpful, but they are not tailored to your specific requirements. They are a good way to get started but they are a one way stream of information that may or may not apply to your particular case. They also can't answer your specific questions. On the other hand, we as faculty can answer your questions and help you with your specific requirements but, unlike YouTube, we are not available 24/7.  Which means you need to plan ahead and book appointments with us or bring your questions to class. You have access to both resources and so my advice is to take advantage of that while you can.

### Overall Evaluation
Approve with Minor Revisions


---
