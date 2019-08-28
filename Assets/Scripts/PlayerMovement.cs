using UnityEngine;
using System.Collections;
using UnityEngine.InputNew;
public class PlayerMovement : MonoBehaviour {

    public PlayerInput playerInput;
    
    private ChickenInput_Xbox controlls;
    [Space]
    public Vector2 speed=Vector2.one*5;
    public float speedMulti = 1f;
    public float vCap = 5f;
    // Use this for initialization
    void Start () {
        
    }

    public void Assign(string name) {
        
        this.enabled = true;
        foreach (ActionMapSlot actionMapSlot in playerInput.actionMaps)
        {
            ActionMapInput actionMapInput = ActionMapInput.Create(actionMapSlot.actionMap);
            actionMapInput.TryInitializeWithDevices(playerInput.handle.GetApplicableDevices());
            actionMapInput.active = actionMapSlot.active;
            actionMapInput.blockSubsequent = actionMapSlot.blockSubsequent;
            playerInput.handle.maps.Add(actionMapInput);
            
        }
        controlls = playerInput.GetActions<ChickenInput_Xbox>();
        this.name += "(" + name + ")";
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (controlls==null) {
            return;
        }
        Rigidbody r = GetComponent<Rigidbody>();
        r.AddForce(((Vector3)Vector2.Scale(controlls.movement.vector2,speed))*speedMulti,ForceMode.Acceleration);
        if (r.velocity.magnitude > vCap*speedMulti) {
            r.velocity = r.velocity.normalized * vCap * speedMulti;
        }
	}
}
