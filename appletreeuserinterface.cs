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
	private const int FORM_X_CENTER = (MAXIMUM_FORM_WIDTH / 2) - BALL_RADIUS;
	private const int FORM_Y_CENTER = (MAXIMUM_FORM_HEIGHT / 2) - 50 - BALL_RADIUS;
	private const int GREENTOP = 500; //y value

	//variables
	private int applex = 0;
	private int appley = 0;
	private int mousex = 0;
	private int mousey = 0;

	private int apples_caught = 0;

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



	} //end of constructor

	protected override void OnPaint(PaintEventArgs e){

		Graphics graph = e.Graphics;

		graph.FillRectangle(Brushes.Green,0,GREENTOP,500,300);
		graph.FillRectangle(Brushes.Cyan,0,0,500,500);

		graph.FillEllipse(Brushes.Red,applex,appley,APPLE_RADIUS,APPLE_RADIUS);

		base.OnPaint(e);

	} //end of OnPaint override

	protected override void OnMouseDown(MouseEventsArgs e){

	} //end of OnMouseDown override

	protected void manage_ui(Object o, ElapsedEventArgs e){

		Invalidate();

	} //end of manage_ui

	protected void manage_animation(Object o, ElapsedEventArgs e){

	} //end of manage_animation

	protected void update_start_button(Object o, EventArgs e){

	} //end of update_start_button

	protected void update_restart_button(Object o, EventArgs e){

	} //end of update_restart_button

} //end of ricochetballuserinterface implementation
