using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : Coin
{
    public override int Collect()
    {
        if (!IsServer)
        {
            Show(false);
            return 0;
        }

        if (alreadyCollected) return 0;

        alreadyCollected = true;

        return coinValue;
    }
}
