using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    Vector3 dir = Vector3.zero;
    GameObject ShotPre;
    float timer;
    int power = 0;
    Animator anim;
    float speed;
    

    // Start is called before the first frame update
    void Start()
    {
        
        anim = GetComponent<Animator>();
        ShotPre = (GameObject)Resources.Load("bulletPre");
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 10;
        Vector3 dir = Vector3.zero;
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");

        transform.position += dir.normalized * speed * Time.deltaTime;
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -9f, 9f);
        pos.y = Mathf.Clamp(pos.y, -5f, 5f);
        transform.position = pos;

        
        
            timer = 0;

            if (dir.y == 0)
            {
                anim.Play("Player");
            }
            else if (dir.y == 1)
            {
                anim.Play("Player L");
            }
            else if (dir.y == -1)
            {
                anim.Play("PlayerR");
            }
        if (Input.GetKeyDown(KeyCode.G))
        {
            power = (power + 1) % 18;
        }
        timer += Time.deltaTime;
            if (Input.GetKey(KeyCode.Z) && timer > 0.3f)
            {


                for (int i = -power; i < power + 1; i++)
                {
                    Vector3 po = transform.position + new Vector3(0, 0.5f, 0);

                    Vector3 r = transform.rotation.eulerAngles + new Vector3(0, 15f * i, 0);
                    Quaternion rot = Quaternion.Euler(r);


                    Instantiate(ShotPre, pos, rot);
                }
                timer = 0;
            }
        }
    }
