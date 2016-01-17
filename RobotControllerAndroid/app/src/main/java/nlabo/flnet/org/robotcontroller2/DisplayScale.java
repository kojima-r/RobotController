package nlabo.flnet.org.robotcontroller2;

public class DisplayScale {
	private float scale_x;
	private float scale_y;
	private float w;
	private float h;
	public DisplayScale(float w,float h,float display_w,float display_h) {
		// TODO Auto-generated constructor stub
		scale_x=display_w/w;
		scale_y=display_h/h;
		this.w=w;
		this.h=h;
	}
	public float ScaleX(float x){
		return x*scale_x;
	}
	public float ScaleY(float y){
		return y*scale_y;
	}
	public float ScaleInvX(float x){
		return x/scale_x;
	}
	public float ScaleInvY(float y){
		return y/scale_y;
	}
	public float getW() {
		return w;
	}
	public float getH() {
		return h;
	}
}
