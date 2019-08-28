using UnityEngine;
using System.Collections;

public abstract class Trigger : MonoBehaviour {

    public float defaultDuration = 5f;
	
    //Apply the power up to the player and destroy the powerup gameObject (The player must ahve a ridgidbody to activate the trigger)
    void OnTriggerEnter(Collider p) {
        if (p.tag == "Player") {
            Player player = p.gameObject.GetComponent<Player>();
            StartCoroutine(PowerUp(player, defaultDuration));
        }
    }

    //Coroutine, allows duration of power up to be set.
    IEnumerator PowerUp(Player player , float duration) {
        Hide();
        print("powering up");
        ApplyEffect(player);
        yield return StartCoroutine(PowerDown(player, duration));
     
    }

    IEnumerator PowerDown(Player player, float duration) {
        yield return new WaitForSeconds(duration);
        //PowerDown
        print("Powering Down");
        RevertEffect(player);
        GameObject.Destroy(gameObject);
    }

    private void Hide() {
        MeshRenderer mesh =   gameObject.GetComponentInChildren<MeshRenderer>();
        SphereCollider collider = gameObject.GetComponent<SphereCollider>();
        mesh.enabled = false;
        collider.enabled = false;
    }

    protected abstract void ApplyEffect(Player Player);
    protected abstract void RevertEffect(Player Player);
}
