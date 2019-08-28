using UnityEngine;
using System.Collections;

public class SpeedUp : Trigger {

    protected override void ApplyEffect(Player player) {
        player.speedMulti = 2f;
    }

    protected override void RevertEffect(Player player)
    {
        player.speedMulti = 1f;
    }
}
