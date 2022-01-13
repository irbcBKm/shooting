using UnityEngine;

public class CameraController : MonoBehaviour {
    [SerializeField]//インスペクターへの表示
    private Transform Camera_Point;
    [SerializeField]
    void Update()
    {
        this.transform.Translate(Camera_Point.position);
    }
    
}