package com.example.lerpzapp;

import java.util.Random;

import android.os.Bundle;
import android.annotation.SuppressLint;
import android.app.Activity;
import android.support.v4.view.GestureDetectorCompat;
import android.view.GestureDetector;
import android.view.Menu;
import android.view.MotionEvent;
import android.view.View;
import android.view.View.OnTouchListener;
import android.widget.Button;
import android.widget.TextView;


public class MiniGame extends Activity {
	
	public final static String EXTRA_MESSAGE = "com.example.myfirstapp.MESSAGE";
	private GestureDetectorCompat mDetector; 
	Random r;
	Random r2;
	Random r3;
	Random r4;
	Random r5;
	
	Integer points =0;

	@SuppressLint("NewApi")
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_mini_game);
		
		r=new Random(32);
		r2=new Random(120);
		r3=new Random(8);
		r4=new Random(240);
		r5=new Random(349);
		
		final Button button = (Button)findViewById(R.id.button);
        button.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
            	points+=1;
        		
        		String print = "Points: "+points.toString();
        		
        		//Creating TextView Variable
                TextView text = (TextView) findViewById(R.id.tv);
               
                //Sets the new text to TextView (runtime click event)
                text.setText(print);
                
                float x = r.nextInt(500);
                float y = r.nextInt(675);
                
                if(y<150)
                	y+=100;
                
                
                button.setX(x);
                button.setY(y);
                
                if(v.hasOverlappingRendering()){
                	
                	x=r.nextInt(500);
                	y=r.nextInt(675);
                	
                	if(y<150)
                    	y+=100;
                	
                	button.setX(x);
                    button.setY(y);
                	
                }
                
            }
        });
        
        final Button button2 = (Button)findViewById(R.id.button2);
        button2.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
            	points+=1;
        		
        		String print = "Points: "+points.toString();
        		
        		//Creating TextView Variable
                TextView text = (TextView) findViewById(R.id.tv);
               
                //Sets the new text to TextView (runtime click event)
                text.setText(print);
                
                float x = r2.nextInt(500);
                float y = r2.nextInt(675);
                
                if(y<150)
                	y+=100;
                
                
                button2.setX(x);
                button2.setY(y);
                
                if(v.hasOverlappingRendering()){
                	
                	x=r2.nextInt(500);
                	y=r2.nextInt(675);
                	
                	if(y<150)
                    	y+=100;
                	
                	button2.setX(x);
                    button2.setY(y);
                	
                }
                
            }
        });
        
        final Button button3 = (Button)findViewById(R.id.button3);
        button3.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
            	points+=1;
        		
        		String print = "Points: "+points.toString();
        		
        		//Creating TextView Variable
                TextView text = (TextView) findViewById(R.id.tv);
               
                //Sets the new text to TextView (runtime click event)
                text.setText(print);
                
                float x = r3.nextInt(500);
                float y = r3.nextInt(675);
                
                if(y<150)
                	y+=100;
                
                
                button3.setX(x);
                button3.setY(y);
                
                if(v.hasOverlappingRendering()){
                	
                	x=r3.nextInt(500);
                	y=r3.nextInt(675);
                	
                	if(y<150)
                    	y+=100;
                	
                	button3.setX(x);
                    button3.setY(y);
                	
                }
               
            }
        });
        
        final Button button4 = (Button)findViewById(R.id.button4);
        button4.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
            	points+=1;
        		
        		String print = "Points: "+points.toString();
        		
        		//Creating TextView Variable
                TextView text = (TextView) findViewById(R.id.tv);
               
                //Sets the new text to TextView (runtime click event)
                text.setText(print);
                
                float x = r4.nextInt(500);
                float y = r4.nextInt(675);
                
                if(y<150)
                	y+=100;
                
                
                button4.setX(x);
                button4.setY(y);
                
                if(v.hasOverlappingRendering()){
                	
                	x=r4.nextInt(500);
                	y=r4.nextInt(675);
                	
                	if(y<150)
                    	y+=100;
                	
                	button4.setX(x);
                    button4.setY(y);
                	
                }
               
            }
        });
        
        final Button button5 = (Button)findViewById(R.id.button5);
        button5.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
            	points+=1;
        		
        		String print = "Points: "+points.toString();
        		
        		//Creating TextView Variable
                TextView text = (TextView) findViewById(R.id.tv);
               
                //Sets the new text to TextView (runtime click event)
                text.setText(print);
                
                float x = r5.nextInt(500);
                float y = r5.nextInt(675);
                
                if(y<150)
                	y+=100;
                
                
                button5.setX(x);
                button5.setY(y);
                
                if(v.hasOverlappingRendering()){
                	
                	x=r5.nextInt(500);
                	y=r5.nextInt(675);
                	
                	if(y<150)
                    	y+=100;
                	
                	button5.setX(x);
                    button5.setY(y);
                	
                }
               
            }
        });
        
        mDetector = new GestureDetectorCompat(this, new MyGestureListener());
   
        
	}
	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.activity_mini_game, menu);
		return true;
	}
	
	@Override 
    public boolean onTouchEvent(MotionEvent event){ 
        this.mDetector.onTouchEvent(event);
        return super.onTouchEvent(event);
    }
	
	class MyGestureListener extends GestureDetector.SimpleOnGestureListener {
        private static final String DEBUG_TAG = "Gestures"; 
        
        @Override
        public boolean onDown(MotionEvent event) {  
            return true;
        }

        @SuppressLint("NewApi")
		public boolean onSingleTapUp(MotionEvent event){
        	
        	Button button = (Button)findViewById(R.id.button);
        	Button button2 = (Button)findViewById(R.id.button2);
        	Button button3 = (Button)findViewById(R.id.button3);
        	Button button4 = (Button)findViewById(R.id.button4);
        	Button button5 = (Button)findViewById(R.id.button5);
        	
        	if(!button.isActivated()&&points>0&&!button2.isActivated()&&!button3.isActivated()&&
        			!button4.isActivated()&&!button5.isActivated()){
        		
        		points-=1;
        		
        		String print = "Points: "+points.toString();
        		
        		//Creating TextView Variable
                TextView text = (TextView) findViewById(R.id.tv);
               
                //Sets the new text to TextView (runtime click event)
                text.setText(print);
        		
        	}
        	
        	
        	return true;
        }
    }

}
