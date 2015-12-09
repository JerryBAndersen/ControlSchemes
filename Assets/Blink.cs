using UnityEngine;
using System.Collections;

public class Blink : MonoBehaviour {

    public bool raycast = true;
    public GameObject representation;
    public float speed = .05f;

    void Start () {
        representation = Instantiate(representation);
	}
	
	void FixedUpdate () {

        representation.transform.position += speed *Input.GetAxis("Vertical") * representation.transform.forward;
        representation.transform.position += speed * Input.GetAxis("Horizontal") * representation.transform.right;
        //representation.transform.Rotate(Quaternion.LookRotation(representation.transform.position-transform.position, Vector3.up).eulerAngles);

        if (Input.GetButtonDown("Fire1")) {
            transform.position = representation.transform.position;
            transform.rotation = representation.transform.rotation;
            representation.transform.position += transform.forward*2f;
        }
	}
}
