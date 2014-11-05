using UnityEngine;
using System.Collections;

namespace Game
{
	public class backTitel : MonoBehaviour {

		// Use this for initialization
		void Start () {
		
		}
		
		// Update is called once per frame
		void Update () {
		
		}

		//  mouse click load Titel;
		void OnMouseDown()
		{
			Game.context.Reset();
			Application.LoadLevel("Title");
		}
	}
}