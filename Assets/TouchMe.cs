

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchMe : MonoBehaviour {

	public GameObject previousobject;
	public Material whitecolor;
	public Material defaultColor;
	Collider m_Collider;
	public Text descText;
	// Use this for initialization
	void Start () {

		m_Collider = GetComponent<Collider>();
		Info = "Touch objects for description";
		DrawInfo();

	}

	// Update is called once per frame

	private bool PopUp = false;
	private bool firstpopup;
	public string Info;
	public string desc = "Touch any Object for its Description";
	public Rect window = new Rect(100, 50, 600, 200);
	public Material[] mats;
	public float wx;
	public float wy;


	void OnMouseUp() {
		if (this.GetComponent<Renderer> () && this.GetComponent<Renderer> ().materials.Length>0) {

			mats = this.GetComponent<Renderer> ().materials;
			if (mats.Length > 0) {
				mats [0] = defaultColor; //mats [1];
			}
			this.GetComponent<Renderer> ().materials = mats;

		}
		//PopUp = false;
		Info = "Touch objects for description";
		DrawInfo();
		m_Collider.enabled = true;

	}
	void OnMouseDown()
	{

		if (this.GetComponent<Renderer> () && this.GetComponent<Renderer> ().materials.Length>0) {
			mats = this.GetComponent<Renderer> ().materials;
			defaultColor = mats [0];
			if (mats.Length > 0) {
				mats [0] = whitecolor; //mats [1];
			}
			this.GetComponent<Renderer> ().materials = mats;

		}
		//PopUp = true;
		Info = "Description : \n" + this.name;

		m_Collider.enabled = false;
		Info = m_Collider.name;
		DrawInfo();

	}
	/*void Update () {
		if (PopUp) {
			desc = Info;
		}
	}*/
	void DrawInfo()
	{	
		descText.text = "Description: " + Info;
		/*Rect close = new Rect (700,50,50,50);
		if (PopUp)
		{	
			GUI.color = Color.white;

			GUI.skin.box.fontSize = 20;
			GUI.Box(window, Info);
			if (GUI.Button (close,"X"))
			{
				PopUp = false;
			}
		}*/
	}
	/*void OnGUI()
	{
		DrawInfo ();
	}*/
}

