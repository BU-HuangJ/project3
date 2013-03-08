public class Achievement {
	private string name;
	private int points;
	
	public Achievement(string name, int points) {
		this.name = name;
		this.points = points;
	}
	
	public JSONObject encode() {
		JSONObject obj = new JSONObject();
		obj.AddField("name", name);
		obj.AddField("points", points);
		return obj;
	}
	public string getName() {
		return name;
	}
	public void setName(string name) {
		this.name = name;
	}
	public int getPoints() {
		return points;
	}
	public void setPoints(int points) {
		this.points = points;
	}
}
