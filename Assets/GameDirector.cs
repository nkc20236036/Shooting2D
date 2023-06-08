using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{

  public  Text kyoriLabel;
    int kyori;

    public Image timeGauge;

  public static  float LastTime;
    // Start is called before the first frame update
    void Start()
    {
        kyori = 0;
        LastTime = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        kyori++;
        kyoriLabel.text = kyori.ToString("D6") + "km";

        LastTime -= Time.deltaTime;
        timeGauge.fillAmount = LastTime / 100f;

        if(LastTime < 0)
        {
            SceneManager.LoadScene("GameScene");
        }

       

    }
}
