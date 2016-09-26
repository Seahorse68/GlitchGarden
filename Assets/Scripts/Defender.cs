using UnityEngine;
using System.Collections;

public class Defender : MonoBehaviour {

    public int starCost = 100;

    private StarDisplay starDisplay;

	// Use this for initialization
	void Start () {
        //starDisplay = GetComponent<StarDisplay>();
        starDisplay = GameObject.FindObjectOfType<StarDisplay>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

     public void AddStars(int amount)
    {
        starDisplay.AddStars(amount);
    }
}
