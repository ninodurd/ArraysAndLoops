// See https://aka.ms/new-console-template for more information
//დაწერეთ პროგრამა რომელიც კლავიატურიდან შემოიტანს n-ს და მასივს შეავსებს n-ცალი რიცხვით. დაითვალეთ:
//კენტი რიცხვების ჯამი
//ლუწი რიცხვების ნამრავლი
//დაითვლის მასივში თითოეული ელემენტი რამდენჯერ გვხვდება  (3)

using System.Drawing;
using System.Security.Cryptography;

int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
int[] arrayDublicated = new int[n];
int evenSum = 0, oddSum = 0, count = 1;
for (int i = 0; i < n; i++)
{
    int rn = RandomNumberGenerator.GetInt32(1,n);
    array[i] = rn;
    Console.WriteLine($"array {array[i]}");
    if (array[i] % 2 == 0) {
        evenSum += array[i];
    } else {
        oddSum += array[i];
    }
}
foreach (int i in array) { 
int counter = array.Count(x => x == i);
Console.WriteLine($" number: {i} is in array - {counter} times");
}
Console.WriteLine($"Even Sum{evenSum} Odd Sum{oddSum}");

//დაწერეთ პროგრამა რომელიც შეადარებს ორ მასივს და იტყვის
//არის თუ არა ეს ორი მასივი ტოლი.
/*int n = int.Parse(Console.ReadLine());
int[] firstArray = new int[n];
int[] secondArray = new int[n];
bool isEqual = false;
for (int i = 0; i < n; i++) {
    Console.WriteLine("Enter First Array Elements:");
    firstArray[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Enter Second Array Elements:");
    secondArray[i] = int.Parse(Console.ReadLine());
}

for (int j = 0; j < n; j++) {
    for (int k = 0; k < n; k++)
    {
        if (firstArray[j] == secondArray[k])
        {
            isEqual = true;
            break;
        }
    }
    if (!isEqual) break;
}
Console.WriteLine($"Is this two arrays Equal? - {isEqual}");*/
//დაწერეთ პროგრამა რომელიც მასივში დაბეჭდავს ერთმანეთის მეზობლად
//მდგარი ტოლი ელემენტების მაქსიმალურ რაოდენობას და ამ ელემენტს
/*int[] array ={ 1, 2, 2, 2, 2, 2, 3, 4, 5, 5, 5, 5, 5, 5, 6, 7 };
int number, nextNumber, count = 1, max = 0, maxDublicatedNumber = 0;
for (int i = 0; i < array.Length - 1; i++) {
    number = array[i];
    nextNumber = array[i + 1];
    if (number == nextNumber)
    {
        count++;
    }
    else if (count > max) {
        max = count;
        maxDublicatedNumber = number;
        count = 1;
    }
    else {
        count = 1;
    }

}
 Console.WriteLine($"Maximum : {max}  Maximum Dublicated Number Is {maxDublicatedNumber}"); */
//დაწერეთ პროგრამა რომელიც მასივში იპოვნის ყველაზე ხშირად
//გამეორებული ელემენტის რაოდენობას და დაბეჭდავს ამ ელემენტს.
/*int[] array = { 1, 2, 2, 2, 2, 2, 3, 4, 5, 5, 5, 6, 7 };
int number = 0,count = 0, max = 0;
for (int i = 0; i < array.Length; i++)
{
    foreach (int j in array) {
        if (j == array[i]) {
            count++;
        }
    }
    if (count > max) {
        max = count;
        number = array[i];
    }
    count = 0;
    
}
Console.WriteLine($"Maximum Dublicated Number Is {number}");*/