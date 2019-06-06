# CalendarDart
A simple date guessing game

This an interactive game for up to eight players. The game is played on screen so all should be able to see the screen or projection.

The game is played in rounds where the exact date of some event needs to be guessed (or known). The Player getting the closest to the correct date gets the most points. Each round has a number of points which gets divided to the players. The worst player gets no points - sorry. The others get points depending on how much better they are than other players. 
Some examples:
- One player get's the anwser correct and all others are equally bad. So the best get's all the points.
- All players make the same bad guess, except one that is even worse. The worst get's no points (see above) and the others get small amount of points, since they made a bad guess. 

For the complete game every player has jokers. One of them can be used in each round.
- **Double** gives you twice the points. Will give you a little boost. If you manage to make a good guess.
- **Triple** gives you three times the points. Will give you a bigger boost, but if you make the worst guess three times zero is still zero.
- **Lucky** gives you the day and month for free, so you just have to guess the year. Great if you know the year to get the best guess.
- **Oracle** gives your the year for free, so you just have to guess the day and month. Great if other make bad guesses, since you are close to the correct guess.
- **Dice** gives you a random date between the worst and the best guess of the other players. Can be good or bad for you, but get's you a least some points.
- **NoGo** let's you choose a team that will skip this round (and therefore get's no points). Maybe use this on the scoreboard leader? Also great because the points get divided by fewer players.

Each round follows these steps.
- One player picks one of the given categories.
- All players are asked if they want to use a joker.
- The event in question is displayed.
- All players make their guess. Maybe write them down on a piece of paper to avoid _cheating_.
- The guesses are entered
- The guesses are display in chronological order
- The guesses and the correct answer are display
- The points for the round are displayed (jokers are already included)
- The current scoreboard for the game is displayed
