using UnityEngine;
using System.Collections;

public class SheepBehaviour : MonoBehaviour {

    /*Sheep behaviour, the sheep will move around the map in a random fashion
     * jumping periodically. Making bleating sounds as it jumps
     */
    //public float xMin, xMax, zMin, zMax;
    public float speed = 50f;
    Rigidbody rig;
    Vector3 moveVector;

    // Use this for initialization
    void Awake () {
        rig = GetComponent<Rigidbody>();
	
	}

    // Update is called once per frame
    void Update()
    {


    }


    void FixedUpdate ()
    {
        moveVector = Random.insideUnitCircle * speed;
        moveVector.z = 0f;
        transform.Translate(moveVector * Time.deltaTime);
    }
}
