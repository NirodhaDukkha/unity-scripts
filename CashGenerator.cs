using UnityEngine;
using System.Collections;

public class CashGenerator : MonoBehaviour {

	
	public PlayerManager player;
	public UnityEngine.UI.Text cashText;
	public UnityEngine.UI.Text timeText;
	float baseValue = 1f;
	public float baseBonusChance = 0.0f;
	public float baseBonusValue = 0.5f;
	public float cashPerTick;
	public float bonusCashPerTick = 0.0f;
	public float timeBaseline = 5.0f;
	public float timeToNext = 0.0f;
	public float timeRemovedWithClick;
	public float timeTilTick;
	public float tickParameter = 40f;
	// Use this for initialization
	void Start () {
		cashPerTick = baseValue + bonusCashPerTick;
		timeTilTick = timeBaseline;

		//StartCoroutine (AutoTicker ());

	}
	
	// Update is called once per frame
	void Update () {
		timeTilTick -= Time.deltaTime;
		if (timeTilTick <= 0) {
			cashTick ();
			timeTilTick = timeBaseline - (tickParameter*Mathf.Log(Random.value + .000000001f));
		}
		cashText.text = "Cash:  " + player.playerCash;
		timeText.text = "Time to next:  " + timeTilTick.ToString("0.00");
	}

	public void cashTick(){
		cashPerTick = baseValue + bonusCashPerTick;
		if (Random.value <= baseBonusChance) {
			player.playerCash += (cashPerTick*(1f+baseBonusValue));
		} else {
			player.playerCash += cashPerTick;
		}

	}

}
