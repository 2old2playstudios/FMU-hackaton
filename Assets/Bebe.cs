﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using MySql.Data.MySqlClient;
using Assets.Scripts;


public class Bebe : MonoBehaviour {


	// Use this for initialization

private string verifica ="bebe";
          
     public Rect windowRect0 = new Rect(20,20,450,480);
	 
	  public static string senha="";
     


     void Start () 
	 {
         
     }
     
     // Update is called once per frame
     void Update () 
	 {
         
     }
	 
     void OnGUI() 
	 {
         windowRect0 = GUI.Window(0, windowRect0, RegisterBoard, "INICIAR FASE 2");
     }
	 
	 
     void RegisterBoard(int windowID) 
	 {

		 
         GUI.Label (new Rect (40, 40, 500, 100), "Digite a senha para iniciar a fase 2");
         senha = GUI.TextField (new Rect (25, 60, 375, 30), senha);
		 
         
		 
		 if (GUI.Button (new Rect (25,410,175, 50), "Liberar fase 2"))
		{

	if (senha == verifica)
			Application.LoadLevel("1");
			
		}
			
			


	 }
	 

}
