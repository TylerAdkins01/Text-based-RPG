int HP = 10;
int Str = 2;
int gold = 1;
bool hasFire = false;
bool leave = true;
bool canSteal = true;
bool hasBomb = false;

Console.WriteLine("""  
   .------\ /------.
   |       -       |
   |       |       |
   |       -       |
   |       |       |
_______________________
===========.===========
  / ~~~~~     ~~~~~ \
 /|     |     |      \
 W   ---  / \  ---   W
 \.      |o o|      ./
  |                 |
  \    #########    /
   \  ## ----- ##  /
    \##         ##/
     \_____v_____/
""");
Console.WriteLine("The Shopkeep: \"How may I help you today?\"");


while(leave){
Console.WriteLine($"\nNarrator: \"it appears you have {gold} Gold currently, what will you pick?\"");
Console.WriteLine("""
1 - Purchase a sword
2 - Purchase a scroll 
3 - Attack the Shopkeep
4 - Sneakily take an item of the shelf
5 - Leave
""");
string a = Console.ReadLine()!;

if (a == "1" && gold > 0)
{
    while(gold == 1){
    Console.WriteLine("The Shopkeep: \"Would you like the\n1 - White Sword\n2 - Yellow Sword");
    string b = Console.ReadLine()!;
    if(b == "1")
        {
            Console.WriteLine("The Shopkeep: \"Wonderful Choice :)\"");
            Str += 2;
            gold--;
            Console.WriteLine("This Sword feels as if you could slay a giant in one swing");
        }
    else if(b == "2")
        {
          Console.WriteLine("The Shopkeep: \"Excelent Choice\"");
            Str--;
            gold--;
            Console.WriteLine("This Sword feels as if it could fall into peices at any moment");  
        }
            else
            {
                Console.WriteLine("The ShopKeep: \"What?\"");
            }
    }
}
else if (a == "1" && gold <= 0)
    {
        Console.WriteLine("It appears you have no money with you, I must ask that you leave now");
    }
else if(a == "2" && gold > 0)
    {
        Console.WriteLine("The Shopkeep: \"Excelent Choice, Luckily for you I have a scroll of Fireball in stock today\"");
        Console.WriteLine("Narrator: You obtained the Scroll of Fireball, its appears to be singed on the corner and always warm to the touch");
        hasFire = true;
        gold--;
    }
else if (a == "2" && gold <= 0)
    {
        Console.WriteLine("It appears you have no money with you, I must ask that you leave now");
    }
else if(a == "3")
    {
        Console.WriteLine("""  
   .------\ /------.
   |       -       |
   |       |       |
   |       -       |
   |       |       |
_______________________
===========.===========
  / ~~~~~     ~~~~~ \
 /   \\\\\    /////  \
 W   ---  / \  ---    W
 \.      |o o|  #### ./
  |              ####|
  \    #########    /
   \  ##/-----\##  /
    \## \_____/ ##/
     \_____v_____/
""");
        Console.WriteLine("What are you---AHH!");
        HP -= 9;
        Console.WriteLine("You reach over the counter and attempt to swiftly strike the Shopkeep");
        Console.WriteLine("Narrator: \"A short fight ensues. You trade hits until the you ram the shopkeep into the counter, you may have won this fight, but at what cost?\"");
        leave = false;
    }
else if(a == "4" && canSteal)
    {
        Console.WriteLine("You attempt to snatch the nearest shiniest item of the shelf beside you");
        Console.WriteLine("you are able to grab a sword with a faint blue crystaline appearance without the Shopkeep noticing, this will help in your adventures to come.");
        Str = Str * 2;
        canSteal = false;
    }
else if (a == "4" && !canSteal)
    {
        Console.WriteLine("The Shopkeep yells at you: \"Get your gruby little fingers out of my shop!!!\"");
        Console.WriteLine("The Shopkeep attacks you with every weapon in his reach and you are killed in the middle of his shop");
        Console.WriteLine("Your greed sickens me...");
        HP -= 10;
        break;
    }
else if(a == "5")
    {
        leave = false;
    }
    else
    {
        Console.WriteLine("What?");
    }
}

Console.WriteLine($"HP: {HP} Str: {Str} Gold: {gold}");
Console.WriteLine("You venture into the distance with the hope of vanquishing all enemies in your path");
Console.WriteLine("""
  |\_/|
=( o O )=
 /\ " /\
| |\_/| |
\_>---<_/
(___|___)
Hola mi amigo, mi nombre es Xicohtencatle
""");
Console.WriteLine("It seems an enemy has arrived");
leave = true;
while (leave)
{
    Console.WriteLine("""
    What will you do?

    1 - Strike the creature
    2 - Negotiate
    3 - Flee
    """);
    if(hasFire){
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("4 - FIREBALL!!!");
        Console.ResetColor();
    }
    string a = Console.ReadLine()!;

    switch (a)
    {
        case "1":
            if (Str > 6)
            {
                Console.WriteLine("As the creature finishes his sentence, you initiate combat. However, it seems you were a little...too powerful...");
                Console.WriteLine("The creature doesnt even try to defend himself, He immediatly keels over at the sight of your blade");
                Console.WriteLine("\nYou are able to nab a health potion and what appears to be a makeshift bomb");
                HP = 10;
                gold += 2;
                hasBomb = true;
                leave = false;
            } else if(Str > 3)
            {
                Console.WriteLine("As the creature finishes his sentence, you initiate combat.");
                Console.WriteLine("Its a hard fought battle, but in the end you emerge victorious");
                Console.WriteLine("The battle with the creature hurt you, but you've gained valuable experience");
                HP-= 5;
                Str = 6;
                gold++;
                leave = false;
            }
            else
            {
                Console.WriteLine("What a depressing end to your adventure...");
                Console.WriteLine("Your blade, or lack thereof, was no match for the monster's mighty explosives");
                HP = 0;
                Environment.Exit(0);
            }
            break;

        case "2":
            Console.WriteLine("¿que? Yo no se");
            break;

        case "3":
            leave = false;
            Console.WriteLine("You attempt an escape from the creature's explosive weapons");
            HP /= 2;
            HP--;
            break;

        case "4":
            if (hasFire)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;

                Console.WriteLine("""
       --_--
    (  -_    _).
  ( ~       )   )
(( )  (    )  ()  )
 (.   )) (       )
   ``..     ..``
        | |
      (=| |=)
        | |         jnh
    (../( )\.))
""");
            Console.ResetColor();
            }
            leave = false;
            Console.WriteLine("The creature blows up in a fiery explosion");
            Console.WriteLine("Congratulations! You have defeated your first enemy");
            break;

        default:
            break;
    }
}
// if (hasFire)
// {
//     Console.WriteLine("The enemy's foreign language startled you so much that you immediatly cast fireball");
//     Console.WriteLine("This might have been the worst thing you could've done");
//     Console.WriteLine("Everything within a 5 mile radius is incinerated");
//     Console.WriteLine("You and the creature are eviserated");
//     HP = -1000;
// } else if (Str > 6)
// {
//     Console.WriteLine("As the creature finishes his sentence, you initiate combat. However, it seems you were a little...too powerful...");
//     Console.WriteLine("The creature doesnt even try to defend himself, He immediatly keels over at the sight of your blade");
//     Console.WriteLine("\nYou are able to nab a health potion and what appears to be a makeshift bomb");
//     HP = 10;
//     gold += 2;
//     hasBomb = true;
// } else if(Str > 3)
// {
//     Console.WriteLine("As the creature finishes his sentence, you initiate combat.");
//     Console.WriteLine("Its a hard fought battle, but in the end you emerge victorious");
//     Console.WriteLine("The battle with the creature hurt you, but you've gained valuable experience");
//     HP-= 5;
//     Str = 6;
//     gold++;
// }
// else
// {
//     Console.WriteLine("What a depressing end to your adventure...");
//     Console.WriteLine("Your blade, or lack thereof, was no match for the monster's mighty explosives");
//     HP = 0;
// }

// Console.WriteLine("to be continued...");
// Console.Write($"HP: {HP} Str: {Str} Gold: {gold}");
// if (hasBomb)
// {
//     Console.WriteLine(" (x1 Bomb)");
// }