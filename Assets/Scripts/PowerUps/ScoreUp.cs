using UnityEngine;
using System.Collections;
using System;

public class ScoreUp : Trigger {

    protected override void ApplyEffect(Player Player)
    {
        Player.IncreaseScore();
    }

    protected override void RevertEffect(Player Player)
    {
        //Not Necesary for this powerup
    }
}
