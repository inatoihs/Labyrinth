using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class GameDirector : MonoBehaviour
{
    GameObject pointText;
    int point = 0;


   //ドアに触れたときに1point追加する
    public void TouchDoor()
    {
        this.point += 1;
    }




    // Start is called before the first frame update
    void Start()
    {
        this.pointText = GameObject.Find("Point");
    }

    // Update is called once per frame
    void Update()
    {
       this.pointText.GetComponent<Text>().text = this.point.ToString() + "point";
    }
}
