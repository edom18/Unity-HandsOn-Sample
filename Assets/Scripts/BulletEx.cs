using UnityEngine;
using System.Collections;

public class BulletEx : MonoBehaviour {

    public GameObject Detonator;

    public void Shot(Vector3 force)
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(force, ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision other)
    {
        GameObject detonator = Instantiate(Detonator, transform.position, Quaternion.identity) as GameObject;
        Destroy(gameObject);
    }
}
