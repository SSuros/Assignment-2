using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseLifeBoss : MonoBehaviour
{
    public int livesRemaining;
    public void BossLoseLife()
    {
        livesRemaining--;
        if (livesRemaining == 0)
        {
            Object.Destroy(this.gameObject);
            return;
        }
        
    }
}
