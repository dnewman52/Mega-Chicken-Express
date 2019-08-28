using UnityEngine;
using System.Collections;

public class TriggerDestroy : MonoBehaviour {

    private JugganautManager jug;

    void Start() {
        //GameObject that contains the players must be called "Players"
        jug = GameObject.Find("Players").GetComponent<JugganautManager>() ;
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player")
        {
            jug.players.Remove(coll.gameObject.GetComponent<Player>());
            Destroy(coll.gameObject);
        }
        else if (coll.tag!="Boundry") {
            Destroy(coll.gameObject, 2f);
        }

    }
}
