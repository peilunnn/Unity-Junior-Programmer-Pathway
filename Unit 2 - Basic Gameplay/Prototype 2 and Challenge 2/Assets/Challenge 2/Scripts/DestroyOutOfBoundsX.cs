using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -40;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // IF CURRENT GAMEOBJECT IS DOG, DESTROY WHEN LEFT BOUND IS REACHED
        if (this.name == "Dog(Clone)")
        {
            if (transform.position.x < leftLimit)
                Destroy(gameObject);
        }

        // ELSE IF CURRENT GAMEOBJECT IS BALL, DESTROY WHEN BOTTOM BOUND IS REACHED
        else
        {
            if (transform.position.y < bottomLimit)
                Destroy(gameObject);
        }
    }
}
