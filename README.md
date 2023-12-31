# CardDealer

Github pages link: https://craigfw.github.io/CardDealer/

<img width="1059" alt="Screenshot 2023-10-11 190533" src="https://github.com/CraigFW/CardDealer/assets/4436733/7dd19e10-dcb9-4536-854d-296f2232de45">
<img width="948" alt="Screenshot 2023-10-11 190605" src="https://github.com/CraigFW/CardDealer/assets/4436733/827bde50-b0dd-4218-916f-f527ce22ed73">

A basic card dealer website with options to choose how many players and how many cards to deal.

Win options currently are: Highest, Lowest and Closest to 21, without going over.

The solution is structured into classes:
- CardClass
    This class is the base for cards, including suit and name/value of the card.
- Deck
    Contains a list of CardClass with DrawCard and SetOrderedDeck methods
- GameOptions
    Game options, including number of players, decks and card per hand
- Hand
    Hand value total, number and list of CardClass in hand

Enums:
- CardName
- GameMode
- SuitType

Components:
- Card
- CardMenu
- DeckArea
- GameContainer
- HandArea

Issues encountered:
- Adding additional hands initially did not add up correctly, this was due to incorrectly comparing value to strings instead of the set up enums.

Future development:
- Enabling multiple decks
- Testing with BUnit
- Add additional details to cards to display icons for faced cards and number of suit icons for card number
- Add logic for hand value ties
