using GenericsFindMaximum;

//int output = MaximumNumberCheck.MaximumIntegerNumber(23, 18, 10);
//Console.WriteLine("Maximum Number is "+output);

//double doubleoutput = MaximumNumberCheck.MaximumFloatNumber(52.1, 76.92, 25.65);
//Console.WriteLine("Maximum Float Number is "+doubleoutput);

//string stringOutput = MaximumNumberCheck.MaximumStringNumber("Apple", "Peach", "Banana");
//Console.WriteLine("Maximum String input is " + stringOutput);

int[] arr = { 24, 65, 23, 54, 76, 45, 19 };
int output = MaximumNumberCheck.findMax(arr);
Console.WriteLine("Maximum number is "+output);

double[] doublearr = { 52.1, 76.92, 25.65, 63.76 };
double doubleoutput = MaximumNumberCheck.findMax(doublearr);
Console.WriteLine("Maximum number is " + doubleoutput);


string[] stringarr = { "Apple", "Peach", "Banana", "Orange" };
string stringoutput = MaximumNumberCheck.findStringMax(stringarr);
Console.WriteLine("Maximum number is " + stringoutput);