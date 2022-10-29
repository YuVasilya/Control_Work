Console.Clear();

string[] array = { "Hello", "2", "world", ":-)" };
int size = array.Length;
string[] newArray = new string[new Random().Next(0, 3)];
Console.WriteLine($"newArray.Length = {newArray.Length}");
int j = 0;
Console.WriteLine("newArray: ");
for (int i = 0; i < newArray.Length; i++)
{
    j = new Random().Next(array.Length);
    newArray[i] = array[j];
    Console.Write(newArray[i]+" ");       
}


