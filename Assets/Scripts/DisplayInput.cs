using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class DisplayInput : MonoBehaviour
{
    public Text textTemp;
    public InputField input;
    public Image heart;
    public GameObject completed;
    public GameObject gameOver;
    
    public static int globalNumber;
    private int inputNumber;
    private float maxChance = 0.7f;
    private float currentChance;
    // Start is called before the first frame update
    void Start()
    {
        textTemp.text = "";
        globalNumber = Random.Range(1,101);
        heart.fillAmount = 0.7f;
        currentChance = maxChance;
        completed.SetActive(false);
        gameOver.SetActive(false);
    }


    public void Create()
    {
        //Debug.Log(globalNumber);
        textTemp.text = input.text;
        //PlayerPrefs.SetString("input_text", textTemp.text);
        //PlayerPrefs.Save();
        //inputNumber = int.Parse(input.text);
        if (int.TryParse(input.text, out inputNumber) == false) 
        {
            textTemp.text = "ERROR";
            textTemp.color = Color.gray;
        } 
        else 
        {
            //Debug.Log(inputNumber);
            if (inputNumber<1 || inputNumber>100)
            {
                textTemp.text = "ERROR";
                textTemp.color = Color.gray;
            }
            else if (inputNumber == globalNumber) 
            {
                textTemp.text = "CORRECT";
                textTemp.color = Color.green;
                Invoke("DisplayCompleted",2f);
            }
            else if (inputNumber < globalNumber)
            {
                textTemp.text = "GREATER";
                textTemp.color = Color.red;
                LostChance();
            }
            else if (inputNumber > globalNumber)
            {
                textTemp.text = "LOWER";
                textTemp.color = Color.yellow;
                LostChance();
            }

            if (currentChance <= 0f) 
            {
                Invoke("DisplayGameOver",2f);
            }
        }
    }

    private void LostChance()
    {
        currentChance -= 0.1f;
        heart.fillAmount = currentChance;
    }

    private void DisplayCompleted()
    {
        completed.SetActive(true);
    }

    private void DisplayGameOver()
    {
        gameOver.SetActive(true);
    }
}
