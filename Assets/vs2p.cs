using UnityEngine;
using System.Collections;


namespace Game
{
	public class vs2p : MonoBehaviour 
	{

		// Use this for initialization
		void Start () {}
		// Update is called once per frame
		void Update () {}

		// if on mouse down thisTexture
		void OnMouseDown()
		{
			Game.context.gameMode = 2;
			Application.LoadLevel("Play");
		}
	}
}