using UnityEngine;
using System.Collections;


namespace Game
{
	public class vsCpu : MonoBehaviour {

		public GameObject easy;
		public GameObject normal;
		public GameObject hard;

		public GameObject vs2p;

		// Use this for initialization
		void Start () 
		{
			easy.SetActive(false);
			normal.SetActive(false);
			hard.SetActive(false);
		}
		
		// Update is called once per frame
		void Update () {}

		void OnMouseDown()
		{
			Game.context.gameMode = 1;
	
			easy.SetActive(true);
			normal.SetActive(true);
			hard.SetActive(true);

			vs2p.SetActive(false);
			this.gameObject.SetActive(false);
		}

	}
}