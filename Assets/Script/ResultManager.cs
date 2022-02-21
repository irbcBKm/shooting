using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Netcode;
public class ResultManager : MonoBehaviour
{
    public int result = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void lose()
    {
        result = 1;
    }
    public void draw()
    {
        result = 2;
    }
}
