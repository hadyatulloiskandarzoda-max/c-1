//1
//int max = int.MinValue;
//while (true)
//{
//int a = Convert.ToInt32(Console.ReadLine());
//if(a==0) break;
//if(a>max) max=a; 

//}
//System.Console.WriteLine(max);
//2
//string[] input = Console.ReadLine().Split();

// int a = int.Parse(input[0]);
//      int n = int.Parse(input[1]);
//    int sum=0;
//   int power=1;
//     for(int i=0; i<=n; i++)
//{
//    sum+=power;
//    power*=a;
//}
// Console.WriteLine(sum);

//3
// string[] input = Console.ReadLine().Split();
//int sum = 0;
//bool Zero = false;
//
//foreach (string s in input)
//{
//    int num = int.Parse(s);
//
//    if (num == 0)
//    {
//        if (Zero) break; 
//       Zero = true;
//    }
//    else
//    {
//        sum += num;
//        Zero = false;
//    }
//    Console.WriteLine(sum); 
//}
//6
//  string[] input = Console.ReadLine().Split();
//  int min = int.MaxValue;
//  foreach (string s in input)
//{
//    int num = int.Parse(s);
//    if(num<min)
//    {  min=num;
//    }
//  Console.WriteLine(min);
//}
//8
//string[] input = Console.ReadLine().Split();
//int sum=0;
//int product=1;
// foreach (string s in input)
//{
//    int num = int.Parse(s);
//    sum += num;
//    product *= num;
//}
// Console.WriteLine($"{input[0]}+{input[1]}+{input[2]}={sum}");
//    Console.WriteLine($"{input[0]}*{input[1]}*{input[2]}={product}");
//9
//   int n = int.Parse(Console.ReadLine()); 
//        int rev = 0;
//
//    while(num>0)
//{
//    int d=n%10;
//    rev=rev*10+d;
//    n/=10;
//}
//Console.WriteLine(rev);








