using UnityEngine;
using System.Collections;

public class MegaChickenManager : MonoBehaviour {

    public GameObject normalGraphic;
    public GameObject megaGraphic;
    public float normalHeight=-0.9f;
    public float megaHeight = -1.6f;
    public float normalMass = 1f;
    public float megaMass = 4f;
    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update() {
        Rigidbody r = GetComponent<Rigidbody>();
        if (GetComponent<Player>().isJuggenaut) {
            r.mass = megaMass;
            r.AddTorque(new Vector2(r.velocity.y, -r.velocity.x));
            megaGraphic.SetActive(true);
            normalGraphic.SetActive(false);
            transform.position= new Vector3(transform.position.x, transform.position.y, megaHeight);
            r.constraints = RigidbodyConstraints.FreezePositionZ;
        }
        else{
            megaGraphic.SetActive(false);
            normalGraphic.SetActive(true);
            transform.eulerAngles = Vector3.zero;
            transform.position= new Vector3(transform.position.x, transform.position.y, normalHeight);
            r.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionZ;
            r.mass = normalMass;
        }

	}


}
