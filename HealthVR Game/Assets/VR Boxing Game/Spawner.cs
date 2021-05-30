using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] BoxingBags;
    public Transform[] points;
    public float spawntime = (60/130)*2;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer>spawntime)
        {
            GameObject BoxingBag = Instantiate(BoxingBags[Random.Range(0, 2)], points[Random.Range(0, 4)]);
            //BoxingBag.transform.localPosition = Vector3.zero;
            //BoxingBag.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
            timer -= spawntime;

        }

        timer += Time.deltaTime;


    }
}
