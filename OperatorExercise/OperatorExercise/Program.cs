int additionNumberOne;
int additionNumberTwo;

int subtractionNumberOne;
int subtractionNumberTwo;

int multiplicationNumberOne;
int multiplicationNumberTwo;

int a; // named a to follow assignment rules. represents numerator.
int b; // named b to follow assignment rules. represents denominator.
int remainder; 

Console.WriteLine("Let's add some numbers! What would you like to add first?");
additionNumberOne = int.Parse(Console.ReadLine());
Console.WriteLine($"{additionNumberOne}? Great! What is your second number?");
additionNumberTwo = int.Parse(Console.ReadLine());
Console.WriteLine($"Let me think... {additionNumberOne} plus {additionNumberTwo} is {additionNumberOne + additionNumberTwo}. I'm so smart!");

Console.WriteLine("Don't stop now! Let's subtract some numbers! What's your first number?");
subtractionNumberOne = int.Parse(Console.ReadLine());
Console.WriteLine($"{subtractionNumberOne}? Great! What is your second number?");
subtractionNumberTwo = int.Parse(Console.ReadLine());
Console.WriteLine($"Let me think... {subtractionNumberOne} minus {subtractionNumberTwo} is {subtractionNumberOne - subtractionNumberTwo}. Right?");

Console.WriteLine("Don't stop now! Let's multiply some numbers! What's your first number?");
multiplicationNumberOne = int.Parse(Console.ReadLine());
Console.WriteLine($"{multiplicationNumberOne}? Great! What is your second number?");
multiplicationNumberTwo = int.Parse(Console.ReadLine());
Console.WriteLine($"Let me think... {multiplicationNumberOne} times {multiplicationNumberTwo} is {multiplicationNumberOne * multiplicationNumberTwo}. Jeez, that was hard!");

Console.WriteLine("I'm feeling really smart today, I'm going to try and divide. Give me that first number!");
a = int.Parse(Console.ReadLine());
Console.WriteLine($"{a}? Great! What is your second number?");
b = int.Parse(Console.ReadLine());
remainder = a % b;
Console.WriteLine($"Let me think... {a} divided by {b} is {a / b}, with a remainder of {remainder}. I don't want to do math anymore!");
