using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomBa : MonoBehaviour
{
    public int step;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        KeyBoardSimulation();

        
    }


    public void KeyBoardSimulation(){
        if(Input.GetKeyDown(KeyCode.W)){

            transform.position= transform.position+new Vector3(0,0,1);
        
        }



        if(Input.GetKeyDown(KeyCode.A)){
           transform.position= transform.position+new Vector3(-1,0,0);
            
        }

        if(Input.GetKeyDown(KeyCode.S)){
 transform.position= transform.position+new Vector3(0,0,-1);
            
        }

        if(Input.GetKeyDown(KeyCode.D)){

             transform.position= transform.position+new Vector3(1,0,0);
        }


    }
}
