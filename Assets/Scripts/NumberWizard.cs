using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int min;
    [SerializeField] int max;
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
    void Update()
    {
      
    }
    public void NextGuess()
    {
        guess = Random.Range(min, max);
        guessText.text = guess.ToString();
    }
    public void OnPressHigher()
    {
        min = guess + 1;
        if (min >= max)
        {
            min = max;
        }
        NextGuess();
    }
    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }
}
