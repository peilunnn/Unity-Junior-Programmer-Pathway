using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    private float sideBound = 30;
    private GameObject LivesAndScoreManager;

    // Start is called before the first frame update
    void Start()
    {
        LivesAndScoreManager = GameObject.Find("LivesAndScoreManager");
    }

    // Update is called once per frame
    void Update()
    {
        // IF ANIMAL GOES OUT OF BOUNDS, DESTROY ANIMAL
        if (transform.position.z > topBound || transform.position.z < lowerBound || transform.position.x > sideBound || transform.position.x < -sideBound)
        {
            Destroy(gameObject);

            // IF ANIMAL GETS PAST THE BOTTOM, DECREASE SCORE,  
            if (transform.position.z < lowerBound)
                LivesAndScoreManager.GetComponent<LivesAndScoreManager>().updateLives(-1);
        }
    }
}