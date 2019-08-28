using UnityEngine;
using System.Collections;
using UnityEngine.InputNew;
using System.Collections.Generic;

public class PlayerManager : MonoBehaviour {
    public PlayerInput playerInput;
    private JoinMap controlls;
    public PlayerInput[] players;
    public int joinedPlayers = 0;
    public Material[] colourpool;
    // Use this for initialization
    void Awake()
    {
       

    }

    void Start() {

        
       controlls = playerInput.GetActions<JoinMap>();
        for (int i = 0; i < players.Length; i++)
        {
            players[i].handle = PlayerHandleManager.GetNewPlayerHandle();
            foreach (var item in players[i].GetComponent<Player>().renderers)
            {
                item.material = colourpool[i];
            }
        }
       
       players[1].handle = PlayerHandleManager.GetNewPlayerHandle();
       players[2].handle = PlayerHandleManager.GetNewPlayerHandle();
       players[3].handle = PlayerHandleManager.GetNewPlayerHandle();
    }


    // Update is called once per frame
    void Update () {
        if (controlls.joinAction.wasJustPressed) {
            List<InputDevice> devices = playerInput.handle.GetActions(controlls.actionMap).GetCurrentlyUsedDevices();

            PlayerHandle handle = players[joinedPlayers].handle;

            string name="unassigned";
            foreach (var device in devices)
            {
                handle.AssignDevice(device, true);
                name=device.deviceName;
                print(name);
            }
            players[joinedPlayers].GetComponent<PlayerMovement>().Assign(name);
            joinedPlayers++;
        }
	}
}
