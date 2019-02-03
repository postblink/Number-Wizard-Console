using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();   
    }


    void StartGame()
    {
        max = 500;
        min = 1;
        guess = 250;

        Debug.Log("Welcome to the number wizard game!");
        Debug.Log("Please think of a number for me to guess.");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number available is: " + min);
        Debug.Log("Tell me if your number is higher or lower than my guess of: " + guess);
        Debug.Log("The up arrow is higher than the number you were thinking of, the down arrow is lower, and pressing enter confirms a correct guess.");
        max = max + 1;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
             
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();  
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I nailed it! Your number was: " + guess);
            StartGame();
        }
    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than: " + guess);
    }
}
