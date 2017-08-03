using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Assertions;

public class GuardWalk : MonoBehaviour {

	[SerializeField] private Transform target;
	private NavMeshAgent nav;

	//
	void Awake () {
		Assert.IsNotNull (target);
	}

	//
	void Start () {
		nav = GetComponent<NavMeshAgent> ();
	}
	
	// 
	void Update () {
		if (GameManager.instance.GameStart == true) {
			// random speed from .5 to 1, for levels 1 and 2
			float randomSpeed = Random.Range (0.5f, 1f);
			Debug.Log (randomSpeed);
			nav.speed = randomSpeed;
		}

		if (GameManager.instance.LevelTwoComplete == true) {
			// random speed from .8 to 1.5, for levels 3 and 4
			float randomSpeed = Random.Range (.8f, 1.5f);
			Debug.Log (randomSpeed);
			nav.speed = randomSpeed;
		}

		if (GameManager.instance.LevelFourComplete == true) {
			// random speed from 1.3 to 2, for levels 5 and 6
			float randomSpeed = Random.Range (1.3f, 2f);
			Debug.Log (randomSpeed);
			nav.speed = randomSpeed;
		}

		if (GameManager.instance.LevelSixComplete == true) {
			// random speed from 1.8 to 2.5, for levels 7 and 8
			float randomSpeed = Random.Range (1.8f, 2.5f);
			Debug.Log (randomSpeed);
			nav.speed = randomSpeed;
		}

		if (GameManager.instance.LevelEightComplete == true) {
			// random speed from 2.2 to 2.7, for levels 9 and 10
			float randomSpeed = Random.Range (2.2f, 2.7f);
			Debug.Log (randomSpeed);
			nav.speed = randomSpeed;
		}

		nav.SetDestination (target.position);
	}
}
