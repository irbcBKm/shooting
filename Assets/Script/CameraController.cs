using UnityEngine;

public class CameraController : MonoBehaviour{
    public Transform TargetTf { get; set; }

        public Vector3 Offset;

        private void Update() {

            if (!TargetTf) return;

            // TargetからOffsetで設定した位置に移動する
            // Quaternion * Vector3 でベクトルの回転
            transform.position = TargetTf.position + TargetTf.rotation * Offset;

            // カメラをTargetに向ける
            transform.LookAt(TargetTf);
        }
}