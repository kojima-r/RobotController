package nlabo.flnet.org.robotcontroller2;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.net.InetSocketAddress;
import java.net.Socket;
import java.net.SocketAddress;
import java.net.UnknownHostException;

import android.graphics.Canvas;
import android.graphics.Paint;

public class RobotControllerStage {
	private DisplayScale scale;
	private Vec2 now;
	private Vec2 previous;
	private boolean moving;
	public int nowState;
	private double oldrad;
	private double rad;
	private double turn;
	private double distance;
	public String actionMsg;
	public RobotControllerStage(DisplayScale sc){
		scale=sc;
		radius=1.0f;
		pointAnimation=0;
		frame=0;
		//
		now=new Vec2(0,0);
		center=new Vec2(0,0);
		nowState=0;
		moving=false;
	}
	private int pointAnimation;
	public void initPoint(Vec2 v){
		previous=v;
	}
	public int SetPoint(Vec2 v){
		if(!moving){
			try{
				if(writer!=null){
					writer.write("@mp");
					writer.flush();
				}
			}catch(IOException e){
				return 0;
			}
			pointAnimation=20;
			now=v;
			Vec2 vec=now.getSub(previous);
			distance=vec.getLength();
			oldrad=rad;
			rad=Math.atan2(-vec.x,-vec.y);
			turn=(rad-oldrad)*180/Math.PI;
			if(turn>180){
				turn=360-turn;
			}
			if(turn<-180){
				turn=360+turn;
			}
			nowState=0;
			try{
				if(writer!=null){
					moving=true;
					int t=(int)turn;
					actionMsg="send message:"+("@tp"+t);
					writer.write("@tp"+t);
					writer.flush();
				}else{
					int t=(int)turn;
					actionMsg="virtual message:"+("@tp"+t);
				}
			}catch(IOException e){
				return 2;
			}
			return 1;
		}else{
			
		}
		return 3;
	}
	private Vec2 center;
	public void SetCenter(Vec2 v){
		center=v;
	}
	public String st;
	private int frame;
	public void AnimeUpdate(){
		if(pointAnimation>0){
			radius=5+pointAnimation;
			pointAnimation-=1;
		}
	}
	public int Update(){
		//
		if(moving){
			try{
				writer.write("@st");
				writer.flush();
			}catch(IOException e){
				return 3;
			}
			char[] buf=new char[32];
			int offset=0;
			
			do{
				try{
					reader.read(buf,offset,1);
				}catch(IOException e){
					return 3;
				}
				offset+=1;
			}while(buf[offset-1]!=';');
			st=String.copyValueOf(buf);
			if(st.indexOf('0')!=-1){
				if(nowState==0){
					nowState=1;
					try{
						int d=(int)(distance/50);
						actionMsg="send message:"+("@fp"+d);
						writer.write("@fp"+d);
						writer.flush();
					}catch(IOException e){
						return 3;
					}
				}else{
					nowState=0;
					moving=false;
					actionMsg="move end";
				}
			}
			return 2;
		}
		//
		return 1;
	}
	public float radius;
	//描画
	public void Draw(Canvas canvas){
		Paint paint=new Paint();
		paint.setARGB(0x80, 0x00, 0x00, 0xff);
		//背景
		canvas.drawLine(center.x, 0, center.x, canvas.getHeight(), paint);
		canvas.drawLine(0, center.y, canvas.getWidth(), center.y, paint);
		canvas.drawCircle(center.x, center.y, canvas.getWidth()/4, paint);
		//タッチ点
		paint.setARGB(0xff, 0xff, 0x00, 0x00);
		canvas.drawCircle(now.x, now.y, radius, paint);
	}
	Socket connection = null;
    BufferedReader reader = null;
    BufferedWriter writer=null;
	public int connect() {
		try {//あいらぶラピス
            // サーバーへ接続
            connection = new Socket();
            SocketAddress addr=new InetSocketAddress("192.168.0.23",2000);
            connection.connect(addr);
            // 受信用
            reader = new BufferedReader(new InputStreamReader(connection.getInputStream()));
            // サーバーからのメッセージを受信
            //String message = reader.readLine();
            //　送信用
            writer=new BufferedWriter(new OutputStreamWriter(connection.getOutputStream()));
            writer.write("@mp");
            writer.flush();
            return 1;
        } catch (UnknownHostException e) {
            e.printStackTrace();
            return 2;
        } catch (IOException e) {
            e.printStackTrace();
            return 3;
        } finally {
            
        }
        
    }
	public void send(String msg){
		if(writer!=null){
            try {
				writer.write(msg);
				writer.flush();
			} catch (IOException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
            
		}
	}
	public void close(){
		try {
            // 接続終了処理
            if(reader!=null){
            	reader.close();
            	reader=null;
            }
            if(writer!=null){
            	writer.close();
            	writer=null;
            }
            if(connection!=null){
            	connection.close();
            	connection=null;
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
	}
}
