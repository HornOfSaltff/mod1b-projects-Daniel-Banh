using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Out : MonoBehaviour
{
    void OnTriggerEnter( Collider other ) {

        if ( other.gameObject.tag == "Player" ) {

            Goal.goalMet = true;

            Material mat = GetComponent<Renderer>().material;

            Color c = mat.color;

            c.a = 1;

            mat.color = c;

            SceneManager.LoadScene("Main-Prototype 1");
        }
        
        //if (Goal.goalMet == true){
        //    SceneManager.LoadScene("Main-Prototype 1");

       // }
    }
}
