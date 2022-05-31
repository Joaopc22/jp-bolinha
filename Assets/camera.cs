using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    
    public Vector3 zom;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey(KeyCode.UpArrow))
      {
          zom.z = 0.2f;
          transform.Translate(zom);
      }   

      if(Input.GetKey(KeyCode.DownArrow))
      {
          zom.z = -0.2f;
          transform.Translate(zom);
      }
    }
}
