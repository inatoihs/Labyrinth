using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTextController : MonoBehaviour
{
    public GameObject StartText;


    void OnTriggerEnter(Collider other)
    {
      StartText.SetActive(true);   //テキストを表示
      Invoke("Destroy", 4);　　//テキストを消す
    }

    //Invokeで使う
    void Destroy()
    {
        Destroy(StartText);
    }
 

        // Start is called before the first frame update
        void Start()
    {
       
    }

 

     // Update is called once per frame
    void Update()
    {

    }
}