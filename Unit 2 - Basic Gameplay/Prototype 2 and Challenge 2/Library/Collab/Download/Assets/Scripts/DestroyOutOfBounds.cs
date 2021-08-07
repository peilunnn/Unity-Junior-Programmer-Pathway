using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    private float sideBound = 30;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound || transform.position.z < lowerBound || transform.position.x > sideBound || transform.position.x < -sideBound)
        {
            Destroy(gameObject);
            if (transform.position.z > topBound)
                return;
            Debug.Log("Game Over!");
        }
    }
}