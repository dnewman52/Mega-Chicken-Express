using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class UI_GameOver : MonoBehaviour
{

    public GameObject[] UITextFields;
    public GameObject[] crownLocations;

    public Sprite crown;

    private List<int> scores;

    // Use this for initialization
    void Start()
    {
        int prevScore = 0;
        int biggest;
        int index = 0;

        scores = GameObject.Find("GameManager").GetComponent<GameOver>().scores;

        foreach (int score in scores) {
            if (score > prevScore)
            {
                biggest = score;
                index = scores.IndexOf(score);
            }
            prevScore = score;
        }
        crownLocations[index].GetComponent<SpriteRenderer>().sprite = crown;

        UITextFields[0].GetComponent<Text>().text = "Player 1: " + scores[0];
        UITextFields[1].GetComponent<Text>().text = "Player 2: " + scores[1];
        UITextFields[2].GetComponent<Text>().text = "Player 3: " + scores[2];
        UITextFields[3].GetComponent<Text>().text = "Player 4: " + scores[3];
    }
}
