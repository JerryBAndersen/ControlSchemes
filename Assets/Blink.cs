using UnityEngine;
using System.Collections;

public class Blink : MonoBehaviour {

    public GameObject representation;
    public bool raycast = false;
    public GameObject pointer;
    public float speed = .2f;
    public float spawnDistance = 3.0f;

    void Start () {
        representation = Instantiate(representation);
	}
	
	void FixedUpdate () {
        if (!raycast)
        {
            representation.transform.position += speed * Input.GetAxis("Vertical") * (representation.transform.position - transform.position).normalized;
            representation.transform.position += speed * Input.GetAxis("Horizontal") * representation.transform.right;
            representation.transform.rotation = Quaternion.LookRotation(representation.transform.position - transform.position, Vector3.up);
            if (Input.GetButtonDown("Fire1"))
            {

                transform.position = representation.transform.position;
                transform.rotation = representation.transform.rotation;
                representation.transform.position += transform.forward * spawnDistance;
            }
        }
        else { 
            
        }

	}
}
