using UnityEngine;
using System.Collections;

public class BulletEx : MonoBehaviour {

    public GameObject Detonator;

    // 発射
    public void Shot(Vector3 force)
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(force, ForceMode.Impulse);
    }

    // 他のオブジェクトとぶつかったときの処理
    void OnCollisionEnter(Collision other)
    {
        GameObject detonator = Instantiate(Detonator, transform.position, Quaternion.identity) as GameObject;
        Destroy(gameObject);
    }
}
