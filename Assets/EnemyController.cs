using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Transform player;
    Vector3 dir = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        float speed = 4;
        dir = Vector3.left; if (transform.position.x < -9f)
        {
            Vector3 pos = transform.position;
            pos.x = 9f;
            transform.position = pos;
        }
        dir.y = Mathf.Sin(Time.time * 5f);
        transform.position += dir.normalized * speed * Time.deltaTime;


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player") == true)
        {
            Destroy(gameObject);
            GameDirector.LastTime -= 15f;
        }
    }
}