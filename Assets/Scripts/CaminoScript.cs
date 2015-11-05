using UnityEngine;
using System.Collections;

public class CaminoScript : MonoBehaviour {
    public GameObject leftTilePrefab;
    public GameObject currentTime;
	// Use this for initialization
	void Start () {
        InstanciarTile();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void InstanciarTile()
    {
       // Instantiate(leftTilePrefab, currentTime.transform.GetChild(0).transform.GetChild(0).position, Quaternion.identity());
    }
}
