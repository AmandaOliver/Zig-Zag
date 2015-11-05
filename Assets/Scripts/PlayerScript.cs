using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {

    public float velocidad;
    public Vector3 direccion;
    int cambio = 0;

    private int count;

    public Text text;

    void settext()
    {
        text.text = "Puntuación: " + count.ToString();
      
        
    }
    // Use this for initialization
    void Start () {
        direccion = Vector3.zero;
        count = 0;
        if (Application.loadedLevelName != "nivel1")
        {
            count=PlayerPrefs.GetInt("puntos");
        }     
        
        settext();
    }
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.y < -1)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase==TouchPhase.Ended)
       //(Input.GetMouseButtonDown(0))
        {               
            if (direccion == Vector3.forward)
            {
                direccion = Vector3.left;
                
            }
            else
            {
                direccion = Vector3.forward;
                
            }
        }
        float cantidad_movimiento = velocidad * Time.deltaTime;
        transform.Translate(direccion * cantidad_movimiento);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cactus")
        {
            other.gameObject.SetActive(false);
            count++;
            settext();

            if ( GameObject.FindGameObjectsWithTag("Cactus").Length==0)
            {
                PlayerPrefs.SetInt("puntos", count);
                PlayerPrefs.Save();
                if (PlayerPrefs.GetInt("record") < PlayerPrefs.GetInt("puntos"))
                {
                    PlayerPrefs.SetInt("record", count);
                }
                if (Application.loadedLevelName == "nivel3") Application.LoadLevel("menu");
                else Application.LoadLevel(Application.loadedLevel + 1);               
            }
        }
    }
}
