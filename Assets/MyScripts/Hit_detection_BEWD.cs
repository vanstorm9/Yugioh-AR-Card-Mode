using UnityEngine;
using System.Collections;

public class Hit_detection_BEWD : MonoBehaviour {

    private GameObject Spark, Cyclone; //effects, monsters
    private int timer;

    void Start()
    {
        Spark = transform.FindChild("Spark").gameObject;
    }

    void OnCollisionEnter(Collision col)
    {
        //Debug.Log("Entered my domain!");
        Spark.SetActive(true);
        timer = 0;
    }

    void OnCollisionStay(Collision col)
    {
        //Debug.Log("Still in my domain!");
        
        /*
        if (timer % 20 == 0)
        {

            Spark.enable = false;
            Spark.Emit();
            Spark.enable = true;

        } else {
            Spark.SetActive(true);
        }
        */

        timer++;

    }

    void OnCollisionExit(Collision col)
    {
        Spark.SetActive(false);
    }


}
