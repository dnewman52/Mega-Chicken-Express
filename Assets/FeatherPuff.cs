using UnityEngine;
using System.Collections;

public class FeatherPuff : MonoBehaviour {

    public AudioClip chickenHurt;
    AudioSource audio; 
    public ParticleSystem p;

	// Use this for initialization
	void Start ()
    {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision other) {
        p.Play();
        audio.clip = chickenHurt;
        audio.Play();
    }
}
