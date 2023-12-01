using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChanceAmount : MonoBehaviour
{
    public Image heart;
    private float maxChance = 0.7f;
    private float currentChance;
    // Start is called before the first frame update
    void Start()
    {
        heart.fillAmount = 0.7f;
        currentChance = maxChance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LostChance()
    {
        currentChance -= 0.1f;
        heart.fillAmount = currentChance;
    }
}
