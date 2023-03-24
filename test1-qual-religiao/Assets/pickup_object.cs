using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup_object : MonoBehaviour
{
    public  GameObject obj;
    public GameObject shell;
    public GameObject pointer;
    private int n=0;
    // Start is called before the first frame update
    void Start()
    {
        shell.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      //Debug.Log(pointer.transform.position[2]);
       /**
       if(n!=0){
        
        //Debug.Log(obj.transform.position);
        Vector3 pos=obj.transform.position ;
        Vector3 newpos= new Vector3(pointer.transform.position[0],obj.transform.position[1],pointer.transform.position[2]);
        pos= Vector3.Lerp(obj.transform.position, newpos, Time.deltaTime*30);
        obj.transform.position=pos;
       }
       if(n!=0){
        }
        /* */
       
    }
    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("colidiu");
        if(collision.CompareTag("obj")){
            Debug.Log("colidiu obj");
            shell.SetActive(true);
            n=1;
        }
    }
     void OnTriggerExit(Collider collision){

        if(collision.CompareTag("obj")){
        shell.SetActive(false);
        n=0;
        }

        
    }
}
