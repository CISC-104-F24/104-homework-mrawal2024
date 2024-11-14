using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardFunctions : MonoBehaviour
{
    public int rank = 1;
    public Color backgroundColor = Color.white;
    public TextMeshProUGUI rankDisplayUpperLeft;
    public TextMeshProUGUI rankDisplayLowerRight;
    public Image cardBackground;
    public Color textcolor = Color.red;
    public void UpdateCardVisuals()
    {
        // Update rank
        rankDisplayUpperLeft.text = rank.ToString();
        rankDisplayLowerRight.text = rank.ToString();

        // Change background color
        cardBackground.color = backgroundColor;
    }

    public void ChangeTextColor()
    {
        // Generate a random color
        Color randomColor = new Color(Random.value, Random.value, Random.value);
    }

    // Change card background color randomly
    public void ChangeBackgroundColor()
    {
        backgroundColor = new Color(Random.value, Random.value, Random.value);
        UpdateCardVisuals();
    }

    // Randomize rank
    public void RandomizeRank()
    {
        rank = Random.Range(1, 14); // Standard rank from 1 to 13
        UpdateCardVisuals();
    }
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B)) ChangeBackgroundColor();
        if (Input.GetKeyDown(KeyCode.R)) RandomizeRank();
        if (Input.GetKeyDown(KeyCode.T)) ChangeTextColor();
    }
}
