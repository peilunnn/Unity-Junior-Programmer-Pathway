using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10;
    private float turnSpeed = 30;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed * Input.GetAxis("Vertical1"));
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * Input.GetAxis("Horizontal1"));
    }
}
