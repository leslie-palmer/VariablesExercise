// See https://aka.ms/new-console-template for more information
string myName = "Leslie";
int myAge = 27;
char aLetter = 'Q';
bool trooFalse = false;
double bigNum = 2147483648;
decimal smallNum = 1.2M;
Console.WriteLine("Hello, World! My name is " + myName + ". I am " + myAge + " years old!");
Console.WriteLine("Here is a letter: " + aLetter);
Console.WriteLine("Here is a boolean value: " + trooFalse);
Console.WriteLine("Here's a number that's too big to be an int: " + bigNum);
Console.WriteLine("And finally here's a decimal: " + smallNum);
// Only error I encountered is when trying to declare the decimal.
// You need to put an M at the end of the number otherwise the compiler believes you're trying to declare a double.
