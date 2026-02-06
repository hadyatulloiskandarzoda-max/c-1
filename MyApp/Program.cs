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
string[] input = Console.ReadLine().Split();
         int  sum=0;
      float cnt=false;
      foreach(string s in input)
{
    int num = int.Parse(s);
    if(num == 0)

    {
        if(cnt) break;
        cnt=true;
    }
    else{}
}








