using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody rbody;

    public Text score;

    public float forwardForce=80;

    public float sideForce= 70;
    
    public UnityEvent OnHold;
   public bool IsHolding;

   public bool botonDerecho=false;

   public bool botonIzquierdo=false;

 bool button_control = false;
    public void pressed(BaseEventData eventData)
    {
        button_control = true;
    }
    public void notpressed(BaseEventData eventData)
    {
        button_control = false;

    }

    public void precionarBtonDerecho(){

        botonDerecho=true;
        botonIzquierdo=false;
    }

    public void precionarBtonIzquierdo(){

        botonDerecho=false;
        botonIzquierdo=true;
    }

    // Update is called once per frame
    void Update()
    {
             rbody.AddForce(0,0, forwardForce * Time.deltaTime);

         
        if (button_control){

          

            if (botonDerecho  && !botonIzquierdo){

                Debug.Log("precionando boton derecho TRUE");

                 rbody.AddForce(sideForce * Time.deltaTime,0,0);
  
            }else if(!botonDerecho && botonIzquierdo){

                Debug.Log("PRecionando boton izquierdo");

                 rbody.AddForce(-sideForce * Time.deltaTime,0,0);


            }

           
                
            

        
        }
        
    

             if (Input.GetKey("d"))
             {

                 rbody.AddForce(sideForce * Time.deltaTime,0,0);
                 
             }

              if (Input.GetKey("a"))
             {

                 rbody.AddForce(-sideForce * Time.deltaTime,0,0);
                 
             }

             score.text=transform.position.z.ToString("0");

    }

    
  


}
