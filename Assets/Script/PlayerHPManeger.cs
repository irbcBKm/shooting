using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("弾が自分に衝突");
            Destroy(collision.gameObject);
            PlayerHP -= 10;
            PlayerHPS.value = PlayerHP/100;
            Debug.Log("HPバーとHPを同期");
        }
    }
}

