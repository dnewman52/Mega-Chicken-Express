using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class JugganautManager : MonoBehaviour {

    public List<Player> players;
    public Player Jugganaught;
    public float multi= 2f;
    public Color juggernautColor = Color.green;
    public float avg;
    public AnimationCurve curve;

	// Use this for initialization
	void Start () {
        Player[] p = gameObject.GetComponentsInChildren<Player>();
        for (int i = 0; i < 4; i++) {
            players.Add(p[i]);
        }
        
        curve = new AnimationCurve(new Keyframe(0.8f, 1), new Keyframe(2, 3f));
    }

    // Update is called once per frame
    void Update()
    {
        avg = GetAverage();
        float time = 0;

        foreach (Player player in players)
            {
                if (!player) {
                    continue;
                }  
                if (player == Jugganaught)
                {
                player.transform.localScale = Vector3.one;
                    if (player.playerScore < avg * multi)
                    {
                        Jugganaught = null;
                        player.isJuggenaut = false;
                        player.setColor(Color.white);
                    }
                }
                if (player != Jugganaught)
                {
                    time = (player.playerScore / avg);
                    
                    float scale = curve.Evaluate(time);

                    player.transform.localScale = new Vector3(scale, scale, scale);
                    
                    if (!Jugganaught && player.playerScore >= avg * multi)
                    {
                        player.isJuggenaut = true;

                        //set the player color
                        player.setColor(juggernautColor);
                        Jugganaught = player;
                        break;
                    }
                }
        }
    }

    private float GetAverage() {
        float avg = 0;
        int count = 0;
        foreach (Player player in players)
        {
            if (player) { 
            avg += player.playerScore;
            count++;
            }
        
        }
        avg /= count;
        //print("Average: " + avg);
        return avg;
    }
}
