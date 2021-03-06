using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;
    void Start()
    {
        // 繰り返し関数を実行する
        InvokeRepeating("Spawn", 2f, 0.5f); // Spawn関数を2秒後に0.5刻みで実行する
    }

    // 生成する
    void Spawn() 
    {
        // 生成する位置(x座標)をランダムにしたい
        Vector3 spawnPosition = new Vector3(
            Random.Range(-2.5f,2.5f),
            transform.position.y,
            transform.position.z
            );
        Instantiate(enemyPrefab,        // 生成するオブジェクト
                   spawnPosition,       // 生成の位置
                   transform.rotation); // 生成時の向き
    }
    void Update()
    {
        
    }
}
