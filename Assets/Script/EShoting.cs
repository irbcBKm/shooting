using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EShoting : MonoBehaviour
{
    public GameObject Eshot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Invoke(nameof(Enemyshot), 2.0f);
    }
    void Enemyshot()
    {
        Instantiate(Eshot,transform.position,transform.rotation);
    }
}
