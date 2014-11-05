 using UnityEngine;
using System.Collections;

namespace Game
{

	public class context : MonoBehaviour {

		public static float player1Time;
		public static float player2Time;

		//PlayScene using variables (GameMode)
		public static int gameMode;
		//PlayScene using  variables (1PvsCPU difficult)
		public static int difficulty;

		public static int vsResult;

		// Use this for initialization
		void Start () 
		{
			Reset();
		}
		
		// Update is called once per frame
		void Update () 
		{
		
		}

		public static void Reset()
		{
			player1Time = 0;
			player2Time = 0;

			gameMode = 0;

			difficulty = 0;

			vsResult = 0;

		}

	}
}
