using UnityEngine;
using System.Collections;

public class AssignmentObject {
	public int id, points;
	public bool is_archived;
	public string name, description, language, created_at, updated_at;
	
	public AssignmentObject(JSONObject obj) {
		this.id = (int)obj["id"].n;
		this.points = (int)obj["points"].n;
		this.is_archived = obj["is_archived"].b;
		this.name = obj["name"].str;
		this.description = obj["description"].str;
		this.language = obj["language"].str;
		this.created_at = obj["created_at"].str;
		this.updated_at = obj["updated_at"].str;
	}
	
	public string to_str() {
		string str = this.id + ": " + this.name;
		
		str += "\t" + this.points;
		str += "\t" + this.is_archived;
		str += "\t" + this.description;
		str += "\t" + this.language;
		str += "\t" + this.created_at;
		str += "\t" + this.updated_at;
		
		return str;
	}
}
