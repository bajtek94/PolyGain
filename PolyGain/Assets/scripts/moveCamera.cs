using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public float speed = 0.02F;
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved) {
			Vector3 moves = Input.GetTouch (0).deltaPosition * speed;
			//transform.Translate (-moves.x * speed, -moves.y * speed, 0);
			transform.Translate(-moves);
		}
	}
}
