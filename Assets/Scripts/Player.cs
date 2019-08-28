using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public int score;
    public int health;
    public int damage;

    //Access to the movement multi in playermovement
    public float speedMulti;
    private PlayerMovement movement;

    private byte powerup;

    public  bool isJuggenaut = false;
    [Space]
    public GameObject graphic;
    public MeshRenderer[] renderers;
    [Space]
    public AudioClip chickenNoise;
    public AudioClip boing;
    AudioSource audio;

    // Use this for initialization
    void Start () {
        audio = GetComponent<AudioSource>();
        score = 10;
        health = 10;
        damage = 1;
        speedMulti = 1f;
        movement = gameObject.GetComponent<PlayerMovement>();
        //isJuggenaut = false;
        renderers= graphic.GetComponentsInChildren<MeshRenderer>();

        InvokeRepeating("ChickenNoise", Random.Range(1f, 5f), Random.Range(25f , 60f));
	}

    void Update()
    {
        if(isJuggenaut)
        {
            if (!audio.isPlaying)
            {
                audio.clip = boing;
                audio.Play();
            }
        }


    }

    void FixedUpdate() {
        movement.speedMulti = speedMulti;
    }

    public int playerHealth {
        get { return health; }
    }

    public int playerScore {
        get { return score; }
    }

    public void takeDamage(int damage) {
        health -= damage;
    }

    public void IncreaseScore() {
        score++;
    }

    public void DecreaseScore()
    {
        score++;
    }

    public void setColor(Color color) {
        foreach (var item in renderers)
        {
            item.material.color = color;
        }
        
    }

    void ChickenNoise()
    {
        if(!audio.isPlaying)
        {
            audio.clip = chickenNoise;
            audio.Play();
        }
    }
	
}
