using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMe : MonoBehaviour
{
    public float speed;
    private Vector3 mouse;
    private Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        /*mouse = Input.mousePosition;
        target = Camera.main.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y, 10));
        transform.LookAt(target);*/
        //左回転
        if (Input.GetKey (KeyCode.A)) 
        {
            transform.Rotate (0.0f,-2.0f,0.0f);
        }
        // 右回転
        if (Input.GetKey (KeyCode.D)) 
        {
            transform.Rotate (0.0f,2.0f,0.0f);
        }
        // 前進
        if (Input.GetKey (KeyCode.W)) 
        {
            this.transform.Translate (0.0f,0.0f,0.1f);
        }
        // 後退
        if (Input.GetKey (KeyCode.S)) 
        {
            this.transform.Translate (0.0f,0.0f,-0.1f);
        }
    }
}