using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comando : MonoBehaviour
{
    public Vector3 mv1;
    public Vector3 mv2;
    public Vector3 jump;

    public Vector3 rote;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey(KeyCode.W))
    {
      mv1.z = 0.1f;
      transform.Translate(mv1);
    }  

    if(Input.GetKey(KeyCode.S))
    {
      mv1.z = -0.1f;
      transform.Translate(mv1); 
    }  
     if(Input.GetKey(KeyCode.A))
    {
      mv2.x = -0.1f;
      transform.Translate(mv2);
    }  

    if(Input.GetKey(KeyCode.D))
    {
      mv2.x = 0.1f;
      transform.Translate(mv2); 
    }

     if(Input.GetKey(KeyCode.Space))
    {
      jump.y = 0.2f;
      transform.Translate(jump);
    }

    if(Input.GetKey(KeyCode.RightArrow))
    {
      rote.y = 0.5f;
      transform.Rotate(rote);
    }
    if(Input.GetKey(KeyCode.LeftArrow))
    {
      rote.y = -0.5f;
      transform.Rotate(rote);

    }
  }
}