using UnityEngine;
using Unity.Netcode;

public class M_Bullet : NetworkBehaviour 
{
    public float Damage{get;} =20f;
    [SerializeField]
    private float speed;
    void Update()
    {
        this.transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    public override void OnNetworkSpawn()
    {
        GetComponent<Collider>().isTrigger = true;
        if (IsServer)
        {
            Invoke(nameof(Despawn),1f);
        }
    }
    #region Server Side
    private void OnTriggerEnter(Collider other)
    {
        if(!IsServer)return;
        Despawn();
    }
    private void Despawn()
    {
        if (IsServer)
        {
            NetworkObject.Despawn();
        }
    }
    #endregion
}