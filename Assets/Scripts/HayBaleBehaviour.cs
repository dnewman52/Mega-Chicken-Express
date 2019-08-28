using UnityEngine;
using System.Collections;

public class HayBaleBehaviour : MonoBehaviour {

    Vector2 moveVector;
    public float speed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        speed = -ScrollManager.ScrollSpeed;
	}

    void FixedUpdate()
    {
        moveVector = Vector2.left * speed * Time.deltaTime;
        transform.Translate(moveVector);

    }
}
