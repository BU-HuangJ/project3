using System.Collections.Generic;

public class Member {
	
	private string username;
	private string email;
	private long points;
	private Faction aFaction;
	private List<Achievement> achievements;
	
	
	public Member(string username, string email, int points, Faction aFaction,
			List<Achievement> achievements) {
		this.username = username;
		this.email = email;
		this.points = points;
		this.aFaction = aFaction;
		if(achievements != null){
			this.achievements = achievements;
		}else{
			this.achievements = new List<Achievement>();
		}
	}

	public Member(JSONObject obj) {
		setUsername(obj.GetField("username").ToString());
		setEmail(obj.GetField("email").ToString());
		setPoints((100));
	}

	public JSONObject encode() {
		JSONObject obj = new JSONObject();
		obj.AddField("username", getUsername());
		obj.AddField("email", getEmail());
		obj.AddField("points", getPoints());
		JSONObject arr = JSONObject.arr;
		/*
		for(Achievement a : achievements){
			arr.add(a.encode());
		}
		*/
		obj.AddField("achievements", arr);
		return obj;
	}
	public string getUsername() {
		return username;
	}


	public void setUsername(string username) {
		this.username = username;
	}


	public string getEmail() {
		return email;
	}


	public void setEmail(string email) {
		this.email = email;
	}


	public long getPoints() {
		return points;
	}


	public void setPoints(long points) {
		this.points = points;
	}


	public Faction getaFaction() {
		return aFaction;
	}


	public void setaFaction(Faction aFaction) {
		this.aFaction = aFaction;
	}


	public List<Achievement> getAchievements() {
		return achievements;
	}


	public void setAchievements(List<Achievement> achievements) {
		this.achievements = achievements;
	}

	public string tostring() {
		return "Member [username=" + username + ", email=" + email
				+ ", points=" + points + ", aFaction=" + aFaction
				+ ", achievements=" + achievements + "]";
	}
}
