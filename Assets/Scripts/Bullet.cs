using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var rigidbody = GetComponent<Rigidbody>();
        Vector3 force = new Vector3(0f, 5f, 10f);
        rigidbody.AddForce(force, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
