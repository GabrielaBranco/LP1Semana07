```mermaid
classDiagram
    Character --> Weapon
    Enemy --|> Character
    Enemy o--> Weapon
    Enemy --> Weapon
    Player o--> Weapon
    Player --|> Character
    Player --> Weapon
    Sword --|> Weapon
    Gun --|> Weapon
    Program o--> Character
```