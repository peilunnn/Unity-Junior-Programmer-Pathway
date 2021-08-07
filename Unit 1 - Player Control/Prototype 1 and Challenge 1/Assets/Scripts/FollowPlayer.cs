using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public bool isdriverViewPlayer1 = false;
    public bool isdriverViewPlayer2 = false;
    private Vector3 offsetTopView = new Vector3(0, 7, -10);
    public Vector3 offsetDriverView = new Vector3(0, 3, 4);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (player.name == "Player1")
        {
            if (Input.GetKeyDown(KeyCode.RightShift))
                isdriverViewPlayer1 = !isdriverViewPlayer1;
                transform.position = player.transform.position + (isdriverViewPlayer1 ? offsetDriverView : offsetTopView);
        }

        else
        {
            if (Input.GetKeyDown(KeyCode.C))
                isdriverViewPlayer2 = !isdriverViewPlayer2;
            transform.position = isdriverViewPlayer2 ? player.transform.position + offsetDriverView : player.transform.position + offsetTopView;
        }
    }
}
