// Parametr olaraq string qebul eden metod yazmalisiz. Hemin metod qebul etdiyi stringi tersine formada ekranda gostersin.
// (Cavid gelirse , ekranda divaC gorsensin).




string originalString = "Cavid";
string reversedString = ReverseString(originalString);
Console.WriteLine(reversedString);
   
string ReverseString(string input)
{ 
 char[] charArray = input.ToCharArray();
 Array.Reverse(charArray);
 return new string(charArray);
}

Console.WriteLine();
