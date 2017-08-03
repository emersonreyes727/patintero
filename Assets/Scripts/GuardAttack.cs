using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class GuardAttack : MonoBehaviour {

	[SerializeField] private Transform target;
	private Animator anim;
	private float inRange = 2f;

	//
	void Awake () {
		Assert.IsNotNull (target);
	}

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (transform.position, target.position) <= inRange) {
			Debug.Log ("inRange");
		}
	}
}
