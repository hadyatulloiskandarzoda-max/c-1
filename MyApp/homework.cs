// 3
// int[] arr = new int[5];
//        for (int i = 0; i < 5; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }
//
//       
//        int max = arr[0];
//        int index = 0;
//        for (int i = 0; i < 5; i++)
//        {
//            if (arr[i] > max)
//            {
//                max = arr[i];
//                index = i;
//            }
//        }
//
//        Console.WriteLine(index);
    
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
