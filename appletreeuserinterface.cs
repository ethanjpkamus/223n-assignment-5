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

public class ricochetballuserinterface : Form {

	//constants

	//variables


	//items to be used in the user interface

	//constructor
	public ricochetballuserinterface(){

		MaximumSize = new Size(MAXIMUM_FORM_WIDTH,MAXIMUM_FORM_HEIGHT);
		MinimumSize = new Size(MAXIMUM_FORM_WIDTH,MAXIMUM_FORM_HEIGHT);

		Text = "Ricochet Ball Project by: Ethan Kamus";

		BackColor = Color.White;


	} //end of constructor

	protected override void OnPaint(PaintEventArgs e){

		Graphics graph = e.Graphics;

	} //end of OnPaint override

} //end of ricochetballuserinterface implementation
