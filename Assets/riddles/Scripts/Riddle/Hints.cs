using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hints : MonoBehaviour{

    public Dictionary<int, string[]> riddlesForEachRoom;
    public static Hints instance;
    void Start(){
        if (!instance) instance = this;
        riddlesForEachRoom = new Dictionary<int, string[]>();
        riddlesForEachRoom.Add(1, new string[3]{
            "I'm a three-digit number, quite fine,I am a prime, that's a sign. My first digit is one, that's clear.The last one is the third multiple of three, Can you guess me if the middle number is neither negative nor positive. Guess me in your time?",
            "My last digit is the smallest odd composite number. First two digits combined give you the smallest 2 digit number. Guess me?",
            "I'm greater than the first 3 digit prime number by 8 units. Find me on."
         });//109
        riddlesForEachRoom.Add(2, new string[3]{
            "Subtract the sqaure of first prime number from the total number of deliveries per innings in an T20 match. Can you tell my value?",
            "There are two numbers between 1 to 10 (both inclusive) whose absolute difference is 6. And sum of squares of those two numbers is greater than 100. Find their sum of squares",
            "The sum of all my digits is equal to the whole cube of the sum of first 2 digits. And my first two digits are equal. Can you guess me?"});//116
        riddlesForEachRoom.Add(3, new string[3]{
            "I am 2 less than the total number of bones in an adult human body. What am i?",
            "8,11,14,17... Substract 11 from the sum of first 10 numbers of this series to obtain the answer",
            "I am the product of the atmoic mass number of Carbon and atmoic number of a green colored poisonous gas. Find me."});//204
        riddlesForEachRoom.Add(4, new string[3]{
            "I am the product of the atomic number of most abundant gas on earth and the atmoic mass number of the element at period 3 and group 15. Guess me?",
            "Start with 1, Add 3 to it, Multiply by 20, Add 12, Multiply by the first odd prime number and finally subtract 59. Did you find me?",
            "Sum of my digits is 10. And product of all digits is 14. If I am between 200 and 300, can you calculate me?"
        });//217
        riddlesForEachRoom.Add(5, new string[3]{
            "Imagine there is a ODI match between India and Pakistan. India balls and gives only 1 extra run of wide. After the completion of one innings, How many total number of times was the ball bowled",
            "I am xyz, where x = tan^2(c/3d), y = sin0, z = tan(c/4d), where c -> circumference of a circle and d-> diameter of that circle.",
            "Sehwag had scored a triple century against Pakistan, in 2004. The correct room no. is 8 runs less than his score in that match." //309
        });//301
        riddlesForEachRoom.Add(6, new string[3]{
            "I am triangle whose base is 79 units and height is third power of 2, Find my area to reach your next room no.",
            "3,14,39,84,155,?  Add 58 to the missing number in the sequence to get the answer",
            "In a set of equations : 2x + y = 418 and 2y - x = 316. Find the sum of both unknown variables."
        });//316
    }
}
