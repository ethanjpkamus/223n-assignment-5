//Author: Ethan Kamus
//Email: ethanjpkamus@csu.fullerton.edu

/* The purpose of this program is to show the use of mouse click
 * events and how to change the animation of an "apple" whenever
 * it is clicked on. The goal is to have multiple apples on the
 * screen at once, but try with just one first
 *
 * This module specifically implements Form and contains the methods necessary
 * for this game to function properly
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;

public class appletreeuserinterface : Form {

	//constants
	private const int MAXIMUM_FORM_WIDTH = 500;
	private const int MAXIMUM_FORM_HEIGHT = 800;
	private const int APPLE_RADIUS = 20;
	private const int GREENTOP = 500; //y value

	//variables
	private int apple_x = random.Next(MAXIMUM_FORM_WIDTH - 2*APPLE_RADIUS);
	private int apple_y = 0;
	private int applecenter_x = 0;
	private int applecenter_y = 0;
	private int mouse_x = 0;
	private int mouse_y = 0;
	private int distance = 0;
	private int apples_caught = 0;

	private bool is_apple_caught = false;

	//items to be used in the user interface
	private Button start_button = new Button();
	private Button restart_button = new Button();
	private Button quit_button = new Button();

	private Label level_label = new Label();
	private Label apples_caught_label = new Label();

	private static System.Timers.Timer ui_clock = new System.Timers.Timer();
	private static System.Timers.Timer animation_clock = new System.Timers.Timer();

	//constructor
	public appletreeuserinterface(){

		MaximumSize = new Size(MAXIMUM_FORM_WIDTH,MAXIMUM_FORM_HEIGHT);
		MinimumSize = new Size(MAXIMUM_FORM_WIDTH,MAXIMUM_FORM_HEIGHT);

		Text = "Apple Tree Game by: Ethan Kamus";

		BackColor = Color.White;

		DoubleBuffered = true;

		ui_clock.Interval = 33.3; //30 Hz
		ui_clock.Enabled = true;
		ui_clock.AutoReset = true;
		ui_clock.Elapsed += new ElapsedEventHandler(manage_ui);

		animation_clock.Interval = 16.6; //60 Hz
		animation_clock.Enabled = false;
		animation_clock.AutoReset = true;
		animation_clock.Elapsed += new ElapsedEventHandler(manage_animation);

		start_button.Text = "START";
		start_button.Size = new Size(75,30);
		start_button.Location = new Point(10,GREENTOP+100);
		start_button.Click += new EventHandler(manage_start_button);

		restart_button.Text = "RESET";
		restart_button.Size = new Size(75,30);
		restart_button.Location = new Point(95,GREENTOP+100);
		restart_button.Click += new EventHandler(update_restart_button);

		quit_button.Text = "QUIT";
		quit_button.Size = new Size(75,30);
		quit_button.Location = new Point(180,GREENTOP+100);
		quit_button.Click = new EventHandler(update_quit_button);

		level_label.Text = "Level: 0";
		level_label.ForeColor = Color.White;
		level_label.BackColor = Color.Green;

		apples_caught_label.Text = "Apples Caught: 0";
		apples_caught_label.ForeColor = Color.White;
		apples_caught_label.BackColor = Color.Green;

		Controls.Add(start_button);
		Controls.Add(restart_button);
		Conrtols.Add(quit_button);
		Controls.Add(level_label);
		Controls.Add(apples_caught_label);


	} //end of constructor

	protected override void OnPaint(PaintEventArgs e){

		Graphics graph = e.Graphics;

		graph.FillRectangle(Brushes.Green,0,GREENTOP,500,300); //grass
		graph.FillRectangle(Brushes.Cyan,0,0,500,500); //sky

		if(animation_clock.Enabled){
		//only paint the ellipse if the clock is enabled
			graph.FillEllipse(Brushes.Red,apple_x,apple_y,APPLE_RADIUS,APPLE_RADIUS);
		}
		base.OnPaint(e);

	} //end of OnPaint override

	protected override void OnMouseDown(MouseEventsArgs e){
		mouse_x = e.X;
		mouse_y = e.Y;
		distance = (mouse_x - (applecenter_x + radius*radius))
		 	  + (mouse_y - (applecenter_y + radius*radius));

		//checks if the click was above the green border
	  	//and if it was within the circle.
		if(applecenter_y > (GREENTOP + APPLE_RADIUS*APPLE_RADIUS)
		   && (distance*distance) < (radius*radius)){

			apples_caught++;
			is_apple_caught = true;

			//make new x pos for apple
			apple_x = random.Next(MAXIMUM_FORM_WIDTH - 2*APPLE_RADIUS);

		}

	} //end of OnMouseDown override

	protected void manage_ui(Object o, ElapsedEventArgs e){

		Invalidate();

	} //end of manage_ui

	protected void manage_animation(Object o, ElapsedEventArgs e){
		apple_y++;
		applecenter_y += appley;

		//check if the ball has touched the bottom of the screen.


	} //end of manage_animation

	protected void update_start_button(Object o, EventArgs e){
		if(animation_clock.Enabled){
			start_button.Text = "Pause";
		}
		start_button.Text = "Resume";
	} //end of update_start_button

	protected void update_restart_button(Object o, EventArgs e){

	} //end of update_restart_button

} //end of ricochetballuserinterface implementation
