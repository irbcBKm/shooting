using Unity.Netcode;
using UnityEngine;

namespace MyFirstMultiplay {

    public class PlayerMoveController : NetworkBehaviour {

        [SerializeField]
        private float m_moveSpeed = 10f;

        [SerializeField]
        private float m_rotateSpeed = 150f;

        private float m_angle;

        private Rigidbody m_rigidbody;
        
        private void Awake() {
            m_rigidbody = GetComponent<Rigidbody>();
        }

        private void FixedUpdate() {

            if (!IsOwner) return;  // ここからは所有者のみ実行(所有権がない場合もどる)

            var h = Input.GetAxis("Horizontal");
            var v = Input.GetAxis("Vertical");

            m_angle += h * m_rotateSpeed * Time.fixedDeltaTime;
            var movement = v * m_moveSpeed * Time.fixedDeltaTime * transform.forward;

            m_rigidbody.MoveRotation(Quaternion.Euler(0f, m_angle, 0f));
            m_rigidbody.MovePosition(m_rigidbody.position + movement);
        }
    }
}
