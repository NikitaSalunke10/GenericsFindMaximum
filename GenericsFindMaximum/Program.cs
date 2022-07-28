using GenericsFindMaximum;

int[] intArray = { 24, 65, 23, 54, 76, 45 };
GenericsMaximum<int> generic = new GenericsMaximum<int>(intArray);
generic.PrintMaxValue();
double[] doubleArray = { 52.1, 96.92, 25.65, 63.76 };
GenericsMaximum<double> genericDouble = new GenericsMaximum<double>(doubleArray);
genericDouble.PrintMaxValue();
string[] stringArray = { "Apple", "Peach", "Banana", "Orange" };
GenericsMaximum<string> genericString = new GenericsMaximum<string>(stringArray);
genericString.PrintMaxValue();


//int output = MaximumNumberCheck.MaximumIntegerNumber(23, 18, 10);
//Console.WriteLine("Maximum Number is "+output);

//double doubleoutput = MaximumNumberCheck.MaximumFloatNumber(52.1, 76.92, 25.65);
//Console.WriteLine("Maximum Float Number is "+doubleoutput);

//string stringOutput = MaximumNumberCheck.MaximumStringNumber("Apple", "Peach", "Banana");
//Console.WriteLine("Maximum String input is " + stringOutput);

//int[] arr = { 24, 65, 23, 54, 76, 45, 19 };
//int output = MaximumNumberCheck.findMax(arr);
//Console.WriteLine("Maximum number is "+output);

//double[] doublearr = { 52.1, 76.92, 25.65, 63.76 };
//double doubleoutput = MaximumNumberCheck.findMax(doublearr);
//Console.WriteLine("Maximum number is " + doubleoutput);


//string[] stringarr = { "Apple", "Peach", "Banana", "Orange" };
//string stringoutput = MaximumNumberCheck.findStringMax(stringarr);
//Console.WriteLine("Maximum number is " + stringoutput);