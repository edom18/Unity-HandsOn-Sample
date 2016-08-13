using UnityEngine;
using System.Collections;

public class CannonEx : MonoBehaviour {

    public GameObject Bullet;

	// Use this for initialization
	void Start () {
        //
	}
	
	// Update is called once per frame
	void Update () {
        // 左に移動
        if (Input.GetKey(KeyCode.LeftArrow)) {
            Vector3 position = transform.position;
            position.x -= 0.1f;
            transform.position = position;
        }
        // 右に移動
        if (Input.GetKey(KeyCode.RightArrow)) {
            Vector3 position = transform.position;
            position.x += 0.1f;
            transform.position = position;
        }

        // 上に回転
        if (Input.GetKey(KeyCode.UpArrow)) {
            Quaternion rotation = transform.rotation;
            rotation.x -= 0.01f;
            transform.rotation = rotation;
        }
        // 下に回転
        if (Input.GetKey(KeyCode.DownArrow)) {
            Quaternion rotation = transform.rotation;
            rotation.x += 0.01f;
            transform.rotation = rotation;
        }

        // 弾を発射
        if (Input.GetKeyDown(KeyCode.Space)) {
            Vector3 forward  = transform.forward;
            Vector3 position = transform.position + forward;
            GameObject bulletObj = Instantiate(Bullet, position, Quaternion.identity) as GameObject;
            BulletEx bullet      = bulletObj.GetComponent<BulletEx>();

            Vector3 force = forward * 10f;
            bullet.Shot(force);
        }
	}
}
