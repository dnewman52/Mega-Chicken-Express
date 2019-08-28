using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    public List<int> scores;

    private bool gameRunning;
    private GameObject playerParent;
    private Player[] players;

	// Use this for initialization
	void Start () {
        gameRunning = true;
        playerParent = GameObject.Find("Players");
        players = playerParent.GetComponentsInChildren<Player>();
        GameObject.DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (gameRunning)
        {
            if (playerParent.transform.childCount <= 0)
            {
                storeScores();
                gameRunning = false;
                SceneManager.LoadScene("UI_Test");
            }
        }
	}

    void storeScores() {
        foreach (Player player in players) {
            scores.Add(player.score);
        }
    }
}
