using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorGrid : MonoBehaviour
{
public GameObject cell;
public int width;
   public float gap=0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
        for(int i=0 ;i<width; i++){

            for(int j=0;j<width ;j++){

                Vector3 CellPos=new Vector3(i*gap,0,j*gap);


                GameObject c= Instantiate(cell,CellPos,Quaternion.identity);
                c.transform.SetParent(transform);

            }

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
