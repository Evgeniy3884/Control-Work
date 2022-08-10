string [] arrayA = {"Hello","ok","goodbye","Start","atm","big","water","friend","hi","n","cafe"}; 
int L = 0; 
int lengthArray=arrayA.Length; 
for(int i = 0;i<lengthArray;i++) 
{
    if(arrayA[i].Length <= 3 ) 
     L++;
}
string[]arrayB = new string[L]; 
int j = 0; 
for(int i=0;i<lengthArray;i++) 
{ 
    if(arrayA[i].Length <= 3 ) 
    {
        arrayB[j] = arrayA[i];
        j++;
    }
} 
Console.WriteLine($"Отсортированный массив: [{string.Join(", ", arrayB)}]");