using UnityEngine;
using System.Collections;

namespace Game
{

	public class result_Score : MonoBehaviour {

		private GUIStyle label_style;
		private string label_text;
		private float label_width;
		private float label_height;
		private float label_x;
		private float label_y;
	
		// Use this for initialization
		void Start () {
			label_style = new GUIStyle();
			label_style.fontSize = Screen.width / 6;
			label_style.normal.textColor = new Color(0, 0, 0, 1);
			label_x = Screen.width * 0.1f;
			label_y = Screen.height *  0.4f;
		}

		void Update()
		{
			if(Game.context.vsResult == 1)
				label_text = "time: " + Game.context.player1Time;
			if(Game.context.vsResult == 2)
				label_text = "time: " + Game.context.player2Time;
			if(Game.context.vsResult == 0 )
			{
				label_text = "Time: "  + Game.context.player1Time;
			}
		}
	
		
		void OnGUI()
		{
			GUI.Label(new Rect(label_x, label_y, 0, 0), label_text, label_style);
		}
	}

}