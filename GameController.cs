using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//　スコアの実装
//　・UIの作成
//　・UIの更新
//　・敵と弾が接触したときにスコア加算+更新
//　・Playerと弾の差別化：Tag
//

//　ゲームオーバーの実装
//　・UIを作成
//　・敵とPlayerがぶつかったときにUIを表示
//　・リトライの実装
//　・Spaceを押したらシーンを再読み込み

//　19May
//　・音
//　・敵の動き
//　・Playerの移動範囲制限
//　・弾と敵の表示範囲
public class GameController : MonoBehaviour
{
    public GameObject gameOverText;

    public Text scoreText;
    int score = 0;
    void Start()
    {
        gameOverText.SetActive(false);
        scoreText.text = "Score:" + score;
    }

    private void Update()
    {
        if (gameOverText.activeSelf == true) 
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Main");
            }

        }


    }
    // スコア加算
    public void AddScore() 
    {
        score += 100;
        scoreText.text = "Score:" + score;
    }

    public void GameOver() 
    {
        gameOverText.SetActive(true);
    }

}
