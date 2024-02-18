string[] find(string[] array_input)
{
    string[] array_output = new string[array_input.Length];
    int o = 0;
    for(int i = 0; i < array_input.Length; i++)
    {
        if(array_input[i].Length < 4)
        {
            array_output[o] = array_input[i];
            o++;
        }
    }
    Array.Resize(ref array_output, o);
    return array_output;
}

string[] array1 = new string[4];
array1 = ["Hello", "2", "world", ":-)"];
Console.WriteLine("1)[“Hello”, “2”, “world”, “:-)”]  =>  ");
Console.WriteLine(string.Join(",",find(array1)));

string[] array2 = new string[4];
array2 = ["1234", "1567", "-2", "computer science"];
Console.WriteLine("2)[“1234”, “1567”, “-2”, “computer science”]  =>  ");
Console.WriteLine(string.Join(",",find(array2)));

string[] array3 = new string[3];
array3 = ["Russia", "Denmark", "Kazan"];
Console.WriteLine("3)[“Russia”, “Denmark”, “Kazan”]  =>  ");
Console.WriteLine(string.Join(",",find(array3)));
