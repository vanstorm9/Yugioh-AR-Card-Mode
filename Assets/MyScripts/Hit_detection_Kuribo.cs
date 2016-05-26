using UnityEngine;
using System.Collections;

public class Hit_detection_Kuribo : MonoBehaviour {

    private GameObject DE, ME, Spark, Blast, Cyclone; //effects, monsters
    private int timer;
    void Start()
    {
        Spark = transform.FindChild("Spark").gameObject;
        //Blast = transform.FindChild("Blast").gameObject;
    }

    void OnCollisionEnter(Collision col)
    {
        //Debug.Log("Entered my domain!");
        Spark.SetActive(true);
        //Blast.SetActive(true);
        timer = 0;
    }

    void OnCollisionStay(Collision col)
    {
        //Debug.Log("Still in my domain!");
        
    }

    void OnCollisionExit(Collision col)
    {
        Spark.SetActive(false);
        //Blast.SetActive(false);
        /*
        if (timer % 20 == 0)
        {

            Spark.enable = false;
            Blast.enable = false;
            Spark.Emit();
            Blast.Emit();
            Spark.enable = true;
            Blast.enable = true;

        }
        else
        {
            Spark.SetActive(true);
        }
        */
        //timer++;
    }

}
