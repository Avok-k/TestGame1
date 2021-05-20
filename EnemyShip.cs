using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//　敵の移動：真下に移動する
//　敵を生成：精製工場の作成
//　敵とPlayerが接触したら爆発
//　-----------
//　敵を左右に振る
//　スコア表示
//　敵を倒したときにスコアを上昇させる
//　リスタートの実装
public class EnemyShip : MonoBehaviour
{
    public GameObject explosion; // 破壊のプレファブ

    // GameControllerの入れ物作成：AddScoreを使いたいから
    GameController gameController; 
    void Start()
    {
        //　GameObject.Find("GameController")
        //　・ヒエラルキー上のGameControllerという名前のプロジェクトを取得
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }
        
    void Update()
    {
        transform.position -= new Vector3(0,Time.deltaTime,0);
    }

    //　敵に弾が当たったら爆発
    //　当たり判定の基礎知識：
    //　当たり判定を行うには、
    //　・両者にColliderがついている
    //　・少なくともどちらかにRigidbodyがついている


    //　isTriggerにCheckをつけた場合は、此方が実行される
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // collisionにぶつかった相手の情報が入っている：bullet
        if (collision.CompareTag("Player") == true) 
        {
            Instantiate(explosion, collision.transform.position, transform.rotation);
            gameController.GameOver();
        }
        else if(collision.CompareTag("Bullet") ==  true)
        {
            gameController.AddScore();
        }
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(collision.gameObject);
    }
    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
    }
    */
}
