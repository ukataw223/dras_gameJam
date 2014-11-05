using UnityEngine;
using System.Collections;

public class Tweet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			// Gamemode = vsCPU  if : Win
			if(Game.context.gameMode == 1 && Game.context.vsResult == 1)
			{
				if(this.gameObject.guiTexture.HitTest(Input.mousePosition))
				{
					string message = " " + "反応速度は"+ Game.context.player1Time + "秒だったぜ！　俺より早く先生に勝てるかな？ #DorasuGameJam #出、出〜授業寝奴〜";
					Application.OpenURL("http://twitter.com/intent/tweet?text=" + WWW.EscapeURL(message));
				}
			}

			// Gamemode = vsCPU  if: Lose
			if(Game.context.gameMode == 1 && Game.context.vsResult == 0)
			{
				if(this.gameObject.guiTexture.HitTest(Input.mousePosition))
				{
					string message = " " + "先生の反応速度に勝てないッ・・・・！俺のかわりに勝ってくれ！#DorasuGameJam #出、出〜授業寝奴〜";
					Application.OpenURL("http://twitter.com/intent/tweet?text=" + WWW.EscapeURL(message));
				}
			}

			// Gamemode = vs2P  if: 1pWin
			if( Game.context.gameMode == 2 && Game.context.vsResult == 1)
			{
				if(this.gameObject.guiTexture.HitTest(Input.mousePosition))
				{
					string message = " " + "反応速度は"+ Game.context.player1Time + "秒だったぜ！　俺より早く先生に勝てるかな？ #DorasuGameJam #出、出〜授業寝奴〜";
					Application.OpenURL("http://twitter.com/intent/tweet?text=" + WWW.EscapeURL(message));
				}
			}

			//Gamemode  = vs2P if: 2pWin
			if( Game.context.gameMode == 2 && Game.context.vsResult == 1)
			{
				if(this.gameObject.guiTexture.HitTest(Input.mousePosition))
				{
					string message = " " + "反応速度は"+ Game.context.player1Time + "だったわ！ちゃんと起きて授業受けなさい！私の速度に勝てるかしら？ #DorasuGameJam #出、出〜授業寝奴〜";
					Application.OpenURL("http://twitter.com/intent/tweet?text=" + WWW.EscapeURL(message));
				}
			}

			// GameMode - vs2P if: Draw
			if( Game.context.gameMode == 2 && Game.context.vsResult == 3)
			{
				if(this.gameObject.guiTexture.HitTest(Input.mousePosition))
				{
					string message = " " + "勝負はお預け！　君も一緒にやってみよう！ #DorasuGameJam #出、出〜授業寝奴〜";
					Application.OpenURL("http://twitter.com/intent/tweet?text=" + WWW.EscapeURL(message));
				}
			}

		}
	}
}
