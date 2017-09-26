﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCamera : MonoBehaviour {

  private static GameObject main;

	// Use this for initialization
	void Awake () {
    main = gameObject;
	}
	
  public static void Show(){
    main.SetActive(true);
  }

  public static void Hide(){
    main.SetActive(false);
  }
}