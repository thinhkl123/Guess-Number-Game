using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMenu : MonoBehaviour
{
    public GameObject completed;
    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        completed.SetActive(false);
        gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayCompleted()
    {
        completed.SetActive(true);
    }

    public void DisplayGameOver()
    {
        gameOver.SetActive(true);
    }
}
