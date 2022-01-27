using UnityEngine;
using Unity.Netcode;

public class M_Bullet : NetworkBehaviour 
{
    public float Damage{get;} =20f;
 
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

        if(!other.attachedRigidbody)return;

        var playerHealth = other.attachedRigidbody.GetComponent<PlayerHealthController>();
        if(playerHealth){
            playerHealth.TakeDamage(Damage);
        }
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