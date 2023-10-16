int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a>b && a>c)
{
    System.Console.WriteLine($"max {a}");
}
else
    if(b>c)
    System.Console.WriteLine($"max{b}");
    else
    System.Console.WriteLine($"max{c}");
    



//  int max = a;
//         if (max < b)
//         {
//             max = b;
//         }
//         if (max < c)
//         {
//             max = c;
//         }
//         return max;