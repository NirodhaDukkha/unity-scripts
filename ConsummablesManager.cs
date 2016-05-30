using UnityEngine;
using System.Collections;

public class ConsummablesManager : MonoBehaviour {
	public PlayerManager player;
	public UnityEngine.UI.Text cashText;
	public UnityEngine.UI.Text energyText;
	int consummablePrice = -20;
	int consummableBonus = 100;

	public void buyConsummable(){
		if (player.playerCash >= Mathf.Abs(consummablePrice)) {
			player.playerCash += consummablePrice;
			player.playerEnergy += consummableBonus;
			cashText.text = "Cash:  " + player.playerCash;
			energyText.text = "Energy:  " + player.playerEnergy;
		}
	}
}
