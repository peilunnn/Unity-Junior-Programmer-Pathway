using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed = 5;
    private Rigidbody playerRb;
    private GameObject focalPoint;
    Rigidbody enemyRb;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // CHASING PLAYER
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(lookDirection * speed);

        // IF ENEMY GOES OUT OF BOUNDS, DESTROY IT
        if (transform.position.y < -10)
            Destroy(gameObject);
    }
}
