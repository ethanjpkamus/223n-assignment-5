//Author: Ethan Kamus
//Email: ethanjpkamus@csu.fullerton.edu

/* The purpose of this program is to show the use of mouse click
 * events and how to change the animation of an "apple" whenever
 * it is clicked on. The goal is to have multiple apples on the
 * screen at once, but try with just one first
 *
 * This module specifically creates an object of the appletreeuserinterface Form
 * and begins running the game.
 */

using System;
using System.Windows.Forms;

public class appletreemain{

     static void Main(string[] args){

          System.Console.WriteLine("Welcome to the Main method of the Apple Tree Game.");
          appletreeuserinterface application = new appletreeuserinterface();
          Application.Run(application);
          System.Console.WriteLine("Main method will now shutdown.");

     }//End of Main

}//End of redlightmain
