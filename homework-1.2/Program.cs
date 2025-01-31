//1st task

//Console.WriteLine("Enter the number of digits for the mass:");
//int digitNumber = int.Parse(Console.ReadLine());
//int[] numbers = new int[digitNumber];
//int sum = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine("Enter the number:");
//    int userNumber = int.Parse(Console.ReadLine());
//    numbers[i] = userNumber;
//    sum += numbers[i];
//}

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (i < numbers.Length - 1)
//        Console.Write(numbers[i] + " + ");
//    else
//        Console.Write(numbers[i] + " = ");
//}
//Console.Write(sum);

//2nd task

//Console.WriteLine("Enter the number of digits for the mass:");
//int digitNumber = int.Parse(Console.ReadLine());
//int[] numbers = new int[digitNumber];
//int sum = 0;
//for (int i = 0; i < digitNumber; i++)
//{
//    Console.WriteLine("Enter the number:");
//    int userNumber = int.Parse(Console.ReadLine());
//    numbers[i] = userNumber;
//    sum += numbers[i];
//}
//double mean = sum / digitNumber;
//Console.WriteLine($"The mean of the numbers is {mean}");

//3rd task

//Console.Write("Enter the number of digits: ");
//int numberOfDigits = int.Parse(Console.ReadLine());
//int[] array = new int[numberOfDigits];

//for (int i = 0; i < numberOfDigits; i++)
//{
//    Console.Write("Enter the number: ");
//    int userNumber = int.Parse(Console.ReadLine());
//    array[i] = userNumber;
//}
//int countNumbers = 0;
//Console.Write("Enter the number to check: ");
//int userCheckNumber = int.Parse(Console.ReadLine());
//for (int j = 0; j < numberOfDigits; j++)
//{
//    if (array[j] == userCheckNumber)
//    {
//        countNumbers++;
//        break;
//    }
//}
//if (countNumbers > 0) Console.WriteLine("There's such number in the array.");
//else Console.WriteLine("There's no such number in the array.");

//4th task

//Console.Write("Enter the number of digits: ");
//int numberOfDigits = int.Parse(Console.ReadLine());
//int[] array = new int[numberOfDigits];
//int min, max;
//Console.Write("Enter the number: ");
//array[0] = int.Parse(Console.ReadLine());
//min = max = array[0];
//for (int i = 1; i < numberOfDigits; i++)
//{
//    Console.Write("Enter the number: ");
//    array[i] = int.Parse(Console.ReadLine());
//    if (array[i] > max)
//    {
//        max = array[i];
//    }
//    if (array[i] < min)
//    {
//        min = array[i];
//    }
//}
//Console.WriteLine($"The maximum is {max} and the minimum is {min}");

//5th task

//Console.Write("Enter the number of digits: ");
//int numberOfDigits = int.Parse(Console.ReadLine());
//int[] array = new int[numberOfDigits];
//int sum = 0;
//int even = 0;
//for (int i = 0; i < numberOfDigits; i++)
//{
//    Console.Write("Enter the number: ");
//    int userNumber = int.Parse(Console.ReadLine());
//    array[i] = userNumber;
//    if (array[i] % 2 == 0)
//    {
//        even = array[i];
//        sum += array[i];
//    }
//}
//Console.WriteLine($"Sum of the even numbers is {sum}");

//6th task 

//Console.Write("Enter the number of digits: ");
//int numberOfDigits = int.Parse(Console.ReadLine());
//int[] array = new int[numberOfDigits];
//for (int i = 0; i < numberOfDigits; i++)
//{
//    Console.Write("Enter the number: ");
//    int userNumber = int.Parse(Console.ReadLine());
//    array[i] = userNumber;
//}
//for (int i = numberOfDigits - 1; i >= 0; i--)
//{
//    Console.Write(array[i] + " ");
//}

//7th task

//Console.Write("Enter the number of digits: ");
//int numberOfDigits = int.Parse(Console.ReadLine());
//int[] array = new int[numberOfDigits];
//Console.Write("Enter the number: ");
//array[0] = int.Parse(Console.ReadLine());
//int max = array[0], indexOfMax = 0;
//int min = array[0], indexOfMin = 0;
//for (int i = 1; i < numberOfDigits; i++)
//{
//    Console.Write("Enter the number: ");
//    int userNumber = int.Parse(Console.ReadLine());
//    array[i] = userNumber;

//    if (array[i] >= max)
//    {
//        indexOfMax = i;
//        max = array[i];
//    }
//    if (array[i] <= min)
//    {
//        indexOfMin = i;
//        min = array[i];
//    }
//}
//Console.Write($"The maximums are {max}");
//int max2 = array[0];
//if (max2 == max) max2 = array[1];
//for (int i = 1; i < numberOfDigits; i++)
//{
//    if (array[i] != max && array[i] > max2)
//    {
//        max2 = array[i];
//    }
//}
//Console.Write($" and {max2}");

//8th task

//Console.Write("Enter the number of digits: ");
//int numberOfDigits = int.Parse(Console.ReadLine());
//int[] array = new int[numberOfDigits];
//int[] newArray = new int[numberOfDigits];
//for (int i = 0; i < numberOfDigits; i++)
//{
//    Console.Write("Enter the number: ");
//    int userNumber = int.Parse(Console.ReadLine());
//    array[i] = userNumber;
//    newArray[i] = array[i] * 2;
//}

//for (int i = 0; i < numberOfDigits; i++)
//{
//    Console.Write(newArray[i] + " ");
//}

//9th task

//Console.Write("Enter the birthday,month and year: ");
//string[] birthDate = Console.ReadLine().Split();
//int userBirthDay = int.Parse(birthDate[0]);
//int userBirthMonth = int.Parse(birthDate[1]);
//int userBirthYear = int.Parse(birthDate[2]);
//Console.Write("Enter the current day,month and year: ");
//string[] current = Console.ReadLine().Split();
//int userCurrentDay = int.Parse(current[0]);
//int userCurrentMonth = int.Parse(current[1]);
//int userCurrentYear = int.Parse(current[2]);
//int userAge = userCurrentYear - userBirthYear;
//if (userAge < 0 || userBirthMonth > 12 || userBirthDay > 31)
//{
//    Console.WriteLine("Invalid data.");
//}
//else if (userBirthMonth <= 12 && userBirthDay <= 31)
//{
//    if (userCurrentMonth >= userBirthMonth && userCurrentDay >= userBirthDay)
//        Console.WriteLine($"You are {userAge} year(s) old.");
//    else if (userCurrentMonth < userBirthMonth || userCurrentDay < userBirthDay)
//        Console.WriteLine($"You are {userAge - 1} year(s) old.");
//}

//10th task

//double km = 0.001;
//short M = 1;
//short mm = 1000;
//short s = 100;
//short dm = 10;
//Console.WriteLine("Enter the number for convertation:");
//double number = double.Parse(Console.ReadLine());
//Console.WriteLine("Enter the dimension from which you  want to convert to: ");
//string userDimensionFrom = Console.ReadLine();
//Console.WriteLine("Enter the dimension to which you  want to convert from: ");
//string userDimensionTo = Console.ReadLine();

//switch (userDimensionFrom)
//{
//    case "km":
//        number /= km;
//        break;
//    case "M":
//        number /= M;
//        break;
//    case "d":
//        number /= dm;
//        break;
//    case "m":
//        number /= mm;
//        break;
//    case "s":
//        number /= s;
//        break;
//}

//switch (userDimensionTo)
//{
//    case "km":
//        number *= km;
//        Console.WriteLine(number);
//        break;
//    case "M":
//        number *= M;
//        Console.WriteLine(number);
//        break;
//    case "d":
//        number *= dm;
//        Console.WriteLine(number);
//        break;
//    case "m":
//        number *= mm;
//        Console.WriteLine(number);
//        break;
//    case "s":
//        number *= s;
//        Console.WriteLine(number);
//        break;
//}
