// Parametr olaraq string qebul eden metod yazmalisiz. Hemin metod qebul etdiyi stringi tersine formada ekranda gostersin.
// (Cavid gelirse , ekranda divaC gorsensin).



Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("MR.Green");
Console.WriteLine("salam, yazi, reqemi daxil edin ");

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("MR.Blue");
string originalString = Console.ReadLine();
string reversedString = ReverseString(originalString);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("terse cevrildi");
Console.WriteLine(reversedString);
Console.ForegroundColor = ConsoleColor.White;


string ReverseString(string input)
{
    char[] charArray = input.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}



#region tekrar

//string originalString = "Cavid ";
//string reversedString = ReverseString(originalString);
//Console.WriteLine(reversedString);

//string ReverseString(string input)
//{ 
// char[] charArray = input.ToCharArray();
// Array.Reverse(charArray);
// return new string(charArray);
//}


//string originalString = "Cavid ";
//string reversedString = ReverseString(originalString);
//Console.WriteLine(reversedString);

//string ReverseString(string input)
//{ 
// char[] charArray = input.ToCharArray();
// Array.Reverse(charArray);
// return new string(charArray);
//}


//string originalString = "Cavid ";
//string reversedString = ReverseString(originalString);
//Console.WriteLine(reversedString);

//string ReverseString(string input)
//{ 
// char[] charArray = input.ToCharArray();
// Array.Reverse(charArray);
// return new string(charArray);
//}

//string originalString = "Cavid ";
//string reversedString = ReverseString(originalString);
//Console.WriteLine(reversedString);

//string ReverseString(string input)
//{ 
// char[] charArray = input.ToCharArray();
// Array.Reverse(charArray);
// return new string(charArray);
//}

//string originalString = "Cavid ";
//string reversedString = ReverseString(originalString);
//Console.WriteLine(reversedString);

//string ReverseString(string input)
//{ 
// char[] charArray = input.ToCharArray();
// Array.Reverse(charArray);
// return new string(charArray);
//}
#endregion

//int[] arr = { 1, 2, 3, 4 };

//arr[0] = 5;
//Console.WriteLine(arr[0]);

