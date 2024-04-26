using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Movement : MonoBehaviour
{
    public int speed = 50;
    // Start is called before the first frame update
    void Start()
    {
        
        //controller = gameObject.AddComponent<Character_Movement>();
    }

    // Update is called once per frame
    void Update()
    {
       
        
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow) ){
			transform.Translate(0, 0, speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) ){
			transform.Translate(0, 0, -speed * Time.deltaTime);
		}
		 if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) ){
			transform.Translate(-speed * Time.deltaTime, 0, 0);
		}
		 if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) ){
			transform.Translate(speed * Time.deltaTime, 0, 0);
		}
         if (Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.LeftArrow) ){
			transform.Translate(0, speed * Time.deltaTime, 0);
		}
        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.LeftArrow) ){
			transform.Translate(0, -speed * Time.deltaTime, 0);
		}
    }
}
