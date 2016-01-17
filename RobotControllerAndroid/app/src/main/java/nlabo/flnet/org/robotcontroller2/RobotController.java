package nlabo.flnet.org.robotcontroller2;

import java.util.Timer;
import java.util.TimerTask;

import android.app.Activity;
import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Rect;
import android.os.Bundle;
import android.view.KeyEvent;
import android.view.MotionEvent;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.view.inputmethod.InputMethodManager;
import android.widget.Button;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.TextView;
import android.widget.TextView.OnEditorActionListener;

public class RobotController extends Activity {
	private TextView txt;
	private TextView txtAct;
	private RobotControllerStage stage;
	android.os.Handler handler=new android.os.Handler();
    static public class DrawingView extends View{
    	public RobotControllerStage stage;
    	public DrawingView(Context context,RobotControllerStage stage){
    		super(context);
    		this.stage=stage;
    	}
    	
    	protected void onDraw(Canvas canvas){
    		int cw=canvas.getWidth();
    		int ch=canvas.getHeight();
    	
    		stage.Draw(canvas);
    	}
    }
    private DrawingView dv;
    private LinearLayout ll;
    private Button btn;
    private Button playBtn;
    private Button loadBtn;
    private EditText loadId;
    /** Called when the activity is first created. */
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        getWindow().addFlags(WindowManager.LayoutParams.FLAG_KEEP_SCREEN_ON);
        setContentView(R.layout.main);
        txt=(TextView)findViewById(R.id.TextStatus);
        txtAct=(TextView)findViewById(R.id.TextAction);
        dv=new DrawingView(this,null);
        ll=(LinearLayout)findViewById(R.id.myLayout);
        btn=(Button)findViewById(R.id.btnConnection);
        ll.addView(dv);
        //
        playBtn=(Button)findViewById(R.id.btnPlay);
        loadBtn=(Button)findViewById(R.id.btnLoad);
        loadId=(EditText)findViewById(R.id.edittext);
        loadId.setText("0");
        loadId.setOnEditorActionListener(new OnEditorActionListener() {
        	@Override
        	public boolean onEditorAction(TextView v, int actionId, KeyEvent event) {
        		if(event.getKeyCode() == KeyEvent.KEYCODE_ENTER){
        			InputMethodManager imm = (InputMethodManager)getSystemService(INPUT_METHOD_SERVICE);
        			imm.hideSoftInputFromWindow(v.getWindowToken(), InputMethodManager.HIDE_IMPLICIT_ONLY);
        			imm.hideSoftInputFromWindow(v.getWindowToken(), InputMethodManager.HIDE_NOT_ALWAYS);
        		}
        		return true;
        	}
        });
    }

	int limit;
	Timer timer;
	Timer timerAnime;
	@Override
	public void onWindowFocusChanged(boolean hasFocus) {
		// public void onResume(){
		if (hasFocus) {
			limit = 5000;
			DisplayScale scale = new DisplayScale(600, 700, dv.getWidth(), dv.getHeight());
			dv.stage = stage = new RobotControllerStage(scale);

			timer = new Timer(false);
			timer.schedule(new TimerTask() {
				public void run() {
					handler.post(new Runnable() {
						public void run() {
							int i=stage.Update();
							txt.setText("u:"+i+","+stage.st+","+stage.nowState);
							txtAct.setText(stage.actionMsg);
							dv.invalidate();
						}
					});
				}
			}, 0, 1000);
			timerAnime = new Timer(false);
			timerAnime.schedule(new TimerTask() {
				public void run() {
					handler.post(new Runnable() {
						public void run() {
							stage.AnimeUpdate();
							dv.invalidate();
						}
					});
				}
			}, 0, 50);
			//
			Vec2 pos=new Vec2(dv.getWidth()/2,dv.getHeight()/2);
	    	Vec2 center=new Vec2(dv.getWidth()/2,dv.getHeight()/2);
	        stage.SetCenter(center);
	        stage.initPoint(pos);
	        //
	        isConnected=false;
		}
	}
	public boolean isConnected;
	public void connection(View view){
		if(!isConnected){
			int ret=stage.connect();
			if(ret==1){
				btn.setText("disconnect");
				stage.actionMsg=("connected");
				isConnected=true;
			}else{
				txtAct.setText("miss connection"+ret);
			}
		}else{
			stage.close();
			stage.actionMsg=("disconnected");
			btn.setText("connect");
			isConnected=false;
		}
	}
	public void playSend(View view){
		txt.setText("play");
		if(isConnected){
			stage.send("@pl");
		}
	}
	public void loadSend(View view){
		txt.setText("load");
		if(isConnected){
			String msg="@wv"+loadId.getText();
			stage.send(msg);
		}
	}
	public void clear(View view){
		txt.setText("clear");
	}
    @Override
    public boolean onTouchEvent(MotionEvent event) {
    	Rect rect= new Rect();
    	Window window= this.getWindow();
    	window.getDecorView().getWindowVisibleDisplayFrame(rect);
    	int statusBarHeight= rect.top;
    	Vec2 now=new Vec2(event.getX(),event.getY());
        String action = "";
        switch (event.getAction()) {
        case MotionEvent.ACTION_DOWN:
		    {
		    	Vec2 pos=new Vec2(dv.getLeft(),dv.getTop()+statusBarHeight);
		    	Vec2 center=new Vec2(dv.getWidth()/2,dv.getHeight()/2);
		        action = "ACTION_DOWN";
		        stage.SetCenter(center);
		        int i=stage.SetPoint(now.getSub(pos));
		        txt.setText("act:"+i);
		        //txt.setText(action+now.x+","+now.y+":"+pos.x+","+pos.y+","+statusBarHeight);
		    }
            break;
        case MotionEvent.ACTION_UP:
        	action = "ACTION_UP";
            break;
        case MotionEvent.ACTION_MOVE:
            action = "ACTION_MOVE";
            break;
        case MotionEvent.ACTION_CANCEL:
            action = "ACTION_CANCEL";
            break;
        }
        
        return super.onTouchEvent(event);
    }
}