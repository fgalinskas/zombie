using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public static class myLoad {

	// Use this for initialization
	public static void Loading (string scene) {
		persistence.nextLevel = scene;
		SceneManager.LoadScene ("load");
	}
}
