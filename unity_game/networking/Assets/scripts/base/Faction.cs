using UnityEngine;
using System.Collections;

public class Faction {
	private string name;

	public Faction(string name) {
		this.name = name;
	}

	public string getName() {
		return name;
	}

	public void setName(string name) {
		this.name = name;
	}
}
