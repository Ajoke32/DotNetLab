

using DotNet2;

/*
string a = "Some text/and";
Console.WriteLine($"Reversed text:{a.ReverseStr()}");
Console.WriteLine(a.GetSymbolCount('a'));

string[] arr = {"sttr1", "str2", "str3" };
int[] arr2 = { 2, 5, 6 ,7,8,6,2,12,15,43,54,2,2,145,543};


Console.WriteLine($"srting arr count:{arr.GetValueCount("a")}");
Console.WriteLine($"int arr count: {arr2.GetValueCount(2)}");

Console.Write("Unique values: ");
foreach(var item in arr2.Unique())
{
    Console.Write($" {item}");
}
*/


var dict = new ExDictionary<string, string, int>();
var d = new Dictionary<int, string>()
{
    {1,"a"},
    {2,"b"}
};
int i = 0;
foreach (var item in d)
{
    Console.WriteLine(item);
  
}

dict.Add("User", "string1", 2);
dict.Add("User2", "string2", 4);



foreach (ExDictionary<string, string, int>.Entity item in dict)
{
    Console.WriteLine(new ExDictionaryElement<string,string,int>(item).Key);
}




