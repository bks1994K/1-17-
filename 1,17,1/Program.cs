using _1_17_1;

int[] array = new int[] { 0,2,3,4,5,6,7,8,9 };

int mins = ArrayHandler.FindMinElementOfArray(array);
int maxs = ArrayHandler.FindMaxElementOfArray(array);
int indexMins = ArrayHandler.FindIndexOfMinElementOfArray(array);
int indexMaxs = ArrayHandler.FindIndexOfMaxElementOfArray(array);
int summElementsOddIndex = ArrayHandler.SummElementsWithOddIndexOfArray(array);
int[] mirrow = ArrayHandler.MirroredArray(array);
ArrayHandler.WriteArrayToConsole(mirrow);
int oddElements = ArrayHandler.CountOddElementsInArray(array);
int[] swappedEven = ArrayHandler.SwappedHalfOTheArray(array);
ArrayHandler.WriteArrayToConsole(swappedEven);


Console.WriteLine(mins);
Console.WriteLine(maxs);
Console.WriteLine(indexMins);
Console.WriteLine(indexMaxs);
Console.WriteLine(summElementsOddIndex);
Console.WriteLine(mirrow);
Console.WriteLine(oddElements);
Console.WriteLine();
Console.WriteLine(swappedEven);
