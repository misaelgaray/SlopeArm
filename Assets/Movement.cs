using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

	public GameObject joint1;
	public GameObject joint2;
	bool keepRotating = false;

	//Por si usas la formula de slope estos parametros
	//se pueden configurar
	public float x1 = 1;
	public float x2 = 2;
    
    private string orientation = "left";
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space)){
        	keepRotating = true;
        	orientation = "right";
        }

        if(Input.GetKeyDown(KeyCode.LeftShift)){
        	keepRotating = true;
        	orientation = "left";
        }

        if(Input.GetKeyUp(KeyCode.Space) || 
        	Input.GetKeyUp(KeyCode.LeftShift)){
        	keepRotating = false;
        }


        if(keepRotating){
        	joint1.transform.Rotate(orientation == "right"?0.5f:-0.5f,0,0,Space.Self);
        	joint2.transform.Rotate(orientation == "right"?0.5f:-0.5f,0,0,Space.Self);
        }
    }
}
