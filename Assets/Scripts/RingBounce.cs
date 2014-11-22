using UnityEngine;
using System.Collections;

public class RingBounce : MonoBehaviour {
	public float smoothTime = 0.3F;
	private Vector3 velocity = Vector3.zero;
	public Vector3 desiredPositions;

	// Use this for initialization
	void Start () {
		//gameObject.transform.position = desiredPositions.position;
	}
	
	void FixedUpdate() {
		transform.position = Vector3.SmoothDamp(transform.position, desiredPositions, ref velocity, smoothTime);
	}
}
