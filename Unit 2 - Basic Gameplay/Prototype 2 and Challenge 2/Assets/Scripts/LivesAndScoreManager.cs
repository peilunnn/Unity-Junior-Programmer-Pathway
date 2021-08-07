using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesAndScoreManager : MonoBehaviour
{
    public int totalLives = 3;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void updateLives(int numLives)
    {
        totalLives += numLives;
        Debug.Log($"Current Lives:{totalLives}");

        if (totalLives == 0)
            Debug.Log("Game Over!");
    }

    public void updateScore(int numAnimalsFed)
    {
        score += numAnimalsFed;
        Debug.Log($"Current Score:{score}");
    }
}
