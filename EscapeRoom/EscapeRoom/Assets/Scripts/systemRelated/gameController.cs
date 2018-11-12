﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour {

    public bool princessKissed;
    public bool fireStone_Obtained;
    public bool woodStone_Obtained;
    public bool lit_room;

    public magicCircle mc;

    // Use this for initialization
    void Start () {
        //Set Parameters
        princessKissed = false;

        fireStone_Obtained = false;


        StartCoroutine(GameFlow());
    }

    //Sample:
    //yield return new WaitForSeconds(BeginFade(-1));

    IEnumerator GameFlow() {

        yield return StartCoroutine(FirstPuzzle());
        yield return StartCoroutine(SecondPuzzle());
    }

    
    IEnumerator FirstPuzzle()
    {

        print("Hi adventurer, nice to meet you in this dark, dark room, use fire to burn the darkness!");

        Debug.Log("---------FIRST PUZZLE----------");
        while (!lit_room) {
            yield return null;

        }


        while(!fireStone_Obtained)
        {
            
            yield return null;
        }

        mc.gameObject.SetActive(true);

        while (!mc.fire) {
            yield return null;
        }

        Destroy(mc.gameObject);
        mc = null;


        yield return new WaitForSeconds(1.0f);
        Debug.Log("------------FIRST PUZZLE PASSED------------");

        
    }

    IEnumerator SecondPuzzle()
    {
        Debug.Log("---------SECOND PUZZLE----------");
        while (!woodStone_Obtained)
        {

            yield return null;
        }

        yield return new WaitForSeconds(1.0f);
        Debug.Log("------------SECOND PUZZLE PASSED------------");
    }

    // Update is called once per frame
    void Update () {
		
	}

    void FixedUpdate()
    {
        
    }
}