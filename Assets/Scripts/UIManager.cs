using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class UIManager : MonoBehaviour {

    public GameObject[] UITextFields;
    public GameObject[] UIDeathSkulls;
    private Player[] players;

    // Use this for initialization
    void Start()
    {
        players = GameObject.Find("Players").GetComponentsInChildren<Player>();
    }
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < players.Length; i++)
        {
            if (players[i]) {
                UITextFields[i].GetComponent<Text>().text = "" + players[i].score;
            }else{
                UIDeathSkulls[i].SetActive(true);
            }
        }
    }
}
