using UnityEngine;
using System.Collections;

namespace Game
{
	public class vsCpuEasy : MonoBehaviour {

		// Use this for initialization
		void Start () {
		
		}
		
		// Update is called once per frame
		void Update () {
		
		}

		void OnMouseDown()
		{
			Game.context.difficulty = 1;
			Application.LoadLevel("Play");
		}

	}
}