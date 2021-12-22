using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMe : MonoBehaviour
{
    public float speed = 5;
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
        var moveT = Input.GetAxis("Vertical");
        var moveR = Input.GetAxis("Horizontal");

        transform.Translate(0f, 0f, moveT *Time.deltaTime* speed);
        transform.Rotate(0f, moveR, 0f);
    }
}