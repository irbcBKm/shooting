using Unity.Netcode;
using UnityEngine;

namespace MyFirstMultiplay {

    public class playerCamera : NetworkBehaviour {

        [SerializeField]
        private Vector3 m_offset;

        public override void OnNetworkSpawn() {

           if (!IsLocalPlayer) return;

            // Playerからカメラ操作コンポーネントに対して設定.
            var camController = Camera.main.GetComponent<CameraController>();

            camController.TargetTf = transform;
            camController.Offset = m_offset;
        }
    }
}
