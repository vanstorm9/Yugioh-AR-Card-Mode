// based on this: https://developer.vuforia.com/forum/faq/unity-how-can-i-popup-gui-button-when-target-detected
// aso this: https://developer.vuforia.com/forum/faq/unity-how-can-i-play-audio-when-targets-get-detected
using UnityEngine;
using System.Collections;
using Vuforia;

public class forTracker2 : MonoBehaviour, ITrackableEventHandler {
	private TrackableBehaviour mTrackableBehaviour; // trackers
	//float PlayerLifePoints = 4000f;
	//public GUIStyle MyGUIstyle;
	private bool mShowGUIButton  = false; // GUI 
	private Rect attackButton2 = new Rect(970,30,120,40); // GUI
	private Rect defenseButton2 = new Rect(970,80,120,40); // GUI

	private GameObject DE, ME, Spark, Blast, Cyclone; //effects, monsters

	void Start()
	{
		Spark = transform.FindChild("Spark").gameObject; // effects
		Spark.SetActive(false); 	

		//Blast = transform.FindChild("Blast").gameObject; // effects
		//Blast.SetActive(false); 
		// effects
		Cyclone = transform.FindChild("Cyclone").gameObject; // effects
		Cyclone.SetActive(false); 

		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
	}
	
	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
		    newStatus == TrackableBehaviour.Status.TRACKED ||
		    newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{
			// Play audio when target is found
			//Debug.Log("Play Sound");
			mShowGUIButton  = true;
			//defenseButton = true;
			//audio.Play();
		}
		else
		{
			// Stop audio when target is lost
		//	Debug.Log("Stop Sound");
			mShowGUIButton  = false;
			//defenseButton = false;
			//audio.Stop();
		}
	}  

	void OnGUI() {
        if (mShowGUIButton) {
			// draw the GUI button
			if (GUI.Button(attackButton2, "ATK/300")) {
				Debug.Log ("Attack!");
				Cyclone.SetActive(false);
				Spark.SetActive(true);
				Blast.SetActive(true);
				StartCoroutine(StartWait());


				// do something on button click 
			}
			if (GUI.Button(defenseButton2, "DEF/200")) {
				Debug.Log ("Defense!");
				Cyclone.SetActive(true);
				//Spark.SetActive(false);
			}
		}
	}

	IEnumerator StartWait()
	{
		yield return StartCoroutine(Wait(1.50F));
		Spark.SetActive(false);
		Cyclone.SetActive(false);
		Blast.SetActive(false);
	}
	

	IEnumerator Wait(float seconds)
	{
		yield return new WaitForSeconds(seconds);
	}
}


