using UnityEngine;
using System.Collections;

public class Hit_detection : MonoBehaviour {

    private GameObject Spark, Cyclone; //effects, monsters

    void Start()
    {
        Spark = transform.FindChild("Spark").gameObject;
    }

    void OnCollisionEnter(Collision col)
    {
        //Debug.Log("Entered my domain!");
    }

    void OnCollisionStay(Collision col)
    {
        //Debug.Log("Still in my domain!");
        Spark.SetActive(true);
    }


}
