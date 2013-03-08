using UnityEngine;
using System.Collections;

public class TCPNetworkScript {
	
	System.Net.Sockets.TcpClient client = null;
	System.Net.Sockets.NetworkStream stream = null;
	
	public TCPNetworkScript() {
	}
	
	public TCPNetworkScript(string address, int port) {
		this.client = new System.Net.Sockets.TcpClient(address, port);
	}
	
	byte[] GetBytes(string str) {
	    var bytes = System.Text.Encoding.UTF8.GetBytes(str);
	    return bytes;
	}
	
	string GetString(byte[] bytes) {
	    var str = System.Text.Encoding.UTF8.GetString(bytes);
	    return str;
	}
	
	public void SendData(string str) {
		stream = client.GetStream();
		stream.ReadTimeout = 10;
		
		byte[] data = GetBytes(str);	
		stream.Write(data, 0, data.Length);
		
	    byte[] bytes = new byte[1024];
	    stream.Read(bytes, 0, 1024);
	    Debug.Log( GetString(bytes) );
		
		stream.Close();
		client.Close();
	}
	
	public void SendData(string address, int port, string str) {
		this.client = new System.Net.Sockets.TcpClient(address, port);
		stream = client.GetStream();
		stream.ReadTimeout = 10;
		
		byte[] data = GetBytes(str);	
		stream.Write(data, 0, data.Length);
		
	    byte[] bytes = new byte[1024];
	    stream.Read(bytes, 0, 1024);
	    Debug.Log( GetString(bytes) );
		
		stream.Close();
		client.Close();
	}
}
