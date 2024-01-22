using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    // otan allazw to xrwma prosoxi giati to default calue einai trasnparent
    [SerializeField] Color32 packagecolor = new Color32 (1,1,1,1);
    [SerializeField] Color32 packagecolor2 = new Color32 (1,1,1,1);
    [SerializeField] Color32 packagecolor3 = new Color32 (1,1,1,1);
    [SerializeField] Color32 nocolor = new Color32 (1,1,1,1);//to serializefield einai gia na to peirazoume apo ton inspector
    [SerializeField] float destroyDelay= 0.5f;
    SpriteRenderer SpriteRenderer;

    bool hasPackage = false;
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Ouch!");
    }

    void Start(){
        SpriteRenderer = GetComponent<SpriteRenderer>();//ti apothikeuoume
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        //if (the thing we trigger is the package){
        //  print package is picked
        //}
        if(other.tag == "Package" && !hasPackage){
            Debug.Log("Package Picked");
            hasPackage =true;
            SpriteRenderer.color = packagecolor;//tou dinoyme to xrwma
            Destroy(other.gameObject,destroyDelay);
        }
         if(other.tag == "Location" && hasPackage==true ){
            Debug.Log("Package Delivered");
            hasPackage=false;
            SpriteRenderer.color = nocolor;
        }
    }
}
