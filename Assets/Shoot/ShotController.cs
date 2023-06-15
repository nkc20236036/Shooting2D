using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    float speed = 8f;
    //Transform player;
    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.Find("Player").transform;

        //transform.position = player.position + new Vector3(0, 0.5f, 0);

        //transform.forward = player.forward;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        if (transform.position.magnitude > 70f)
        {
        //    transform.position = new Vector3(0, 0.5f, 0);
        //}
        //if (transform.position.magnitude > 70f)
        //{
            Destroy(gameObject);
        }
    }
}