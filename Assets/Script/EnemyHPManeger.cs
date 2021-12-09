using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHPManeger : MonoBehaviour
{
    public GameObject Enemy;
    public Slider sliderHP;
    private float EnemyHP;
        // Start is called before the first frame update
    void Start()
    {
        EnemyHP = 100;
        sliderHP.value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(EnemyHP <= 0)
        {
            Destroy(Enemy);
            Debug.Log("敵が倒れた");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("弾が敵に衝突");
            Destroy(collision.gameObject);
            EnemyHP -= 10;
            sliderHP.value = EnemyHP/100;
        }
    }
}
