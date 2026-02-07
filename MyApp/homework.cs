//2
//int[] arr = new int[5];
//
//int product=1;
// for (int i = 0; i < 5; i++)
//{
//    int num = int.Parse(Console.ReadLine());
//    arr[i] = num;
//    product *= num;
//}
// Console.WriteLine($"{arr[0]}*{arr[1]}*{arr[2]}*{arr[3]}*{arr[4]}={product}");
 
// 3
//int[] arr = new int[5];
//       for (int i = 0; i < 5; i++)
//       {
//           arr[i] = int.Parse(Console.ReadLine());
//       }
//      
//       int max = arr[0];
//       int index = 0;
//       for (int i = 0; i < 5; i++)
//       {
//           if (arr[i] > max)
//           {
//               max = arr[i];
//               index = i;
//           }
//       }
//       Console.WriteLine(index);

//4
// int[] arr = new int[6];
//       for (int i = 0; i < 6; i++)
//       {
//          arr[i] = int.Parse(Console.ReadLine());
//       }
// for (int i = 0; i < 6; i++)
// {
//     int cnt = 0;
//     for (int j = 0; j < 6; j++)
//     {
//         if (arr[i] == arr[j])
//             cnt++;
//     }
//     if (cnt == 1)
//         Console.Write(arr[i] + " ");
// }

    
// 5
//   int[] arr = new int[5];
//
//        for (int i = 0; i < 5; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }
//
//        int min = arr[0]; 
//        int index = 0;    
//
//        for (int i = 0; i < 5; i++)
//        {
//            if (arr[i] < min)
//            {
//                min = arr[i];
//                index = i;
//            }
//        }
//         Console.WriteLine(index);

//6  
 //  int[] arr = new int[5];
//
 //       for (int i = 0; i < 5; i++)
 //       {
 //           arr[i] = int.Parse(Console.ReadLine());
 //       }
//
 //       int cnt=0;     
//
 //       for (int i = 1; i < 5-1; i++)
 //       {
 //          if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
 //           {
 //               cnt++;
 //               
 //           }
 //       }
 //        Console.WriteLine(cnt);
 //

//7
//  int[] arr = new int[7];
//
//       for (int i = 0; i < 7; i++)
//       {
//           arr[i] = int.Parse(Console.ReadLine());
//       }
//
//           
//
//       for (int i =7-1; i > 0; i--)
//       {
//           if ((arr[i] > 0 && arr[i - 1] > 0) || (arr[i] < 0 && arr[i - 1] < 0))
//           {
//                Console.WriteLine(arr[i - 1] + " " + arr[i]);
//                break;
//               
//           }
//       }
//

//8      
//  int[] arr = new int[6];
//
//     
//        for (int i = 0; i < 6; i++)
//       {
//           arr[i] = int.Parse(Console.ReadLine());
//       }
//
//           
//
//       for (int i = 0; i < 6; i++)
//       {
//          if (arr[i] % 2 != 0)
//   
//           {
//                 Console.Write(i + " ");
//               
//           }
//       }

 int[] arr = new int[6];

      for (int i = 0; i < 6; i++)
      {
          arr[i] = Convert.ToInt32(Console.ReadLine());
      }
 int a = Convert.ToInt32(Console.ReadLine());
 int b = Convert.ToInt32(Console.ReadLine());

  for (int i = a; i <= b; i++)
  {
    if (arr[i]%2!=0)
    {
        Console.Write(arr[i] + " ");
    }
  }





//10

//  int[] arr = new int[6];
//
//     
//        for (int i = 0; i < 6; i++)
//       {
//           arr[i] = int.Parse(Console.ReadLine());
//       }
//
//           
//
//       for (int i = 0; i < 6; i++)
//       {
//          if (arr[i] % 2 != 0)
//   
//           {
//                Console.Write(arr[i] * arr[i] + " ");
//               
//           }
//       }
//    
