using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSign : MonoBehaviour
{


    
    
        
        public void Move(float a)
        {



            transform.position = new Vector2(a - 14f, transform.position.y);
        
        }
    
}
