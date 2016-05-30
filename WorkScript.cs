using UnityEngine;
using System.Collections;

public class WorkScript : MonoBehaviour {

	public PlayerManager player;
	public CashGenerator cashGenerator;
	public UnityEngine.UI.Text energyText;
	// Use this for initialization

	public void workClick(){
		if (player.playerEnergy >= Mathf.Abs(player.workCost)) {
			player.playerEnergy += player.workCost;
			energyText.text = "Energy:  " + player.playerEnergy;
			cashGenerator.timeTilTick += player.workValue;
		}
	}
}
