// See https://aka.ms/new-console-template for more information
/*  Level 3

string name;

Console.WriteLine("Bread is ready.");
Console.WriteLine("Who is the bread for?");
name = Console.ReadLine();
Console.WriteLine("Noted: "+ name +" got bread.");
*/


/* Level 4
Console.WriteLine("What kind of thing are we talking about?");
// a stores name of object being described
string a = Console.ReadLine();
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
/* b stores description of object
    c describes all objects are the same affix
    d is the year object was made
 */
/*
string b = Console.ReadLine();
string c = "of Doom";
string d = "3000";
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");
*/

/*
 Level 6


using System.Formats.Asn1;
using System.Runtime.CompilerServices;


char letter = 'a';
string sentence = "abcd";

sbyte signedByte = -123;
short signedShort = -12344;
int integer = -1234;
long bignumber = -1234434535454;

byte normalbyte = 12;
ushort unsignedShort = 1234;
uint uinteger = 1234;
ulong unsignedLong = 12323435545;

float floatNumber = 123.211f;
double doubleNumber = 123.43424324234;
decimal decimalNumber = 232.2132132m;

bool boolean = false;

letter = 'b';
sentence = "new";
signedByte = -1;
signedShort = -123;
integer = -12345456;
bignumber = -122313212212;
normalbyte = 100;
unsignedShort = 983;
uinteger = 94374343;
unsignedLong = 23103209932084332;
floatNumber = 2113.2320000001231f;
doubleNumber = 1230023112090124.23409832902102;
decimalNumber = 21.23132654354354352m;
boolean = true;

Console.WriteLine("Character: " + letter);
Console.WriteLine("String: " + sentence);
Console.WriteLine("Signed Byte: " + signedByte);
Console.WriteLine("Signed Short: " + signedShort);
Console.WriteLine("Integer: " + integer);
Console.WriteLine("Long: " + bignumber);
Console.WriteLine("Unsigned Byte: " +normalbyte);
Console.WriteLine("Unsigned Short: " + unsignedShort);
Console.WriteLine("Unsigned Integer: " + uinteger);
Console.WriteLine("Unsigned Long: " + unsignedLong);
Console.WriteLine("Float Number: " + floatNumber);
Console.WriteLine("Double Number: " + doubleNumber);
Console.WriteLine("Decimal Number: " + decimalNumber);
Console.WriteLine("Boolean: " + boolean);
*/

/* Level 7 The Triangle Farmer

int triangleBase, triangleHeight;


Console.WriteLine("Please enter triangle base size: ");
triangleBase = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter triangle height size: ");
triangleHeight = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The area of the triangle is: "+ triangleBase*triangleHeight/2);
*/

/* Level 7 The Four Sisters and the Duckbear


int noChocEggs, sisterEggs, duckBearEggs;

Console.WriteLine("Enter the number of chocolate eggs gathered today:");
noChocEggs = Convert.ToInt32(Console.ReadLine());

sisterEggs = noChocEggs / 4;
duckBearEggs = noChocEggs % 4;
Console.WriteLine("Eggs for each sister: " + sisterEggs);
Console.WriteLine("Eggs for duckbear: " + duckBearEggs);
 */


/* Level 7 The Dominion of Kings

int provinces, duchies, estates,score;

Console.WriteLine("Enter number of provinces:");
provinces = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of duchies:");
duchies = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of estates:");
estates = Convert.ToInt32(Console.ReadLine());

score = (provinces * 6) + (duchies * 3) + estates;
Console.WriteLine("Your total points are: " + score);
 */

/* Level 8 The Defense of Consolas
 

int targetRow, targetCol;

Console.Title = "Defense of Consolas";
Console.Write("Target Row? ");
targetRow= Convert.ToInt32(Console.ReadLine());

Console.Write("Target Column? ");
targetCol = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.Blue;
Console.Beep();
Console.WriteLine($"Deploy to: \n({targetRow}, {targetCol-1}) \n({targetRow-1}, {targetCol})\n({targetRow}, {targetCol+1})\n({targetRow+1}, {targetCol})");
*/

/* Level 9 Repairing the Clocktower


int num;

Console.Write("Enter number for clock: ");
num = Convert.ToInt32(Console.ReadLine());

if (num %2 == 0)
{
    Console.WriteLine("Tick");
}
else
{
    Console.WriteLine("Tock");
}
 */

/* Level 9 Watchtower

int x, y;
string y_val, x_val;

Console.Write("Enter x: ");
x = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter y: ");
y = Convert.ToInt32(Console.ReadLine());

if (y > 0)
    y_val = "north";
else if (y < 0)
    y_val = "south";
else
    y_val = "";

if (x > 0)
    x_val = "east";
else if (x < 0)
    x_val = "west";
else
{
    x_val = "";
}

if (x_val == "" && y_val =="")
    Console.WriteLine("The enemy is here!");
else
    Console.WriteLine($"The enemy is to the {y_val}{x_val}");
 */

/* Level 10 Buying Inventory

Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.Write("What number do you want to see the price of? ");

int itemNo, price = 0;
string itemName="";

itemNo = Convert.ToInt32(Console.ReadLine());

switch (itemNo)
{
    case 1:
        itemName = "Rope";
        price = 10;
        break;
    case 2:
        itemName = "Torches";
        price = 15;
        break;
    case 3:
        itemName = "Climbing Equipment";
        price = 25;
        break;
    case 4:
        itemName = "Clean Water";
        price = 1;
        break;
    case 5:
        itemName = "Machete";
        price = 20;
        break;
    case 6:
        itemName = "Canoe";
        price = 200;
        break;
    case 7:
        itemName = "Food Supplies";
        price = 1;
        break;    
}

if (price != 0)
    Console.WriteLine($"{itemName} cost {price} gold.");
else
    Console.WriteLine("Invalid item entered.");
 */

/* Level 10 Discounted Inventory

string myName = "Toro";
string userName = "";

Console.Write("What is your name? ");
userName = Console.ReadLine();

Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.Write("What number do you want to see the price of? ");

int itemNo, price = 0;
string itemName="";

itemNo = Convert.ToInt32(Console.ReadLine());

switch (itemNo)
{
    case 1:
        itemName = "Rope";
        price = 10;
        break;
    case 2:
        itemName = "Torches";
        price = 15;
        break;
    case 3:
        itemName = "Climbing Equipment";
        price = 25;
        break;
    case 4:
        itemName = "Clean Water";
        price = 1;
        break;
    case 5:
        itemName = "Machete";
        price = 20;
        break;
    case 6:
        itemName = "Canoe";
        price = 200;
        break;
    case 7:
        itemName = "Food Supplies";
        price = 1;
        break;    
}

if (userName == myName)
    price /= 2;

if (itemName != "")
    Console.WriteLine($"{itemName} cost {price} gold.");
else
    Console.WriteLine("Invalid item entered.");
 */


/* Level 11 The Prototype

int pilotNo = -1;

while(pilotNo<0 || pilotNo >100)
{
    pilotNo = AskForNumberInRange("User 1, enter a number between 0 and 100: ", 0, 100);
}

Console.Clear();

int guessNo = -1;

Console.WriteLine("User 2, guess the number.");
while (guessNo != pilotNo)
{
    Console.Write("What is your next guess? ");
    guessNo = Convert.ToInt32(Console.ReadLine());

    if (guessNo < pilotNo)
        Console.WriteLine($"{guessNo} is too low.");
    else if (guessNo > pilotNo)
        Console.WriteLine($"{guessNo} is too high.");
}
Console.WriteLine("You guessed the number!");
*/

/* Level 11 The Magic Cannon

for (int i =1; i<=100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{i}: Electric and Fire");
    }
    else if (i % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{i}: Fire");
    }
    else if (i % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{i}: Electric");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"{i}: Normal");
    }
}
 */

/* Level 12 The Replicator of D'To


using System;

int[] arr = new int[5];

for (int i = 0; i<arr.Length;i++)
{
    arr[i] = AskForNumber("Enter number: ");
 
}

int[] arrCopy = new int[5];

for (int i = 0; i < arr.Length; i++)
{
    arrCopy[i] = arr[i];
}
Console.WriteLine($"Arr: {arr[0]}, {arr[1]}, {arr[2]}, {arr[3]}, {arr[4]}");
Console.WriteLine($"ArrCopy: {arrCopy[0]}, {arrCopy[1]}, {arrCopy[2]}, {arrCopy[3]}, {arrCopy[4]}");
*/

/* Level 12 The Laws of Freach

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentSmallest = int.MaxValue; // Start higher than anything in the array.
foreach (int num in array)
{
    if (num < currentSmallest)
        currentSmallest = num;
}
Console.WriteLine(currentSmallest);

int total = 0;
foreach (int num in array)
    total += num;
float average = (float)total / array.Length;
Console.WriteLine(average);
 */

// Level 13 Taking a Number

using System.ComponentModel.Design;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

int AskForNumber (string text)
{
    Console.Write (text);
    return Convert.ToInt32 (Console.ReadLine());
}
int AskForNumberInRange(string text, int min, int max)
{
    int result = int.MinValue;

    while (result< min || result> max) 
        result = AskForNumber(text);
   
    return result;  
}

/* Level 13 Countdown

void CountToTen (int number)
{
    if (number == 0) return;
    
    Console.WriteLine(number);
    CountToTen (number -1);

}
CountToTen(10);
 */

/*
Level 14 Hunting the Manticore


int manticoreLoc = AskForNumberInRange("Player 1, how far away from the city do you want to station the Manticore? ", 0, 100);
int cityHP = 15;
int manticoreHP = 10;
int turn = 1;
int dmg;

Console.Clear ();

Console.WriteLine("Player 2, it is your turn.");


while (manticoreHP >0 && cityHP >0)
{
    Console.WriteLine("-----------------------------------");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"STATUS: Round: {turn} City: {cityHP}/15 Manticore: {manticoreHP}/10");

    if (turn % 3 == 0 && turn % 5 == 0)
        dmg = 10;
    else if (turn % 3 == 0 || turn % 5 == 0)
        dmg = 3;
    else
        dmg = 1;
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine($"The cannon is expected to deal {dmg} damage this round.");

    int shootLoc = AskForNumber("Enter desired cannon range: ");

    if (shootLoc < manticoreLoc)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("That round FELL SHORT of the target.");
    }
    else if (shootLoc > manticoreLoc)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("That round OVERSHOT the target.");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("That round was a DIRECT HIT!");
        manticoreHP -= dmg;
    }

    if (manticoreHP > 0)
        cityHP--;
    
    turn++;
}

if (manticoreHP <= 0)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("The city of Consolas has been destroyed!");
}

*/

/* Level 16 Simula's Test

ChestState lockbox = ChestState.Locked;

while(true)
{
    switch (lockbox)
    {
        case ChestState.Closed: 
            Console.Write("The chest is unlocked.");
            break;
        case ChestState.Open:
            Console.Write("The chest is open.");
            break;
        case ChestState.Locked:
            Console.Write("The chest is locked.");
            break;
    }
    Console.Write(" What do you want to do? ");

    string input = Console.ReadLine();

    if (input == "unlock" && lockbox == ChestState.Locked)
        lockbox = ChestState.Closed;
    else if (input == "lock" && lockbox == ChestState.Closed)
        lockbox = ChestState.Locked;
    else if (input=="close" && lockbox == ChestState.Open)
        lockbox = ChestState.Closed;
    else if (input == "open" && lockbox == ChestState.Closed)
        lockbox = ChestState.Open;

}
enum ChestState {Closed,Open, Locked }
 */

/* Level 17 Simula's Soup

(Type type, Ingredient ingredient, Seasoning seasoning) soup;

Console.Write("Choose a Type from ");

for (int i = 0; i < Enum.GetNames(typeof(Type)).Length; i++)
{   
    Console.Write(Enum.GetNames(typeof(Type))[i]);

    if (i != Enum.GetNames(typeof(Type)).Length - 1)
        Console.Write(", ");
    else
        Console.Write(": ");
}

string typeChosen = "";

while (!Enum.TryParse(typeChosen, true, out Type result))
{
    typeChosen = Console.ReadLine();

}
soup.type = (Type) Enum.Parse(typeof(Type),typeChosen, ignoreCase: true);

Console.Write("Choose an Ingredient from ");

for (int i = 0; i < Enum.GetNames(typeof(Ingredient)).Length; i++)
{
    Console.Write(Enum.GetNames(typeof(Ingredient))[i]);

    if (i != Enum.GetNames(typeof(Ingredient)).Length - 1)
        Console.Write(", ");
    else
        Console.Write(": ");
}

string ingredientChosen = "";

while (!Enum.TryParse(ingredientChosen, true, out Ingredient result))
{
    ingredientChosen = Console.ReadLine();

}
soup.ingredient = (Ingredient)Enum.Parse(typeof(Ingredient), ingredientChosen, ignoreCase: true);

Console.Write("Choose a Seasoning from ");

for (int i = 0; i < Enum.GetNames(typeof(Seasoning)).Length; i++)
{
    Console.Write(Enum.GetNames(typeof(Seasoning))[i]);

    if (i != Enum.GetNames(typeof(Seasoning)).Length - 1)
        Console.Write(", ");
    else
        Console.Write(": ");
}

string seasoningChosen = "";

while (!Enum.TryParse(seasoningChosen, true, out Seasoning result))
{
    seasoningChosen = Console.ReadLine();

}
soup.seasoning = (Seasoning) Enum.Parse(typeof(Seasoning), seasoningChosen, ignoreCase: true);

Console.WriteLine($"Got it, you want to make: {soup.seasoning} {soup.ingredient} {soup.type}.");

enum Type {Soup, Stew, Gumbo}
enum Ingredient {Mushroom, Chicken, Carrot, Potato}
enum Seasoning {Spicy, Salty, Sweet}
 */

/* Level 18 to 21 Vin Fletcher's Arrows

Console.WriteLine("Select which arrow to make:");
Console.WriteLine("1 - Elite Arrow");
Console.WriteLine("2 - Beginner Arrow");
Console.WriteLine("3 - Marksman Arrow");
Console.WriteLine("4 - Custom Arrow");

int input = -1;

do { input = Convert.ToInt32(Console.ReadLine()); }
while (input < 1 || input > 4);

Arrow arrow = input switch
{
    1 => Arrow.CreateEliteArrow(),
    2 => Arrow.CreateBeginnerArrow(),
    3=> Arrow.CreateMarksmanArrow(),
    4=> makeCustomArrow()
};
Console.WriteLine($"The cost of the arrow is: {arrow.Cost}");
Arrow makeCustomArrow()
{
    Console.Write("Choose an Arrowhead from ");

    for (int i = 0; i < Enum.GetNames(typeof(Arrowhead)).Length; i++)
    {
        Console.Write(Enum.GetNames(typeof(Arrowhead))[i]);

        if (i != Enum.GetNames(typeof(Arrowhead)).Length - 1)
            Console.Write(", ");
        else
            Console.Write(": ");
    }

    string input = "";
    Arrowhead arrowheadChosen = Arrowhead.Obsidian;

    while (!Enum.TryParse(input, true, out arrowheadChosen))
    {
        input = Console.ReadLine();

    }

    Console.Write("Choose a Fletching from ");

    for (int i = 0; i < Enum.GetNames(typeof(Fletching)).Length; i++)
    {
        Console.Write(Enum.GetNames(typeof(Fletching))[i]);

        if (i != Enum.GetNames(typeof(Fletching)).Length - 1)
            Console.Write(", ");
        else
            Console.Write(": ");
    }

    input = "";
    Fletching fletchingChosen = Fletching.Plastic;

    while (!Enum.TryParse(input, true, out fletchingChosen))
    {
        input = Console.ReadLine();
    }

    int length = AskForNumberInRange("Enter the shaft length in cm between 0 and 100: ", 0, 100);

    Arrow newArrow = new Arrow()
    {
        arrowHead = arrowheadChosen,
        fletching = fletchingChosen,
        length = length
    };

    return newArrow;
}

public enum Arrowhead { Steel, Wood, Obsidian}
public enum Fletching { Plastic, TurkeyFeather,GooseFeather}

public class Arrow
{
    public Arrowhead arrowHead { get; init; }
    public Fletching fletching { get; init; }
    public int length { get; init; }

    public Arrow(Arrowhead arrowhead, Fletching fletching, int length)
    {
        this.arrowHead = arrowhead;
        this.fletching = fletching;
        this.length = length;
    }
    public Arrow() { }
    
    public static Arrow CreateEliteArrow()
    {
        return new Arrow(Arrowhead.Steel,Fletching.Plastic,95);
    }
    public static Arrow CreateBeginnerArrow()
    {
        return new Arrow(Arrowhead.Wood, Fletching.GooseFeather, 75);
    }
    public static Arrow CreateMarksmanArrow()
    {
        return new Arrow(Arrowhead.Steel, Fletching.GooseFeather, 65);
    }

    public float Cost
    {
        get
        {
            float cost = 0;

            cost = arrowHead switch
            {
                Arrowhead.Steel => 10,
                Arrowhead.Wood => 3,
                Arrowhead.Obsidian => 5,
            };

            cost += fletching switch
            {
                Fletching.Plastic => 10,
                Fletching.TurkeyFeather => 5,
                Fletching.GooseFeather => 3,
            };

            cost += 0.05f * length;

            return cost;
        }
    }
}
*/

/* Level 24 The catacombs of the class
The Point

Point point1 = new Point(2, 3);
Point point2 = new Point(-4, 3);

printPoint(point1);
printPoint(point2);

void printPoint(Point point)=>Console.WriteLine($"({point.x}, {point.y})");

public class Point
{
    public int x { get; set; }
    public int y { get; set; }

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public Point () : this (0, 0) { } //calls another constructor first
}
 */

/* The Color

Color color1 = new Color(214, 234, 213);
Color color2 = Color.Blue;

Console.WriteLine($"Color 1: ({color1.red}, {color1.green}, {color1.blue})");
Console.WriteLine($"Color 2: ({color2.red}, {color2.green}, {color2.blue})");
public class Color
{
    public int red { get; set; }
    public int green { get; set; }
    public int blue { get; set; }

    public static Color Black => new Color(0, 0, 0);
    public static Color White => new Color(255, 255, 255);
    public static Color Red => new Color(255, 0, 0);
    public static Color Orange => new Color(255, 165, 0);
    public static Color Yellow => new Color(255, 255, 0);
    public static Color Blue => new Color(0, 0, 255);
    public static Color Purple => new Color(128, 0, 128);
    public Color (int red, int green, int blue)
    {
        if (red >= 0 && red <= 255 && green >= 0 && green <= 255 && blue >= 0 && blue <= 255)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }
        else
        {
            Console.WriteLine("Passed in argument is out of range. Must be between 0-255.");
        }
    }
}
*/

/* The Card

Card[,] cards = new Card[14,4];

for (int i = 0; i < 14; i++)
{
    for(int j =0;j<4;j++)
    {
        cards[i,j] = new Card(j, i);
        printCard(cards[i,j]);
    }
}

void printCard(Card card)
{
    Console.WriteLine($"The {card.Color} {card.Rank}");
}

public class Card
{
    public CardColor Color { get; set; }
    public CardRank Rank { get; set; }

    public bool isNumberCard()
    {
       switch (Rank)
        {
            case CardRank.Percentage:
            case CardRank.Ampersand:
            case CardRank.Carat:
            case CardRank.Dollar:
                return false;
            default:
                return true;
        }
    }

    public Card(int color, int rank)
    {
        if (rank >= 0 && rank <= 13 && color >= 0 & color <= 3)
        {
            Color = (CardColor)color;
            Rank = (CardRank)rank;
        }
        else 
            Console.WriteLine("Incorrect arguments, color must be 0-3 and rank 0-13"); 
    }

}
public enum CardColor
{
    Red, Green, Blue, Yellow
}

public enum CardRank {One,Two,Three,Four,Five,Six,Seven,Eight,Nine,Ten,Dollar,Percentage,Carat,Ampersand}
*/

/* The Locked Door

Console.Write("Enter passcode for door: ");
string passcode = askForPasscode();
Door aDoor = new Door(passcode);

string? command = null;

while (command != "exit")
{
    Console.Write("Enter command(unlock, lock, open, close, change passcode, exit): ");
    command = Console.ReadLine();

    switch (command)
    {
        case "unlock":
            Console.Write("Enter passcode for door: ");
            passcode = askForPasscode();
            aDoor.unlockDoor(passcode);
            break;
        case "lock":
            aDoor.lockDoor();
            break;
        case "open":
            aDoor.openDoor();
            break;
        case "close":
            aDoor.closeDoor();
            break;
        case "change passcode":
            Console.Write("Enter old passcode: ");
            passcode = askForPasscode();
            Console.Write("Enter new passcode: ");
            string newPasscode = askForPasscode();
            aDoor.changePasscode(passcode, newPasscode);
            break;
        case "exit":
            return;
    }   
}
string askForPasscode()
{
    string? passcode = null;
    
    while (passcode == null)
        passcode = Console.ReadLine();
    
    return passcode;

}
public class Door
{
    public LockState status {  get; set; }
    public string Passcode { get; private set; }

    public void closeDoor()
    {
        if (status == LockState.Open)
        {
            status = LockState.Closed;
            Console.WriteLine("The door is now closed.");
        }
        else
            Console.WriteLine("The door cannot be closed.");
    }
    public void openDoor()
    {
        if (status == LockState.Closed)
        {
            status = LockState.Open;
            Console.WriteLine("The door is now open.");
        }
        else
            Console.WriteLine("The door cannot be opened.");
    }
    public void lockDoor()
    {
        if (status == LockState.Closed)
        { 
            status = LockState.Locked;
            Console.WriteLine("The door is now locked.");
        }
        else
            Console.WriteLine("The door cannot be locked.");
    }
    public void unlockDoor(string passcode)
    {
        if (status == LockState.Locked && passcode == Passcode)
        { 
            status = LockState.Closed;
            Console.WriteLine("The door is now closed.");
        }
        else if (passcode != Passcode)
            Console.WriteLine("Incorrect Passcode");
        else
            Console.WriteLine("The door cannot be unlocked.");
    }

    public void changePasscode(string oldPasscode, string newPasscode)
    {
        if (oldPasscode == Passcode)
        {
            Passcode = newPasscode;
            Console.WriteLine($"Passcode changed to: {newPasscode}");
        }
        else
            Console.WriteLine("Incorrect Passcode provided.");

    }
    public Door(string passcode)
    {
        this.Passcode = passcode;
        status = LockState.Locked;
    }

}
public enum LockState { Closed, Open, Locked }
 */

/* The Password Validator

while (true)
{
    Console.Write("Enter password: ");
    string? input = Console.ReadLine ();

    if (input != null)
    {
        if (PasswordValidator.IsValidPassword(input))
            Console.WriteLine("That was a valid password!");
        else
            Console.WriteLine("That was an invalid password!");

    }
}

public static class PasswordValidator
{
    public static bool IsValidPassword(string password)
    {
        int digitNo = 0;
        int lowercaseNo = 0;
        int upperCaseNo = 0;

        if (password.Length >= 6 && password.Length <= 13)
        {
            foreach (char letter in password)
            {
                if (CheckTandAmpersand(letter))
                {
                    if (char.IsUpper(letter)) upperCaseNo++;
                    else if (char.IsLower(letter)) lowercaseNo++;
                    else if (char.IsDigit(letter)) digitNo++;
                }
                else
                {
                    return false;
                }
            }
        }
        else 
            return false;

        if (digitNo >=1 && lowercaseNo >=1 && upperCaseNo >=1)
            return true;
        else return false;
    }

    private static bool CheckTandAmpersand(char letter)
    {
        if (letter == 'T' || letter == '&')
            return false;
        else
            return true;
    }
}
 */

/* Tic-Tac-Toe


Game game = new Game ();

game.play();

public class Game
{
    private Player Player1  = new Player();
    private Player Player2  = new Player();
    private GameBoard Board = new GameBoard();
    private bool gameWon = false;
    public void play()
    {
        int playerTurn = 1;

        while(!gameWon)
        {
            if (playerTurn == 1)
                Console.WriteLine("It is O's turn.");
            else
                Console.WriteLine("It is X's turn.");
            
            Board.printBoardStatus();

            (int, int) move;

            if (playerTurn == 1)
                move = Player1.playTurn(Board);
            else
                move = Player2.playTurn(Board);

            Board.processTurn(move, playerTurn);

            gameWon = EndGameChecker.CheckWon(Board);

            if (gameWon)
            {
                Board.printBoardStatus();
                Console.WriteLine($"Player {playerTurn} won the game!");
            }
            else if (EndGameChecker.checkDraw(Board))
            {
                gameWon = true;
                Board.printBoardStatus();
                Console.WriteLine("No more moves left, game was a draw!");
            }
            else
            {
                if (playerTurn == 1)
                    playerTurn = 2;
                else
                    playerTurn = 1;
            }
        }
    }

}

public class Player
{
    public (int,int) playTurn(GameBoard board)
    {
        Console.Write("What square do you want to play in? ");

        string? input = null;
        bool validMove = false;
        int x = 0;
        int y = 0;

        while (input == null || validMove == false)
        { 
            input = Console.ReadLine();
            
            if (input !=null)
            {
                if (int.TryParse(input, out int number))
                {
                    int move = Convert.ToInt32(input);

                    if (move > 0 && move <= 9)
                    {
                        x = (move - 1) / 3;
                        y = (move - 1) % 3;
                        validMove = board.checkValidMove((x, y));
                    }
                    else
                        Console.WriteLine("Invalid move.");
                }
                else
                {
                    Console.WriteLine("Invalid move.");
                }
            }
        }
        return (x, y);
    }
}

public class GameBoard
{
    public int[,] BoardStatus { get; } = new int[3,3];
    
    public void printBoardStatus()
    {
        for (int i = 0; i < BoardStatus.GetLength(0); i++) 
        {
            for(int j = 0; j < BoardStatus.GetLength(1); j++)
            {
                if (BoardStatus[i,j] == 1)
                    Console.Write (" O ");
                else if (BoardStatus[i,j] == 2)
                    Console.Write (" X ");
                else
                    Console.Write ("   ");

                if (j == 0 || j==1)
                    Console.Write("|");
            }
            if (i==0||i==1)
                
                Console.WriteLine("\n---+---+---");
        }
        Console.Write("\n");
    }

    public bool checkValidMove((int,int) move)
    {
        (int x, int y) = move;
        if (BoardStatus[x,y] == 1 | BoardStatus[x,y] == 2)
        {
            Console.WriteLine("Invalid move.");
            return false;
        }
        else
            return true;
    }

    public void processTurn((int,int) move, int player)
    {
        (int x, int y) = move;
        BoardStatus[x,y] = player;
  
    }
}

static class EndGameChecker
{
    public static bool CheckWon(GameBoard board)
    {

        if (board.BoardStatus[0, 0] != 0 && board.BoardStatus[0,0] == board.BoardStatus[0, 1] && board.BoardStatus[0, 0] == board.BoardStatus[0, 2])
            return true;

        if(board.BoardStatus[1, 0] != 0 && board.BoardStatus[1, 0] == board.BoardStatus[1, 1] && board.BoardStatus[1, 0] == board.BoardStatus[1, 2])
            return true ;

        if (board.BoardStatus[2, 0] != 0 && board.BoardStatus[2, 0] == board.BoardStatus[2, 1] && board.BoardStatus[2, 0] == board.BoardStatus[2, 2])
            return true;

        if (board.BoardStatus[0, 0] != 0 && board.BoardStatus[0, 0] == board.BoardStatus[1, 0] && board.BoardStatus[0, 0] == board.BoardStatus[2, 0])
            return true;

        if (board.BoardStatus[0, 1] != 0 && board.BoardStatus[0, 1] == board.BoardStatus[1, 1] && board.BoardStatus[0, 1] == board.BoardStatus[2, 1])
            return true;

        if (board.BoardStatus[0, 2] != 0 && board.BoardStatus[0, 2] == board.BoardStatus[1, 2] && board.BoardStatus[0, 2] == board.BoardStatus[2, 2])
            return true;

        if (board.BoardStatus[0, 0] != 0 && board.BoardStatus[0, 0] == board.BoardStatus[1, 1] && board.BoardStatus[0, 0] == board.BoardStatus[2, 2])
            return true;

        if (board.BoardStatus[0, 2] != 0 && board.BoardStatus[0, 2] == board.BoardStatus[1, 1] && board.BoardStatus[0, 2] == board.BoardStatus[2, 0])
            return true;

        return false;
    }

    public static bool checkDraw(GameBoard board)
    {
        bool fullBoard = true;

        for (int i = 0; i < board.BoardStatus.GetLength(0); i++)
        {
            for (int j = 0; j < board.BoardStatus.GetLength(1); j++)
            {
                if (board.BoardStatus[i,j] ==0)
                    fullBoard = false;
            }
        }
        return fullBoard;
    }
}

*/

/* Level 25 Packing Inventory
 and Level 26 Labeling Inventory



int totalItems = AskForNumber("Please enter max item count: ");

float maxWeight;
float maxVolume;

Console.Write("Please enter max weight: ");
maxWeight = float.Parse(Console.ReadLine());

Console.Write("Please enter max volume: ");
maxVolume = float.Parse(Console.ReadLine());

Pack pack = new Pack(totalItems, maxWeight, maxVolume);

InventoryItem[] items = new InventoryItem[totalItems];

while (pack.CurrentItemCount < totalItems)
{
    Console.WriteLine(pack);
    Console.WriteLine("Options to add to pack:");
    Console.WriteLine("1 - Arrow");
    Console.WriteLine("2 - Bow");
    Console.WriteLine("3 - Rope");
    Console.WriteLine("4 - Water");
    Console.WriteLine("5 - Food");
    Console.WriteLine("6 - Sword");
    Console.WriteLine("7 - Stop, no more items to add");
    Console.Write("Please enter your option: ");

    int option = Convert.ToInt32(Console.ReadLine());
    InventoryItem itemToAdd;

    switch (option)
    {
        case 1:
            itemToAdd = new Arrow();
            break;
        case 2:
            itemToAdd = new Bow();
            break;
        case 3:
            itemToAdd = new Rope();
            break;
        case 4:
            itemToAdd = new Water();
            break;
        case 5:
            itemToAdd = new Food();
            break;
        case 6:
            itemToAdd = new Sword();
            break;
        case 7:
            Console.WriteLine("No more items to add.");
            return;
        default:
            Console.WriteLine("Invalid option, please try again.");
            continue;
    }

    if (pack.Add(itemToAdd))
    {
        Console.WriteLine($"Added {itemToAdd.GetType().Name} to pack. Pack total item count: {pack.CurrentItemCount} / {pack.TotalItems}. Current total weight: {pack.CurrentWeight} / {pack.MaxWeight}. Current total volume: {pack.CurrentVolume} / {pack.MaxVolume}.");

    }
    else
    {
        Console.WriteLine($"Could not add {itemToAdd.GetType().Name} to pack, it exceeds weight or volume limits.");
    }

}

Console.WriteLine($"Finished adding items to pack. Pack total item count: {pack.CurrentItemCount} / {pack.TotalItems}. Current total weight: {pack.CurrentWeight} / {pack.MaxWeight}. Current total volume: {pack.CurrentVolume} / {pack.MaxVolume}.");

public class InventoryItem
{
    public float Weight { get; set; }
    public float Volume { get; set; }

    public InventoryItem(float weight, float volume)
    {               
        Weight = weight;
        Volume = volume;
    }   
}
public class Arrow: InventoryItem
{
    public Arrow() : base(0.1f, 0.05f) { }

    public override string ToString() => "Arrow";


}

public class Bow : InventoryItem
{
    public Bow() : base(1, 4)
    { }

    public override string ToString() => "Bow";
}

public class Rope : InventoryItem
{
    public Rope() : base(1, 1.5f)
    { }
    public override string ToString() => "Rope";
}

public class Water : InventoryItem
{
    public Water() : base(2, 3)
    { }
    public override string ToString() => "Water";
}
public class Food : InventoryItem
{
    public Food() : base(1, 0.5f)
    { }
    public override string ToString() => "Food";
}
public class Sword : InventoryItem
{
    public Sword() : base(5, 3)
    { }
    public override string ToString() => "Sword";
}

public class Pack
{
    public InventoryItem[] Items { get; set; }

    public int TotalItems { get; }
    public float MaxWeight { get; }
    public float MaxVolume { get; }

    public float CurrentWeight
    { 
        get
        {
            float totalWeight = 0;

            foreach (InventoryItem item in Items)
            {
                totalWeight += item?.Weight ?? 0;

            }
            return totalWeight;
        }
    }

    public float CurrentVolume
    {
        get
        {
            float totalVolume= 0;

            foreach (InventoryItem item in Items)
            {
                totalVolume+= item?.Volume ?? 0;

            }
            return totalVolume;
        }
    }

    public int CurrentItemCount { get; set; } = 0;
  



    public Pack(int totalItems, float maxWeight, float maxVolume)
    {
        TotalItems = totalItems;
        MaxWeight = maxWeight;
        MaxVolume = maxVolume;
        Items = new InventoryItem[totalItems];
    }

    public bool Add (InventoryItem item)
    {
        if ((item.Weight + this.CurrentWeight <= MaxWeight) && (item.Volume + this.CurrentVolume <= MaxVolume) && (CurrentItemCount < TotalItems))
        {
            Items[CurrentItemCount] = item;
            CurrentItemCount++;
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string ToString()
    {
        string? items = null;

        foreach (InventoryItem item in Items)
        {
            if (item != null)
            {
                if (items == null)
                    items = item.ToString();
                else
                    items += $" {item.ToString()}";
            }
        }

        if (items == null)
            items = "nothing";

        return $"Pack containing {items}.";
    }


}
*/

/* Level 26 The Old Robot
and Level 27 Robotic Interface


int commandNo = 1;
IRobotCommand?[] commands = new IRobotCommand[3];

while (commandNo<=3)
{
    Console.WriteLine("Command options:");
    Console.WriteLine("1 - On Command");
    Console.WriteLine("2 - Off Command");
    Console.WriteLine("3 - North Command");
    Console.WriteLine("4 - South Command");
    Console.WriteLine("5 - West Command");
    Console.WriteLine("6 - East Command");
    Console.Write("Please enter your command: ");
    int option = Convert.ToInt32(Console.ReadLine());

    commands[commandNo-1] = option switch
    {
        1 => new OnCommand(),
        2 => new OffCommand(),
        3 => new NorthCommand(),
        4 => new SouthCommand(),
        5 => new WestCommand(),
        6 => new EastCommand(),
        _ => null
    };
    commandNo++;
}

Robot robot = new Robot(commands);
robot.Run();



public abstract class RobotCommand
{
    public abstract void Run(Robot robot);
}

public class  OnCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}

public class OffCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}
public class NorthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
            robot.Y++;
        else
            Console.WriteLine("Robot is not powered, cannot move North.");
    }
}

public class SouthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
            robot.Y--;
        else
            Console.WriteLine("Robot is not powered, cannot move South.");
    }
}
public class WestCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
            robot.X--;
        else
            Console.WriteLine("Robot is not powered, cannot move West.");
    }
}
public class EastCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
            robot.X++;
        else
            Console.WriteLine("Robot is not powered, cannot move East.");
    }
}

public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }
    public IRobotCommand?[] Commands { get; } = new IRobotCommand?[3];

    public Robot(IRobotCommand?[] command)
    { Commands = command; }
    public void Run()
    {
        foreach (IRobotCommand? command in Commands)
        {
            command?.Run(this);
            Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }

    }
}
 */
/* Level 27 Robotic Interface
 
public interface IRobotCommand
{
    void Run(Robot robot);
}
*/

/* Level 28 Room Coordinates


Coordinate coordinate1 = new Coordinate(2, 6);
Coordinate coordinate2 = new Coordinate(2, 3);
Console.WriteLine(coordinate1.IsAdjacent(coordinate2));
public struct Coordinate
{
    public readonly int Row { get; }
    public readonly int Column { get; }

    public Coordinate(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public bool IsAdjacent(Coordinate otherCoordinate)
    {
        if (Row==otherCoordinate.Row && (Math.Abs(Column-otherCoordinate.Column) <=1)|| (Column == otherCoordinate.Column && (Math.Abs(Row - otherCoordinate.Row) <= 1)))
            return true;
        else
            return false;
    }
}
 */

/* Level 29 Records


Sword sword1 = new Sword (Material.Iron, GemStone.None,10,10);
Console.WriteLine(sword1);
Sword sword2 = sword1 with {Material = Material.Binarium };
Console.WriteLine(sword2);
Sword sword3 = sword1 with { GemStone = GemStone.Diamond,Length=5};
Console.WriteLine(sword3);
public record Sword (Material Material, GemStone GemStone, int Length, int Width);

public enum Material { Wood, Bronze, Iron, Steel, Binarium}

public enum GemStone { None, Emerald, Amber, Sapphire, Diamond, Bitstone }
 */

/* Level 30 Colored Items


ColoredItem<Sword> coloredSword = new ColoredItem<Sword>();
ColoredItem<Bow> coloredBow = new ColoredItem<Bow>();
ColoredItem<Axe> coloredAxe = new ColoredItem<Axe>();

coloredSword.Display();
coloredBow.Display();
coloredAxe.Display();

public class Sword { }
public class Bow { }
public class Axe { }

public class ColoredItem<T> where T : new()
{
    public ConsoleColor Color { get; }
    public T Item { get;} = new T();

    public ColoredItem()
    {
        if (typeof(T) == typeof(Sword))
            Color = ConsoleColor.Red;
        else if (typeof(T) == typeof(Bow))
            Color = ConsoleColor.Green;
        else if (typeof(T) == typeof(Axe))
            Color = ConsoleColor.Blue;
    }

    public void Display()
    {
        Console.ForegroundColor = Color;
        Console.WriteLine(Item);
    }
}
 */

/*Level 31 The Fountain of Objects
 *  and Small, Medium, or Large 
 *  and Pits
 *  and (Level 32) Time in the Cavern

Game game = new Game();
game.Play();
public class Game
{
    public GameBoard Board { get; } 
    public InputHandler InputHandler { get; } 
    public LocationMessage LocationMessage { get; }
    public UserInputMessage UserInputMessage { get; }
    public SystemMessage DashMessage { get; }

    private Position _currentPosition; 
    public Position CurrentPosition
    {
        get => _currentPosition;
        set
        {
            _currentPosition = value;
            LocationMessage.UpdateLocationMessage(_currentPosition);
            
        }
    }

    public DateTime GameCreationTime { get;}
    public Game()
    {
        GameCreationTime = DateTime.Now;
        Board = new GameBoard();
        InputHandler = new InputHandler(Board);
        _currentPosition = new Position();
        LocationMessage = new LocationMessage();
        UserInputMessage = new UserInputMessage();
        DashMessage = new SystemMessage("--------------------------------------------------------------------------------");
    }

    public void Play()
    {
        while(true)
        {
            GameObjConsoleWriter.WriteLine(DashMessage);
            GameObjConsoleWriter.WriteLine(LocationMessage);

            if (Board.Room[CurrentPosition.Row, CurrentPosition.Column].Text is not null)
                GameObjConsoleWriter.WriteLine(Board.Room[CurrentPosition.Row, CurrentPosition.Column]);
            

            if (checkGameWin())
            {
                SystemMessage winMessage = new SystemMessage("You win!");
                GameObjConsoleWriter.WriteLine(winMessage);
                break;
            }

            if (checkGameOver())
                break;
            
            GameObjConsoleWriter.Write(UserInputMessage);
          
            string? input = Console.ReadLine();
            CurrentPosition = InputHandler.ProcessInput(CurrentPosition, input);
        }

        DateTime gameEndTime = DateTime.Now;
        TimeSpan gameDuration = gameEndTime - GameCreationTime;

        Console.WriteLine($"Game duration: {gameDuration.Hours} hours, {gameDuration.Minutes} minutes and {gameDuration.Seconds} seconds.");
    }

    public bool checkGameWin()
    {
        FountainRoom fountainRoom = Board.FountainRoom!;
        if (CurrentPosition.Row==0 && CurrentPosition.Column == 0)
            return fountainRoom.IsFountainActive;
        return false;
    }

    public bool checkGameOver()
    {
        if (Board.Room[CurrentPosition.Row, CurrentPosition.Column] is PitRoom)
            return true;
        return false;
    }
}

public class InputHandler
{
    private GameBoard _board;
    private SystemMessage errorMessage = new SystemMessage("You cannot move outside the board.");
    private SystemMessage invalidMessage = new SystemMessage("Invalid command. Please try again.");
    public InputHandler(GameBoard board)
    {
        _board = board;
    }

    public Position ProcessInput(Position coordinate, string? input)
    {
        Position? newCoordinate = new Position(coordinate.Row, coordinate.Column);

        switch (input)
        {
            case "move north":
                newCoordinate.Row = newCoordinate.Row - 1;
                break;
            case "move south":
                newCoordinate.Row = newCoordinate.Row + 1;
                break;
            case "move east":
                newCoordinate.Column = newCoordinate.Column + 1;
                break;
            case "move west":
                newCoordinate.Column = newCoordinate.Column - 1;
                break;
            default:
                newCoordinate = null;
                break;
        }

        if (newCoordinate?.Row < 0 || newCoordinate?.Row >= _board.Room.GetLength(0) ||
            newCoordinate?.Column < 0 || newCoordinate?.Column >= _board.Room.GetLength(1))
        {
            GameObjConsoleWriter.WriteLine(errorMessage);
            return coordinate;
        }

        if (newCoordinate is null)
        {
            NonMovementInputHandler(coordinate, input);
            return coordinate;
        }
        else
            return (newCoordinate);
    }

    public void NonMovementInputHandler(Position coordinate, string? input)
    {
        IRoom currentRoom = (IRoom) _board.Room[coordinate.Row, coordinate.Column];

        if(!currentRoom.processInput(input))
            GameObjConsoleWriter.WriteLine(invalidMessage);
    }
       
}

public class Position
{
    public int Row { get; set; }
    public int Column { get; set; }

    public Position()
    { Row = 0;
        Column = 0;
    }
    public Position(int row, int column)
    {
        Row = row;
        Column = column;
    }

}

public class GameBoard
{
    public GameObject[,] Room { get; init; }
    Random random = new Random();
    public FountainRoom? FountainRoom { get; init; }
    public GameBoard()
    {
        string? input;

        while (true) { 
        Console.Write("Please pick small, medium or large game: ");
        input = Console.ReadLine();
            if (input!="small" && input != "medium" && input != "large")
                Console.WriteLine("Invalid input, please try again.");
            else
                break;
        }

        int size = (int)((gameSize)Enum.Parse(typeof(gameSize), input, ignoreCase: true));
        
        Room = new GameObject[size, size];
     
        Room[0,0] = new EntranceRoom();

        (int randomRow, int randomCol) = GenerateRandomCoordinates(size);
        Room[randomRow, randomCol] = new FountainRoom((EntranceRoom)Room[0, 0]);
        FountainRoom = (FountainRoom)Room[randomRow, randomCol];
        
            for (int i = 0; i < Room.GetLength(0); i++)
            {
                for (int j = 0; j < Room.GetLength(1); j++)
                {
                    if (Room[i, j] is null)
                        Room[i, j] = new EmptyRoom();
                }
            }
        GeneratePits(size);
    }


    public (int, int) GenerateRandomCoordinates(int size)
    {
        int randomRow = 0;
        int randomCol = 0;

        while (Room[randomRow, randomCol] != null && (Room[randomRow, randomCol].GetType() != typeof(EmptyRoom)) )
        {
            randomRow = random.Next(0, size);
            randomCol = random.Next(0, size);
        }
        return (randomRow, randomCol);
    }

    public void GeneratePits(int size)
    {
        int pitCount = size switch
        {
            4 => 1,
            6 => 2,
            8 => 4,
            _ => 0
        };

        for (int i = 0; i < pitCount; i++)
        {
            (int randomRow, int randomCol) = GenerateRandomCoordinates(size);
            Room[randomRow, randomCol] = new PitRoom(Room);

            if (randomRow - 1 >= 0)
                AddPitMessage(randomRow - 1, randomCol);
            if (randomCol - 1 >= 0)
                AddPitMessage(randomRow, randomCol - 1);
            if (randomRow + 1 < Room.GetLength(0))
                AddPitMessage(randomRow + 1, randomCol);
            if (randomCol + 1 < Room.GetLength(1))
                AddPitMessage(randomRow, randomCol + 1);
            if (randomRow - 1 >= 0 && randomCol - 1 >= 0)
                AddPitMessage(randomRow - 1, randomCol - 1);
            if (randomRow - 1 >= 0 && randomCol + 1 < Room.GetLength(1))
                AddPitMessage(randomRow - 1, randomCol + 1);
            if (randomRow + 1 < Room.GetLength(0) && randomCol - 1 >= 0)
                AddPitMessage(randomRow + 1, randomCol - 1);
            if (randomRow + 1 < Room.GetLength(0) && randomCol + 1 < Room.GetLength(1))
                AddPitMessage(randomRow + 1, randomCol + 1);
        }

        void AddPitMessage(int row, int col)
        { if (Room[row, col].Text is not null)
              Room[row, col].Text += "\n";
          Room[row, col].Text += "You feel a draft. There is a pit in a nearby room."; }

    }
}
public class EntranceRoom : GameObject, IRoom
{
    public EntranceRoom()
    {
        Text = "You see light in this room coming from outside the cavern. This is the entrance.";
        Color = ConsoleColor.Yellow;
      
    }

    public bool processInput(string? input)
    {
        return false;
    }
}

public class FountainRoom : GameObject, IRoom
{
    private bool _IsFountainActive;
    private EntranceRoom _entranceRoom;
    public bool IsFountainActive
    {
        get => _IsFountainActive;
        set
        {
            _IsFountainActive = value;
            UpdateText();
        }
    }
    public FountainRoom(EntranceRoom entranceRoom)
    {
        IsFountainActive = false;
        Color = ConsoleColor.Blue;
        _entranceRoom = entranceRoom;
    }
    public void UpdateText()
    {
        if (IsFountainActive)
            Text = "You hear the rushing waters from the Fountain of Objects. It has been reactivated!";
        else
            Text = "You hear water dripping in this room.The Fountain of Objects is here!";
    }

    public bool processInput(string? input)
    {
        switch (input)
        {
            case "enable fountain":
                IsFountainActive = true;
                _entranceRoom.Text = "The Fountain of Objects has been reactivated, and you have escaped with your life!";
                return true;
            default:
                return false;
        }
    }

}

public class  PitRoom : GameObject, IRoom
{
    public PitRoom(GameObject[,] Room)
    {
        Color = ConsoleColor.DarkRed;
        Text = "You fell into a pit and died. Game over.";
    }
    public bool processInput(string? input)
    {
        return false;
    }

}
public class EmptyRoom : GameObject, IRoom
{
    public bool processInput(string? input)
    {
        return false;
    }

}

public interface IRoom
{
    public bool processInput(string? input);
}


public class GameObject
{
    public ConsoleColor Color { get; init; } = ConsoleColor.Gray;
    public string? Text { get; set; } 
}

public class LocationMessage : GameObject
{
    public LocationMessage()
    {
        Color = ConsoleColor.Magenta;
        UpdateLocationMessage(new Position(0, 0));
    }

    public void UpdateLocationMessage(Position coordinate)
    {
        Text = $"You are in the room at (Row={coordinate.Row}, Column={coordinate.Column}).";
    }

}

public class UserInputMessage : GameObject
{
    public UserInputMessage()
    {
        Text = $"What do you want to do? ";
        Color = ConsoleColor.Cyan;
    }
}

public class SystemMessage : GameObject
{
    public SystemMessage(string message)
    {
        Text = message;
        Color = ConsoleColor.White;
    }
}

public static class GameObjConsoleWriter
{
    public static void WriteLine(GameObject gameObject)
    {
        Console.ForegroundColor = gameObject.Color;
        Console.WriteLine(gameObject.Text);
    }

    public static void Write(GameObject gameObject)
    {
        Console.ForegroundColor = gameObject.Color;
        Console.Write(gameObject.Text);
    }
}


enum gameSize
{
    Small=4,
    Medium=6,
    Large=8
}
*/

/* Level 32 The Robot Pilot
 

Random random = new Random();

int manticoreLoc = random.Next(101);
int cityHP = 15;
int manticoreHP = 10;
int turn = 1;
int dmg;

while (manticoreHP > 0 && cityHP > 0)
{
    Console.WriteLine("-----------------------------------");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"STATUS: Round: {turn} City: {cityHP}/15 Manticore: {manticoreHP}/10");

    if (turn % 3 == 0 && turn % 5 == 0)
        dmg = 10;
    else if (turn % 3 == 0 || turn % 5 == 0)
        dmg = 3;
    else
        dmg = 1;
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine($"The cannon is expected to deal {dmg} damage this round.");

    int shootLoc = AskForNumber("Enter desired cannon range: ");

    if (shootLoc < manticoreLoc)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("That round FELL SHORT of the target.");
    }
    else if (shootLoc > manticoreLoc)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("That round OVERSHOT the target.");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("That round was a DIRECT HIT!");
        manticoreHP -= dmg;
    }

    if (manticoreHP > 0)
        cityHP--;

    turn++;
}

if (manticoreHP <= 0)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("The city of Consolas has been destroyed!");
}
*/

/* Level 32 List of Commands
 */

int commandNo = 1;
List<IRobotCommand> commands = new List<IRobotCommand>();
IRobotCommand? newCommand;
Robot robot = new Robot();
string? input="";

while (input !="stop")
{
    Console.WriteLine("Command options:");
    Console.WriteLine("1 - On Command");
    Console.WriteLine("2 - Off Command");
    Console.WriteLine("3 - North Command");
    Console.WriteLine("4 - South Command");
    Console.WriteLine("5 - West Command");
    Console.WriteLine("6 - East Command");
    Console.Write("Please enter your command: ");

    input = Console.ReadLine();
    int option;

    if (int.TryParse(input, out option))
    {

        newCommand = option switch
        {
            1 => new OnCommand(),
            2 => new OffCommand(),
            3 => new NorthCommand(),
            4 => new SouthCommand(),
            5 => new WestCommand(),
            6 => new EastCommand(),
            _ => null
        !
        };

        robot.AddCommand(newCommand);
    }
}

robot.Run();


public class OnCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}

public class OffCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}
public class NorthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
            robot.Y++;
        else
            Console.WriteLine("Robot is not powered, cannot move North.");
    }
}

public class SouthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
            robot.Y--;
        else
            Console.WriteLine("Robot is not powered, cannot move South.");
    }
}
public class WestCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
            robot.X--;
        else
            Console.WriteLine("Robot is not powered, cannot move West.");
    }
}
public class EastCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
            robot.X++;
        else
            Console.WriteLine("Robot is not powered, cannot move East.");
    }
}

public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }
    public List<IRobotCommand> Commands { get; } = new List<IRobotCommand>();

    public void Run()
    {
        foreach (IRobotCommand command in Commands)
        {
            command?.Run(this);
            Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }

    }

    public void AddCommand(IRobotCommand? command)
    {
        if (command != null)
            Commands.Add(command);
        else
            Console.WriteLine("Invalid command, please try again.");
    }
}

public interface IRobotCommand
{
    void Run(Robot robot);
}