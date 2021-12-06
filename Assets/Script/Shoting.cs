using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoting : MonoBehaviour
{
    public GameObject shot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(shot,transform.position,transform.rotation);
        }
    }
}
