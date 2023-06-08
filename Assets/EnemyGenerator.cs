using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPre;
    float delta;
    float span;
    // Start is called before the first frame update
    void Start()
    {
        delta = 0;
        span = 1f;
    }

    // Update is called once per frame
    void Update()
    {

        delta += Time.deltaTime;




        if (delta > span)
        {
            GameObject go = Instantiate(enemyPre);
            float py = Random.Range(-6f, 7f);
            go.transform.position = new Vector3(10, py, 0);

            delta = 0;

            span -= (span >= 0.5f) ? 0.01f : 0f;
        }
    }
}