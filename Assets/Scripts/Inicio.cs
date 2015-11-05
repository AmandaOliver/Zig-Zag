using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Inicio : MonoBehaviour
{


    /* void OnMouseDown()
 {
         transform.Translate(0, 0, 0.1f);
         Application.LoadLevel("nivel1");
 }
  */
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Translate(0, 0, 0.1f);
            Application.LoadLevel("nivel1");
        }
            
    }
}

