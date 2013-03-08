package com.group3.angrybots;

import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.view.Menu;

public class MainActivity extends Activity {
	public enum Race {
		HUMAN, ROBOT
	}
	public static Race race = null;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.activity_main, menu);
        return true;
    }
    
    @Override
    public void onResume() {
    	super.onResume();
        Intent intent = new Intent(this, LoginActivity.class);
    	if (MainActivity.race != null) {
    		switch (MainActivity.race) {
			case HUMAN:
				intent = new Intent(this, HumanHomePage.class);
				break;
			case ROBOT:
				
				break;

			default:
				break;
			}
    	}
        startActivity(intent);
    }
    
}
