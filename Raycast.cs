

public class Raycast : monobehaviour{
	RaycastHit hit;
	vector3 forward = transform.TransformDirection(vector3.forward);
	public void Update(){
		if (Physics.Raycast(transform.position, forward, out hit, rayDistance)){
			if (hit.collider.tag == "Chest"){
				worldUI.interactText.enabled = true;
				if (Input.GetKeyDown(KeyCode.E) == true){
					worldUI.inventoryPanel = true;
				}
			} 
		} else {
			worldUI.interactText.enabled = false;
		}
	}
}