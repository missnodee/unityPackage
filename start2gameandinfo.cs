using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class start2gameandinfo : MonoBehaviour
{
    // Start is called before the first frame update
     
   public void playbutton ()
   {
	   SceneManager.LoadScene(2); 
	   
   }
    public void infobutton ()
   {
	   SceneManager.LoadScene(1); 
	   
   }
 
}
