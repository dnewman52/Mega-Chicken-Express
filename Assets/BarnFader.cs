using UnityEngine;
using System.Collections;

public class BarnFader : MonoBehaviour {

    public int PlayerCount;
    public AnimationCurve curve;
    public MeshRenderer roof;

    float time = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerCount > 0)
        {
            time += Time.deltaTime;
            if (time > curve.keys[curve.keys.Length-1].time)
            {
                time = curve.keys[curve.keys.Length - 1].time;
            }
        }
        else {
            time -= Time.deltaTime;
            if (time < 0) {
                time = 0;
            }
        }

        roof.material.color = new Color(roof.material.color.r, roof.material.color.g, roof.material.color.b, curve.Evaluate(time));
	}

    void OnTriggerEnter(Collider other)    {
        if (other.tag == "Player") {
            PlayerCount++;
            
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerCount--;
        }
    }
}
