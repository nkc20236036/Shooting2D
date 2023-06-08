using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    Vector3 dir = Vector3.zero;
    float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,4f);
    }

    // Update is called once per frame
    void Update()
    {
        dir = Vector3.left;
        transform.position += dir.normalized * speed * Time.deltaTime;
        

    }
    private void OnTriggerEnter2D (Collider2D collision)
    {
        GameDirector.LastTime -= 10f;

        Destroy(gameObject);
    }
}
