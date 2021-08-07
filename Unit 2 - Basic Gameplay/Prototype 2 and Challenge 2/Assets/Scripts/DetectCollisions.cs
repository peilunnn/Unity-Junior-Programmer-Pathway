using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameObject LivesAndScoreManager;

    // Start is called before the first frame update
    void Start()
    {
        LivesAndScoreManager = GameObject.Find("LivesAndScoreManager");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        // IF ANIMAL COLLIDES INTO PLAYER, DECREASE LIVES
        if (gameObject.tag == "Animal" && other.name == "Player")
        {
            LivesAndScoreManager.GetComponent<LivesAndScoreManager>().updateLives(-1);
            Destroy(gameObject);
        }

        // IF TWO ANIMALS COLLIDE, DESTROY BOTH
        else if (gameObject.tag == "Animal" && other.tag == "Animal")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

        // IF FOOD COLLIDES WITH ANIMAL, INCREASE SCORE
        else if (gameObject.tag == "Food" && other.tag == "Animal")
        {
            other.GetComponent<AnimalHunger>().FeedAnimal(1);
            Destroy(gameObject);
        }
    }
}
