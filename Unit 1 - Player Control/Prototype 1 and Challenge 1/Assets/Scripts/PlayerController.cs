using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    [SerializeField] private float turnSpeed = 30;

    public Dictionary<string, (string, string)> players = new Dictionary<string, (string, string)>
    {
        { "Player1", ("Horizontal1", "Vertical1") },
        { "Player2", ("Horizontal2", "Vertical2") }
    };

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed * Input.GetAxis(players[this.name].Item2));
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * Input.GetAxis(players[this.name].Item1));
    }
}
