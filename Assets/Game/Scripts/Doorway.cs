﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doorway : MonoBehaviour {

	public string scene;

	public void NextScene () {
		if (scene == null || scene == "")
		{
			Debug.LogWarning ("No scene specified for doorway transition!");
		}
		else
		{
			SceneManager.LoadScene(scene);
		}

	}

}
