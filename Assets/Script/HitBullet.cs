using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       /* if(collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }*/
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("弾が敵に衝突");
            Destroy(collision.gameObject);
        }
    }
}
