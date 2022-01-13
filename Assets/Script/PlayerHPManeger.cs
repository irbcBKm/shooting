using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerHPManeger : MonoBehaviour
{
    public Slider PlayerHPS;
    private float PlayerHP;
    // Start is called before the first frame update
    void Start()
    {
        PlayerHP = 100;
        PlayerHPS.value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("u"))
        {
            PlayerHP -= 20;//スライダーとgameover処理の確認用
        }
        if (PlayerHP <= 0)
        {
            Debug.Log("敗北");
            SceneManager.LoadScene("ResultSeen");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyBullet"))
        {
            Debug.Log("弾が自分に衝突");
            //Destroy(collision.gameObject);
            PlayerHP -= 10;
            PlayerHPS.value = PlayerHP/100;
        }
    }
}

