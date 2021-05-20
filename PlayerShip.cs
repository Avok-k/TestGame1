using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//  PlayerShipを方向キーで動かす
// ・方向キーの入力を受け入れる
// ・Playerの位置を変更する
 
// 弾をうつ
// ・弾の作成
// ・弾道作成
// ・発射口作成
// ・ボタンを押したときに弾を生成
// ----------------//


 public class PlayerShip : MonoBehaviour
{
    public Transform firePoint; //弾を発射する位置
    public GameObject bulletPrefab;
    //　約0.02秒に一回実行される
    void Update()
    {
        Shot();
        Move();
    }
    void Shot() 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);

            GetComponent<AudioSource>().Play();

        }
    }
    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        // 課題：GetAxisRawとGetAxisの違いをDebug.Log(x)で調べる
        transform.position += new Vector3(x, y, 0) * Time.deltaTime * 4;

    }
}
