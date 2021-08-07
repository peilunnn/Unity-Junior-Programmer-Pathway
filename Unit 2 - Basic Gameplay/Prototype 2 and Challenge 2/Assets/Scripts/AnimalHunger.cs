using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    public Slider hungerSlider;
    public int amtToBeFed;
    public int currentFedAmt = 0;
    private GameObject LivesAndScoreManager;

    // Start is called before the first frame update
    void Start()
    {
        hungerSlider.value = 0;
        hungerSlider.maxValue = amtToBeFed;
        hungerSlider.fillRect.gameObject.SetActive(false);
        LivesAndScoreManager = GameObject.Find("LivesAndScoreManager");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FeedAnimal(int foodAmt)
    {
        currentFedAmt += foodAmt;
        hungerSlider.fillRect.gameObject.SetActive(true);
        hungerSlider.value = currentFedAmt;


        if (currentFedAmt >= amtToBeFed)
        {
            LivesAndScoreManager.GetComponent<LivesAndScoreManager>().updateScore(1);
            Destroy(gameObject, 0.1f);
        }
    }
}
