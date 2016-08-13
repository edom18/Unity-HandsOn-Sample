using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour {

    public GameObject Bullet;

	// Use this for initialization
	void Start () {
        //
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            Vector3 position = transform.position;
            position.x -= 0.1f;
            transform.position = position;
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            Vector3 position = transform.position;
            position.x += 0.1f;
            transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            Vector3 forward = transform.forward;
            Vector3 position = transform.position + forward;
            var bullet = Instantiate(Bullet, position, Quaternion.identity) as GameObject;
        }
	}
}
