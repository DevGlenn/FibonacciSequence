using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Numerics;

public class Sequence : MonoBehaviour
{
    private string[] numbers; // make an array for all the numbers
    
    void Start()
    {
        PrintFibonacci(999); // print the whole sequence in the console
    }
    void PrintFibonacci(int maxNumb) // make a function for writing the sequence and give it a maxNumb int, this int simbolises the longest sequence number we want to display
    {
        numbers = new string[maxNumb]; //set the array Length to maxNumb
        BigInteger Fa = 0; // I used BigInteger, because otherwise at around 25 clicks it would go in the -
        BigInteger Fb = 1;
        BigInteger Fc;

        //print(Fa);
        //print(Fb);

        for (int i = 0; i < maxNumb; i++)
        {
            // make the actual sequence 
            Fc = Fa + Fb; // calculate Fc
            
            numbers[i] = Fc.ToString(); // replace the spots with the fc integer in the array, pretty taxing function
            print(Fc);
            Fa = Fb; 
            Fb = Fc;
        }
    }
    public string GetFc(int number)
    {
        return numbers[number]; // Return the matching string from the array
        
    }
}
