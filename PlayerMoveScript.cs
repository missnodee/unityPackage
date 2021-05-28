using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    Rigidbody2D rb2d;
    private float moveSpeed = 3;
	//protected AudioSource jump;

    public const string RIGHT = "right";
    public const string LEFT = "left";
	 public const string space = "space";

    string buttonPressed;
    
	

  

 



	private AudioSource record;
	private AudioSource manshawi;
      private string device;
    // Start is called before the first frame update
    void Start()
	
    {
		
	AudioSource[] audios = GetComponents<AudioSource>();
     record = audios[0];
    manshawi = audios[1];
		
		 device = Microphone.devices[0];
		//jump= GetComponent<AudioSource>();
        rb2d = GetComponent<Rigidbody2D>();
		manshawi.Play();
		
	//	record = GetComponent<AudioSource>();
       
        
		
		
    }

    //Put non physics based movement in here]
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
			
            buttonPressed = RIGHT;
			record.clip = Microphone.Start(device, true, 10, 44100);
			//compare (record,manshawi);
			



            
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            buttonPressed = LEFT;


        }
		 else if (Input.GetKey("space"))
        {
            buttonPressed = space;
          // jump.Play();
		// record.Play();
		 

        }
        else
       {
            buttonPressed = null;
        }

    }
	//----------------------------compare similaruty of audio---
	/*
	private void compare(AudioSource w1,AudioSource w2)
	{
		
		//WaveForm 1 is w1 and WaveForm 2 is w2.
Stack<float> temp = new Stack<float>();
for(int i = 0; i < w1.Length; i++)
{
    //differenceFactor is the variable that decides what difference means.
    //at a value of 1, then a two waves with indexes -0.5 and 0.5 will be "100%" 
    //different. At a value of 0.5f then two waves with indexes -0.5 and 0.5 will be 
    //"50%" different. According to what I see, if differenceFactor > 1f then wave 
    //indexes greater than 1 unit apart are more than "100%" different, so probably don't 
    //do that.
    float difference = Math.Abs(w1[i] - w2[i]);
    temp.Push(((difference < differenceFactor) ? difference : differenceFactor) * 0.5f);
}
return temp.Average();
		
	}
	
	*/
	

    //Put physica based movement in here
    private void FixedUpdate()
    {
        if(buttonPressed == RIGHT)
        {
          rb2d.velocity = new Vector2(2,rb2d.velocity.y);  
        }
        else if(buttonPressed == LEFT)
        {
          rb2d.velocity = new Vector2(-2,rb2d.velocity.y);  
        }
        else if ( buttonPressed == space)
        {
			
          rb2d.velocity = new Vector2(rb2d.velocity.x,2); 
        }
		//  if(buttonPressed == null)
       // {
         // rb2d.velocity = new Vector2(0,0);  
      // }
	  
	  
    }
	
	
	
}
