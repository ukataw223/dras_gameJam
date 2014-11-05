using UnityEngine;
using System.Collections;

namespace Game{

	public class PLay : MonoBehaviour 
	{

		//GameStart+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		// gameobject of Examation
		public GameObject examation;
		//play timer
		private float timer;
		// rand settingTimes
		private float runTime;
		//enemy Times
		private float enemyTime;

		//foul
		bool foul1; //player1
		bool foul2; //player2

		//battleresult
		bool result;

		const float cantTouchTime = 2.0f;


		public GUITexture student;
		public GUITexture teachar;

		public GameObject fault_p1;
		public GameObject fault_p2;

		public Texture student_damage;
		public Texture student_guard;
		public Texture student_sleep;

		public Texture teachar_attack;
		public Texture teachar_check;
		public Texture teachar_wait;

		public GameObject ex;
		public GameObject gu;
		public GameObject da;

		//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


		//GameEnd=============================================================
		//Game ended wait times
		public float endTime;
		// game finished running timer
		private float finishedTimer;
		//====================================================================
		

		//gamemode 1 = START 0 = END		
		int game;

		// Use this for initialization
		void Start () {
			timer = 0;
			finishedTimer = 0;
			//setting Gametime
			runTime = Random.Range(4.0f,11.0f);

			examation.SetActive(false);
			fault_p1.SetActive(false);
			fault_p2.SetActive(false);

			ex.SetActive(false);
			gu.SetActive(false);
			da.SetActive(false);

			//setting enemy waittime
			switch(Game.context.difficulty)
			{
			case 1:
				enemyTime = 1.5f;
				break;
			case 2:
				enemyTime = 0.7f;
				break;
			case 3:
				enemyTime = 0.25f;
				break;
			}

			foul1 = false;
			foul2 = false;

			game = 1;	//game... 1 = START 0 = END
		}
		
		// Update is called once per frame
		void Update () 
		{
			if(game == 1)
			{
				if(Game.context.gameMode == 1)
				{
					GameStart();	
				}
				if(Game.context.gameMode == 2)
				{
					GameStartVs();
				}
			}
			else
			{
				GameEnd();
			}



		}


		void GameStart()
		{
			//update time
			timer += Time.deltaTime;
			
			//  "cantTouchTime" sec later
			if(timer > cantTouchTime)
			{
				if( timer < runTime + cantTouchTime )
				{
					if(Input.GetKeyDown(KeyCode.A))
					{
						foul1 = true;
						fault_p1.SetActive(true);
					}
				}
				else
				{
					//kokoni bikkuri
					ex.SetActive(true);

					teachar.texture = teachar_check;
					examation.SetActive(true);
					if(Input.GetKeyDown(KeyCode.A) && foul1 != true )
					{
						//kokoni ga-do
						gu.SetActive(true);

						Game.context.player1Time = timer - ( runTime + cantTouchTime );	
						result = true;
						examation.SetActive(false);	
						teachar.texture = teachar_attack;
						student.texture = student_guard;
						Game.context.vsResult = 1;
						game = 0;
					}
					if( (enemyTime + runTime + cantTouchTime ) <= timer )
					{
						// kokoni utareta
						da.SetActive(true);

						result = false;
						teachar.texture = teachar_attack;
						student.texture = student_damage;
						examation.SetActive(false);	
						fault_p1.SetActive(false);
						Game.context.player1Time = (timer - runTime - cantTouchTime );
						game = 0;
					}
				}
			}
		}

		void GameEnd()
		{
			finishedTimer += Time.deltaTime;
			if(finishedTimer > endTime)
			{
				Application.LoadLevel("Result");
			}
		}

		void GameStartVs()
		{
			//update time
			timer += Time.deltaTime;
			
			// 3sec later
			if(timer > cantTouchTime)
			{
				if( timer < runTime + cantTouchTime )
				{					
					if(Input.GetKeyDown(KeyCode.A))
					{
						foul1 = true;
						fault_p1.SetActive(true);
						
					}
					if(Input.GetKeyDown(KeyCode.RightArrow))
					{
						foul2 = true;
						fault_p2.SetActive(true);
					}

					if( foul1&& foul2 )
					{
						Game.context.vsResult = 3;
						game = 0;
					}

				}
				else
				{
					// kokoni bikkuri
					ex.SetActive(true);

					teachar.texture = teachar_check;
					examation.SetActive(true);
					if(Input.GetKeyDown(KeyCode.A) && foul1 != true )
					{
						// kokoni ga-do
						gu.SetActive(true);
			
						Game.context.player1Time = timer - ( runTime + cantTouchTime );
						result = true;
						fault_p2.SetActive(false);
						examation.SetActive(false);	
						teachar.texture = teachar_attack;
						student.texture = student_guard;
						Game.context.vsResult = 1;
						game = 0;
					}
					if( Input.GetKeyDown(KeyCode.RightArrow) && foul2 != true )
					{
						// kokoni utareta
						da.SetActive(true);

						Game.context.player2Time = timer - ( runTime + cantTouchTime );
						teachar.texture = teachar_attack;
						student.texture = student_damage;
						result = false;
						fault_p1.SetActive(false);
						examation.SetActive(false);	
						Game.context.vsResult = 2;
						game = 0;
					}
				}
			}
		}


	}
}
