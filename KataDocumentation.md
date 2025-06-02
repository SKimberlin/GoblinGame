# Coding Kata 1

## Factory

I chose this design patter because looking at the previous Random class I had, it wouldnt support a lot of changes and looked very messy.
Using the factory pattern, I can inject different enemy factories to change enemy creation without needing to rewrite a whole class.
It also helps me seperate the creaton logic from the game.

## Facade
The facade pattern allows me to simplify the calls I make from the UI. This means instead of calling multiple methods on a button press I call just one method and it handles the battle system mechanics and checks the condition of the game. That means I get to seperate the concerns of the view from the concerns of the logic. Since the calls have been simplified through the facade, implementing multiple UI's will be far easier. Especially since I was handling some logic in the UI in this old code.

## Composite
I had something pretty close to this before but I reworked it to be more to the standards of a composite. This now allows me to separate the concerns of an endpoint in dialogue from branching points. I can also add more dialogue options because I can inherit off of the interface to create more dialogue that can trigger events. It is also safer now because I can't add response options to endpoints in dialogue and need to specify if they are a composite or leaf.