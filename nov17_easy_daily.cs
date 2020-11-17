/*
Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
Bonus: Can you do this in one pass?
*/

using System;

public static void Main(String Args[]){
    Console.WriteLine("The numbers being added are [10, 15, 3, 7] and the integer is 17. True should be returned!")

    int arr[] = [10, 15, 3, 7];
    int numb = 17;
    equal(arr, numb);
}
public static boolean equal(int arr[], int numb){
    int sum;
    for(int i = 0; i <= arr.Length; i++){
        sum += arr[i];
    }
    if(sum == numb){
        return true;
    }
    else
    {
        return false
    }
}