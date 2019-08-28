using UnityEngine;
using System.Collections;

public class AddForce : MonoBehaviour {

    public GameObject[] doors;
    public int x, y, z;
    public float multi;

    // Update is called once per frame
    void OnTriggerEnter(Collider player) {
        if (player.tag == "Player") {
            doors[0].GetComponent<Rigidbody>().AddForce(new Vector3(x * multi, y * multi, z * multi));
            doors[1].GetComponent<Rigidbody>().AddForce(new Vector3(x * multi, y * multi, z * multi));
            Invoke("Destroy", 1f);
        }
        
    }

    void Destroy() {
        GameObject.Destroy(gameObject);
    }
}
