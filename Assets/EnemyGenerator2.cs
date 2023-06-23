using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator2 : MonoBehaviour
{
    public GameObject EnemyPre2; // 敵のプレハブを保存する変数
    float span = 1;             // 敵を出す間隔（秒）
    float delta = 0;            // 時間計算用変数

    void Update()
    {
        delta += Time.deltaTime; // 経過時間を計算

        // span秒毎に処理を行う
        if (delta > span)
        {
            delta = 0;  // 時間計算用変数を０にする
            span -= (span >= 0.5f) ? 0.01f : 0f;  // スパンを少しずつ短くする

            // 敵のプレハブをヒエラルキーに登場させる
            GameObject go = Instantiate(EnemyPre2);
            int py = Random.Range(-5, 6);
            go.transform.position = new Vector3(0, py, 10);
        }
    }
}
