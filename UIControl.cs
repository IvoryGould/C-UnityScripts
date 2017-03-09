using System;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : monobehaviour{
	public class WorldUI{
		public Text interactText;
		public Image inventoryPanel;
	}
	
	public WorldUI worldUI = new WorldUI();
	
	public void Awake(){
		interactText.enabled = false;
		inventoryPanel.enabled = false;
	}
	
	public void Update(){
		InventoryUiUpdate();
	}
	
	public void InventoryUiUpdate(){
		if (Input.GetKeyDown(KeyCode.Tab) == true){
			inventoryPanel.enabled = true
		}
		
		if (inventoryPanel.enabled = true){
			if(Input.GetKeyDown(KeyCode.Tab) == true){
				inventoryPanel.enabled = false;
			}
		}
	}
}