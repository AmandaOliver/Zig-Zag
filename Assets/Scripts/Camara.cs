using UnityEngine;
using System.Collections;

public class Camara : MonoBehaviour {

    public GameObject sphere;
    private Vector3 offset;

    // Use this for initialization
    void Start()
    {
        offset = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = sphere.transform.position + offset;
    }
}
