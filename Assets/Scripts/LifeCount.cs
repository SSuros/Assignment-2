using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeCount : MonoBehaviour
{
    public Image[] lives;
    public int livesRemaining;

    public void LoseLife()
    {
        livesRemaining--;
        if (livesRemaining == 0)
        {
            SceneManager.LoadScene("GameEnd");
            return;
        }
        lives[livesRemaining].enabled = false;
    }
}
