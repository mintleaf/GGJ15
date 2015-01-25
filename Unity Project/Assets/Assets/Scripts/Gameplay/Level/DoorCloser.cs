﻿using UnityEngine;
using System.Collections;

public class DoorCloser : vp_Interactable {

	public DoorScript doorToClose;

	protected override void OnTriggerEnter (Collider col) {

		if (StateManager.Instance.RoomsSpawned.Count < 2)
			return;
		
		doorToClose = StateManager.Instance.GetDoor (StateManager.Instance.RoomsSpawned [0].gameObject);
		if (doorToClose == null)
			return;
		doorToClose.transform.SetParent (StateManager.Instance.RoomsSpawned [1].transform);
		if (doorToClose.closed == true)
			return;
		doorToClose.GetComponent<DoorScript> ().CloseDoor ();
		TimeManager.Instance.RestartTime ();
		base.OnTriggerEnter (col);
	}
	/*
	public override bool TryInteract (vp_FPPlayerEventHandler player) {
		if (StateManager.Instance.RoomsSpawned.Count < 2)
			return false;

		doorToClose = StateManager.Instance.GetDoor (StateManager.Instance.RoomsSpawned [0].gameObject);
		if (doorToClose == null)
			return false;
		doorToClose.transform.SetParent (StateManager.Instance.RoomsSpawned [1].transform);
		if (doorToClose.closed == true)
			return false;
		doorToClose.GetComponent<DoorScript> ().CloseDoor ();
		TimeManager.Instance.RestartTime ();
		return base.TryInteract (player);

	}*/

}
