using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;

	//
	private bool gameStart = false;
	private bool gameRestart = false;

	//
	private bool levelOneComplete = false;
	private bool levelTwoComplete = false;
	private bool levelThreeComplete = false;
	private bool levelFourComplete = false;
	private bool levelFiveComplete = false;
	private bool levelSixComplete = false;
	private bool levelSevenComplete = false;
	private bool levelEightComplete = false;
	private bool levelNineComplete = false;
	private bool levelTenComplete = false;

	//
	public bool GameStart {
		get { return gameStart; }
	}

	public bool GameRestart {
		get { return gameRestart; }
	}

	//
	public bool LevelOneComplete {
		get { return levelOneComplete; }
	}

	public bool LevelTwoComplete {
		get { return levelTwoComplete; }
	}

	public bool LevelThreeComplete {
		get { return levelThreeComplete; }
	}

	public bool LevelFourComplete {
		get { return levelFourComplete; }
	}

	public bool LevelFiveComplete {
		get { return levelFiveComplete; }
	}

	public bool LevelSixComplete {
		get { return levelSixComplete; }
	}

	public bool LevelSevenComplete {
		get { return levelSevenComplete; }
	}

	public bool LevelEightComplete {
		get { return levelEightComplete; }
	}

	public bool LevelNineComplete {
		get { return levelNineComplete; }
	}

	public bool LevelTenComplete {
		get { return levelTenComplete; }
	}

	//
	void Awake () {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
	}

	//
	public void PlayerStartGame () {
		gameStart = true;
	}

	public void PlayerReStartGame () {
		gameRestart = true;
	}
}
