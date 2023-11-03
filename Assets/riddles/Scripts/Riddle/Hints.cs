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
            "50,68,90,?,146. The ? is the room you should go.",
            "104,116,120,128. The odd one out will take you to your room.",
            "My last 2 digits are the exponents of two single digits with my first digit being the start of any counting. Guess me on."});//116
        riddlesForEachRoom.Add(3, new string[3]{
            "I am 3 digit number,First digit from left is first prime number,Last digit is double of first digit,Middle one  is neither positive nor negative. What am i?",
            "There is a pool where the number of flowers gets doubled every day. The pool was filled up by 22 day. Which day was the pool quarter filled(Answer is first two digit)?If you add the digit of my square root by itself, you will get me. Guess the digit(Answer is last digit)?",
            "102, ? , 306 , 408. The ? is the room to find."});//204
        riddlesForEachRoom.Add(4, new string[3]{
            "I am 3 digit number. First digit from left is first prime number.Last digit is 5 more than first digit.Middle one is the first natural number. Guess me out.",
            "My first two digits combined are thrice of the unit digit. If you remove one letter from my unit digit, you will get the word “even”. Guess me?",
            "The hundredth and one’s digit is the cube of 3 respectively. The middle number is one less than the hundredth digit."
        });//217
        riddlesForEachRoom.Add(5, new string[3]{
            "I am 3 digit number. First digit from left is first odd  prime number.Last digit is 2 less than First digit.Middle one is neither positive nor negative",
            "2,10,?,68. My first two digits are the missing number in the series while my last digit is the start of any counting. Guess me.",
            "I am a concept that marks a revolution in data storage, My units digit is the base of binary code, My second digit is false in binary, My hundreds digit is the first odd prime number. What number am I?"
        });//301
        riddlesForEachRoom.Add(6, new string[3]{
            "Remove 1 from my first digit and you will get a perfect cube. Combine my last 2 digits and you will get a perfect square. Guess me out.",
            "80,160,?,640. Remove 4 from the missing number to get your destination.",
            "I am a three-digit number, and my digits add up to 10. And by last digit is twice my first digit. I am greater than 300. What am I?"
        });//316
    }
}
