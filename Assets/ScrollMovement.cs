using UnityEngine;
using System.Collections;

public class ScrollMovement : MonoBehaviour {
    public float speed = -0.5f;
    public float extraSpeed= 0.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void FixedUpdate() {
        speed = ScrollManager.ScrollSpeed + extraSpeed;
        transform.position += speed*Time.deltaTime * Vector3.right;
    }
}
