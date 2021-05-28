using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sign : MonoBehaviour
{
	
	 void Start()
    {
		
    }
   void OnTriggerEnter2D(Collider2D collider)
  {
	 
	  if (collider.tag == "Player")
	  { 
           
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
          
  }
  }
}
