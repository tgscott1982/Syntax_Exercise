#region Syntax Exercise Original Example

int answer = 4; //explicitly declared and assigned variable
string response; //explicitly declared variable
if (answer < 9)  
{
    response = answer + " is less than nine";
}
else
{
    response = answer + " is greater than or equal to nine";
}

Console.WriteLine(response);
Console.WriteLine();  //empty space between the two console outputs
#endregion


#region Syntax Exercise Updated Example

var newAnswer = 4; //implicitly declared and assigned variable

 /*also learned via error you CANNOT implicitly declare a variable
without assigning it a value*/

// imlicit variable             //syntax sugar AND ternary operator                  
var newResponse = newAnswer < 9 ? $"{newAnswer} is less than nine" : 
                                  $"{newAnswer} is greater than or equal to nine";

Console.WriteLine(newResponse);

#endregion