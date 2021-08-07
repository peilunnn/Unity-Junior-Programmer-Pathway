using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public Material material;

    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;

        material = Renderer.material;

        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
        StartCoroutine(ChangeColor());
    }

    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
    }

    IEnumerator ChangeColor()
    {
        while (true)
        {
            material.color = Color.Lerp(UnityEngine.Random.ColorHSV(), UnityEngine.Random.ColorHSV(), Mathf.PingPong(Time.time, 1));
            yield return new WaitForSeconds(0.6f);
        }
    }
}
