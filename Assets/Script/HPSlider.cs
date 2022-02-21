using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;

public class HPSlider : MonoBehaviour
{
    //[SerializeField]
    //private ScriptableObject m_playerHelthController;
    [SerializeField]
    private Slider HelthSlider;
    public GameObject playerHealthBer;
  PlayerHealthController playerHealthController;
    // Start is called before the first frame update
    void Start()
    {
        HelthSlider.value = 100;

    }

    // Update is called once per frame
    void Update()
    {
        /*var HelthVer= GetComponent<PlayerHealthController>();
        HelthSlider.value = HelthVer.HealthNetVar.Value;*/
    }
}
