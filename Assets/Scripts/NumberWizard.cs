﻿using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int min = 1;
		int max = 1000;
	
		print ("Welcome to Nuber Wizard");
		print ("Pick a number in your head, but don't tell me!");
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
