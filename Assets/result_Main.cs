using UnityEngine;
using System.Collections;





public class result_Main : MonoBehaviour {


	private GUIStyle label_style;
	private string label_text;
	private float label_width;
	private float label_height;
	private float label_x;
	private float label_y;

	// Use this for initialization
	void Start () {
		label_style = new GUIStyle();
		label_style.fontSize = Screen.width / 5;
		label_style.normal.textColor = new Color(0, 0, 0, 1);
		label_x = Screen.width *4.5f/ 20;
		label_y = Screen.height * 1 / 20;
		if(Game.context.vsResult == 1)
			label_text = "1p Win";
		if(Game.context.vsResult == 2)
			label_text = "2p Win";
		if(Game.context.vsResult == 0)
			label_text = "Lose";
		if(Game.context.vsResult == 3)
			label_text = "Draw";
		
			
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnGUI()
	{
		GUI.Label(new Rect(label_x, label_y, 0, 0), label_text, label_style);
	}
}
