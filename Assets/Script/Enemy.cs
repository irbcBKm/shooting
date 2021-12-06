using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // Start is called before the first frame update
   public float EnemyHP;
    void Start()
    {
        EnemyHP = 100;
    }
    // Update is called once per frame
    void Update()
    {
        if (EnemyHP <= 0)
        {
            //Destroy(gameObject);            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("弾が敵に衝突");
            Destroy(collision.gameObject);
            EnemyHP -= 10;
        }
    }
}
