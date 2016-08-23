using UnityEngine;
using System.Collections;
using System.IO;

public class main : MonoBehaviour {

	// Use this for initialization
	void Start () {

        inventaireFichiers();
        Debug.Log("Launching Game");

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void inventaireFichiers()
    {
        string[] mapsJPG = Directory.GetFiles("Assets/Images/Boards", "*.jpg");
        string[] heroesPNG = Directory.GetFiles("Assets/Images/Heroes", "*.png");
        Debug.Log(mapsJPG.Length+" maps disponibles ");
        Debug.Log(heroesPNG.Length + " heroes disponibles");
    }


}
