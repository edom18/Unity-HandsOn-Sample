using UnityEngine;
using System.Collections;

public class BulletEx : MonoBehaviour {

    public void Shot(Vector3 force)
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(force, ForceMode.Impulse);
    }
}
