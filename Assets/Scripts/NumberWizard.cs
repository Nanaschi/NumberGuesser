using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
    {
    [SerializeField] int minValue;
    [SerializeField] int maxValue;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }
    void StartGame()
    {

        NextGuess();
   
    }

    // Update is called once per frame

    void NextGuess()
    {
        guess = Random.Range(minValue, maxValue);
        
        guessText.text = guess.ToString();
    }
    public void OnPressHigher()
    {
        minValue = guess + 1;
        NextGuess();
     
    }
    public void OnPressLower()
    {
        maxValue = guess - 1;
        NextGuess();

    }
}
