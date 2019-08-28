using UnityEngine;
using System.Collections;

public class ScoreDown : Trigger {

    protected override void ApplyEffect(Player player)
    {
        player.DecreaseScore();
    }

    protected override void RevertEffect(Player player)
    {
        //None
    }
}
