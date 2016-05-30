using UnityEngine;
using System.Collections;

public class UpgradeManager : MonoBehaviour {

	public PlayerManager player;
	public CashGenerator cashGenerator;

	int maxRateUpgrades = 5;
	int maxBaseUpgrades = 5;
	int maxChanceUpgrades = 5;
	int maxBonusValueUpgrades = 5;

	public float rateUpgradeValue = -1.0f;
	public float baseUpgradeValue = 1.0f;
	public float chanceUpgradeValue = 0.1f;
	public float bonusUpgradeValue = 0.5f;

	public int rateUpgrades = 0;
	public int baseUpgrades = 0;
	public int chanceUpgrades = 0;
	public int bonusValueUpgrades = 0;

	public float rateUpgradeCost = -20f;
	public float baseUpgradeCost = -20f;
	public float chanceUpgradeCost = -20f;
	public float bonusValueUpgradeCost = -20f;

	public void rateUpgrade(){
		if ((rateUpgrades < maxRateUpgrades) && (rateUpgradeCost <= player.playerCash)) {
			rateUpgrades++;
			player.playerCash += rateUpgradeCost;
			cashGenerator.timeBaseline += rateUpgradeValue;
		}
	}

	public void baseUpgrade(){
		if ((baseUpgrades < maxBaseUpgrades) && (baseUpgradeCost <= player.playerCash)) {
			baseUpgrades++;
			player.playerCash += baseUpgradeCost;
			cashGenerator.bonusCashPerTick += baseUpgradeValue;
		}
	}

	public void chanceUpgrade(){
		if ((chanceUpgrades < maxChanceUpgrades) && (chanceUpgradeCost <= player.playerCash)){
			chanceUpgrades++;
			player.playerCash += chanceUpgradeCost;
			cashGenerator.baseBonusChance += chanceUpgradeValue;
		}
	}

	public void bonusUpgrade(){
		if ((bonusValueUpgrades < maxBonusValueUpgrades) && (bonusValueUpgradeCost <= player.playerCash)){
			bonusValueUpgrades++;
			player.playerCash += bonusValueUpgradeCost;
			cashGenerator.baseBonusValue += bonusUpgradeValue;
		}
	}

}
